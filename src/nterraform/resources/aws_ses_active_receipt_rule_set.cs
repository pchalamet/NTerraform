using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ses_active_receipt_rule_set")]
    public sealed class aws_ses_active_receipt_rule_set : nterraform.Core.resource
    {
        public aws_ses_active_receipt_rule_set(string @ruleSetName)
        {
            @RuleSetName = @ruleSetName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "rule_set_name", @out: false, min: 1, max: 1)]
        public string @RuleSetName { get; }
    }

}
