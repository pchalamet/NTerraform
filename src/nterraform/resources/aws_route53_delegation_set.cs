using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_route53_delegation_set")]
    public sealed class aws_route53_delegation_set : nterraform.Core.resource
    {
        public aws_route53_delegation_set(string @referenceName = null)
        {
            @ReferenceName = @referenceName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name_servers", @out: true, min: 0, max: 1)]
        public string[] @NameServers { get; }

        [nterraform.Core.TerraformProperty(name: "reference_name", @out: false, min: 0, max: 1)]
        public string @ReferenceName { get; }
    }

}
