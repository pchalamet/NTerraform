using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_group_policy_attachment")]
    public sealed class aws_iam_group_policy_attachment : nterraform.resource
    {
        public aws_iam_group_policy_attachment(string @group,
                                               string @policyArn)
        {
            @Group = @group;
            @PolicyArn = @policyArn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "group", @out: false, min: 1, max: 1)]
        public string @Group { get; }

        [nterraform.TerraformProperty(name: "policy_arn", @out: false, min: 1, max: 1)]
        public string @PolicyArn { get; }
    }

}
