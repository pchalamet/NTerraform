using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_lightsail_domain")]
    public sealed class aws_lightsail_domain : nterraform.Core.resource
    {
        public aws_lightsail_domain(string @domainName)
        {
            @DomainName = @domainName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
        public string @DomainName { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
