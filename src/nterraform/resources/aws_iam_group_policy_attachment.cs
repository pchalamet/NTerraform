using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_group_policy_attachment")]
    public sealed class aws_iam_group_policy_attachment : nterraform.Core.resource
    {
        public aws_iam_group_policy_attachment(string @group,
                                               string @policyArn)
        {
            @Group = @group;
            @PolicyArn = @policyArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "group", @out: false, min: 1, max: 1)]
        public string @Group { get; }

        [nterraform.Core.TerraformProperty(name: "policy_arn", @out: false, min: 1, max: 1)]
        public string @PolicyArn { get; }
    }

}
