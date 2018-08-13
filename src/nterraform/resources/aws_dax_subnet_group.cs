using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dax_subnet_group")]
    public sealed class aws_dax_subnet_group : nterraform.Core.resource
    {
        public aws_dax_subnet_group(string @name,
                                    string[] @subnetIds,
                                    string @description = null)
        {
            @Name = @name;
            @SubnetIds = @subnetIds;
            @Description = @description;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_ids", @out: false, min: 1, max: 1)]
        public string[] @SubnetIds { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
