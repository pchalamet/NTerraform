using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_network_acls")]
    public sealed class aws_network_acls : nterraform.Core.data
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

        public aws_network_acls(filter[] @filter = null,
                                string @vpcId = null)
        {
            @Filter = @filter;
            @VpcId = @vpcId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "ids", @out: true, min: 0, max: 1)]
        public string[] @Ids { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
