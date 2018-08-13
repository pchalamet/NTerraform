using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ses_domain_mail_from")]
    public sealed class aws_ses_domain_mail_from : nterraform.resource
    {
        public aws_ses_domain_mail_from(string @domain,
                                        string @mailFromDomain,
                                        string @behaviorOnMxFailure = null)
        {
            @Domain = @domain;
            @MailFromDomain = @mailFromDomain;
            @BehaviorOnMxFailure = @behaviorOnMxFailure;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "domain", @out: false, min: 1, max: 1)]
        public string @Domain { get; }

        [nterraform.TerraformProperty(name: "mail_from_domain", @out: false, min: 1, max: 1)]
        public string @MailFromDomain { get; }

        [nterraform.TerraformProperty(name: "behavior_on_mx_failure", @out: false, min: 0, max: 1)]
        public string @BehaviorOnMxFailure { get; }
    }

}
