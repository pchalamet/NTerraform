using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_service_discovery_private_dns_namespace")]
    public sealed class aws_service_discovery_private_dns_namespace : nterraform.resource
    {
        public aws_service_discovery_private_dns_namespace(string @name,
                                                           string @vpc,
                                                           string @description = null)
        {
            @Name = @name;
            @Vpc = @vpc;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "vpc", @out: false, min: 1, max: 1)]
        public string @Vpc { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "hosted_zone", @out: true, min: 0, max: 1)]
        public string @HostedZone { get; }
    }

}
