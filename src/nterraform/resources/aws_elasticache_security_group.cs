using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_elasticache_security_group")]
    public sealed class aws_elasticache_security_group : nterraform.resource
    {
        public aws_elasticache_security_group(string @name,
                                              string[] @securityGroupNames,
                                              string @description = null)
        {
            @Name = @name;
            @SecurityGroupNames = @securityGroupNames;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "security_group_names", @out: false, min: 1, max: 1)]
        public string[] @SecurityGroupNames { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}
