using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ses_domain_identity")]
    public sealed class aws_ses_domain_identity : nterraform.resource
    {
        public aws_ses_domain_identity(string @domain)
        {
            @Domain = @domain;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "domain", @out: false, min: 1, max: 1)]
        public string @Domain { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "verification_token", @out: true, min: 0, max: 1)]
        public string @VerificationToken { get; }
    }

}
