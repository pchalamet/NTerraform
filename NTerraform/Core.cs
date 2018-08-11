using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace NTerraform
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TerraformStructureAttribute : Attribute
    {
        public TerraformStructureAttribute(string category, string typeName)
        {
            Category = category;
            TypeName = typeName;
        }

        public string Category { get; }
        public string TypeName { get; }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class TerraformPropertyAttribute : Attribute
    {
        public TerraformPropertyAttribute(string name, bool @out, int min, int max)
        {
            Name = name;
            Out = @out;
            Min = min;
            Max = max;
        }

        public string Name { get; }
        public bool Out { get; }
        public int Min { get; }
        public int Max { get; }
    }




    public abstract class structure
    {
        protected void _validate_()
        {
            foreach (var prop in GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var propAttribute = prop.GetCustomAttribute<TerraformPropertyAttribute>();
                if (propAttribute.Out)
                    continue;

                var value = prop.GetValue(this);

                if (propAttribute.Min != 0 && null == value)
                    throw new ApplicationException($"Property {prop.Name} is mandatory");

                switch (value)
                {
                    case null:
                        if (propAttribute.Min != 0)
                            throw new ApplicationException($"Property {prop.Name} is mandatory");
                        break;

                    case object[] arr:
                        if (propAttribute.Min != 0 && arr.Length < propAttribute.Min)
                            throw new ApplicationException($"Expecting at least {propAttribute.Min} items in property {prop.Name}");
                        if (propAttribute.Max != 0 && propAttribute.Max < arr.Length)
                            throw new ApplicationException($"Expecting at most {propAttribute.Max} items in property {prop.Name}");
                        break;
                }
            }
        }
    }

    public abstract class data : structure
    {
    }

    public abstract class provider : structure
    {
    }

    public abstract class resource : structure
    {
    }

    public sealed class schema
    {
        private static IHost FindHost()
        {
            var entryPoint = Assembly.GetEntryAssembly().GetName().Name;
            switch (entryPoint)
            {
                case "dotnet-script":
                    return new DotnetScriptHost();

                case "fsi":
                    return new FsiHost();

                default:
                    throw new ApplicationException($"Unknown host ${entryPoint}");
            }
        }

        private static object Format(object o)
        {
            switch (o)
            {
                case null:
                    return null;

                case string s:
                    return $"\"{s}\"";

                case int i:
                    return $"\"{i}\"";

                case bool b:
                    return b ? "\"true\"" : "\"false\"";

                case string[] arr:
                    return "[ " + String.Join(", ", arr.Select(x => $"\"{x}\"")) + " ]";

                case int[] arr:
                    return "[ " + String.Join(", ", arr.Select(x => $"\"{x}\"")) + " ]";

                case bool[] arr:
                    return "[ " + String.Join(", ", arr.Select(x => x ? "\"true\"" : "\"false\"")) + " ]";

                default:
                    return o;
            }
        }

        private static void WriteObject(int indent, string decl, object var)
        {
            var sindent = new String(' ', indent);
            var typeAttribute = var.GetType().GetCustomAttribute<TerraformStructureAttribute>();

            Console.WriteLine($"{decl} {{");
            foreach (var prop in var.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var propAttribute = prop.GetCustomAttribute<TerraformPropertyAttribute>();
                if (propAttribute.Out)
                    continue;

                var value = prop.GetValue(var);
                switch (Format(value))
                {
                    case null:
                        break;

                    case string s:
                        Console.WriteLine($"  {sindent}{propAttribute.Name} = {s}");
                        break;

                    case object[] arr:
                        foreach (var item in arr)
                            WriteObject(indent + 2, $"  {sindent}{propAttribute.Name} =", Format(item));
                        break;

                    default:
                        throw new ArgumentException("Unknown type");
                }
            }

            Console.WriteLine($"{sindent}}}");
        }


        private static void ProcessVariable(string name, object var)
        {
            var typeAttribute = var.GetType().GetCustomAttribute<TerraformStructureAttribute>();
            var decl = $"{typeAttribute.Category} \"{typeAttribute.TypeName}\" \"{name}\"";
            WriteObject(0, decl, var);
            Console.WriteLine();
        }


        private static void ProcessVariables(Dictionary<string, object> context)
        {
            foreach (var kvp in context)
                ProcessVariable(kvp.Key, kvp.Value);
        }


        public static void Build()
        {
            var host = FindHost();
            var context = host.GetVariables();
            ProcessVariables(context);
        }
    }
}