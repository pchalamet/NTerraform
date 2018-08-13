using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dynamodb_global_table")]
    public sealed class aws_dynamodb_global_table : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "replica")]
        public sealed class replica : nterraform.structure
        {
            public replica(string @regionName)
            {
                @RegionName = @regionName;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "region_name", @out: false, min: 1, max: 1)]
            public string @RegionName { get; }
        }

        public aws_dynamodb_global_table(string @name,
                                         replica[] @replica)
        {
            @Name = @name;
            @Replica = @replica;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "replica", @out: false, min: 1, max: 0)]
        public replica[] @Replica { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
