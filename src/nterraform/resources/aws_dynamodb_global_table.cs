using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dynamodb_global_table")]
    public sealed class aws_dynamodb_global_table : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "replica")]
        public sealed class replica : nterraform.Core.structure
        {
            public replica(string @regionName)
            {
                @RegionName = @regionName;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "region_name", @out: false, min: 1, max: 1)]
            public string @RegionName { get; }
        }

        public aws_dynamodb_global_table(string @name,
                                         replica[] @replica)
        {
            @Name = @name;
            @Replica = @replica;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "replica", @out: false, min: 1, max: 0)]
        public replica[] @Replica { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
