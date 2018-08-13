using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_elasticache_subnet_group")]
    public sealed class aws_elasticache_subnet_group : nterraform.resource
    {
        public aws_elasticache_subnet_group(string @name,
                                            string[] @subnetIds,
                                            string @description = null)
        {
            @Name = @name;
            @SubnetIds = @subnetIds;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "subnet_ids", @out: false, min: 1, max: 1)]
        public string[] @SubnetIds { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}
