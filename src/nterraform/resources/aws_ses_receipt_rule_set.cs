using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ses_receipt_rule_set")]
    public sealed class aws_ses_receipt_rule_set : nterraform.resource
    {
        public aws_ses_receipt_rule_set(string @ruleSetName)
        {
            @RuleSetName = @ruleSetName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "rule_set_name", @out: false, min: 1, max: 1)]
        public string @RuleSetName { get; }
    }

}
