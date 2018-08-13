using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ses_domain_dkim")]
    public sealed class aws_ses_domain_dkim : nterraform.resource
    {
        public aws_ses_domain_dkim(string @domain)
        {
            @Domain = @domain;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "domain", @out: false, min: 1, max: 1)]
        public string @Domain { get; }

        [nterraform.TerraformProperty(name: "dkim_tokens", @out: true, min: 0, max: 1)]
        public string[] @DkimTokens { get; }
    }

}
