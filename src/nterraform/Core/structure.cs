using System;
using System.Reflection;

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
    }
}