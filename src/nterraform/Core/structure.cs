using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace nterraform
{
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
                    return "[ " + string.Join(", ", arr.Select(x => $"\"{x}\"")) + " ]";

                case int[] arr:
                    return "[ " + string.Join(", ", arr.Select(x => $"\"{x}\"")) + " ]";

                case bool[] arr:
                    return "[ " + string.Join(", ", arr.Select(x => x ? "\"true\"" : "\"false\"")) + " ]";

                default:
                    return o;
            }
        }

        private static IEnumerable<string> WriteObject(int indent, string decl, object var)
        {
            var sindent = new String(' ', indent);
            var typeAttribute = var.GetType().GetCustomAttribute<TerraformStructureAttribute>();

            var result = (IEnumerable<string>)new[] { $"{decl} {{" };
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
                        result = result.Append($"  {sindent}{propAttribute.Name} = {s}");
                        break;

                    case object[] arr:
                        result = arr.Select(x => WriteObject(indent + 2, $"  {sindent}{propAttribute.Name} =", Format(x)))
                                    .Aggregate(result, (acc, lines) => acc.Concat(lines));
                        break;

                    // TODO: support Dictionary

                    default:
                        throw new ArgumentException("Unknown type");
                }
            }

            return result.Append($"{sindent}}}");
        }

        public IEnumerable<string> WriteObject(string name)
        {
            var typeAttribute = GetType().GetCustomAttribute<TerraformStructureAttribute>();
            var decl = $"{typeAttribute.Category} \"{typeAttribute.TypeName}\" \"{name}\"";
            var result = WriteObject(0, decl, this).Append("");
            return result;
        }
    }
}