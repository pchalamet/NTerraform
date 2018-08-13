using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_instances")]
    public sealed class aws_instances : nterraform.Core.data
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

        public aws_instances(filter[] @filter = null,
                             string[] @instanceStateNames = null)
        {
            @Filter = @filter;
            @InstanceStateNames = @instanceStateNames;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "ids", @out: true, min: 0, max: 1)]
        public string[] @Ids { get; }

        [nterraform.Core.TerraformProperty(name: "instance_state_names", @out: false, min: 0, max: 1)]
        public string[] @InstanceStateNames { get; }

        [nterraform.Core.TerraformProperty(name: "instance_tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @InstanceTags { get; }

        [nterraform.Core.TerraformProperty(name: "private_ips", @out: true, min: 0, max: 1)]
        public string[] @PrivateIps { get; }

        [nterraform.Core.TerraformProperty(name: "public_ips", @out: true, min: 0, max: 1)]
        public string[] @PublicIps { get; }
    }

}
