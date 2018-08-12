using System;

namespace nterraform.Core
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
}