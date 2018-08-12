using System;

namespace nterraform.Core
{
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
}