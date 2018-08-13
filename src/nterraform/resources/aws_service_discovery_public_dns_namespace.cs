using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_service_discovery_public_dns_namespace")]
    public sealed class aws_service_discovery_public_dns_namespace : nterraform.Core.resource
    {
        public aws_service_discovery_public_dns_namespace(string @name,
                                                          string @description = null)
        {
            @Name = @name;
            @Description = @description;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "hosted_zone", @out: true, min: 0, max: 1)]
        public string @HostedZone { get; }
    }

}
