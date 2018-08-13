using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace nterraform
{
    public sealed class configuration
    {
        private static Hosts.IHost FindHost()
        {
            var entryPoint = Assembly.GetEntryAssembly().GetName().Name;
            switch (entryPoint)
            {
                case "dotnet-script":
                    return new Hosts.DotnetScript();

                case "fsi":
                    return new Hosts.Fsi();

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

        public static void build()
        {
            var host = FindHost();
            var context = host.GetVariables();
            ProcessVariables(context);
        }
    }
}