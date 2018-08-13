using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_autoscaling_groups")]
    public sealed class aws_autoscaling_groups : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_autoscaling_groups(filter[] @filter = null)
        {
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "names", @out: true, min: 0, max: 1)]
        public string[] @Names { get; }
    }

}
