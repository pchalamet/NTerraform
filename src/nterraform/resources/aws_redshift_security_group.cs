using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_redshift_security_group")]
    public sealed class aws_redshift_security_group : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "ingress")]
        public sealed class ingress : nterraform.structure
        {
            public ingress(string @cidr = null)
            {
                @Cidr = @cidr;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cidr", @out: false, min: 0, max: 1)]
            public string @Cidr { get; }

            [nterraform.TerraformProperty(name: "security_group_name", @out: true, min: 0, max: 1)]
            public string @SecurityGroupName { get; }

            [nterraform.TerraformProperty(name: "security_group_owner_id", @out: true, min: 0, max: 1)]
            public string @SecurityGroupOwnerId { get; }
        }

        public aws_redshift_security_group(ingress[] @ingress,
                                           string @name,
                                           string @description = null)
        {
            @Ingress = @ingress;
            @Name = @name;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "ingress", @out: false, min: 1, max: 0)]
        public ingress[] @Ingress { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}
