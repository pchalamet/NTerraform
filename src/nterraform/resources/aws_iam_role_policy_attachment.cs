using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_role_policy_attachment")]
    public sealed class aws_iam_role_policy_attachment : nterraform.Core.resource
    {
        public aws_iam_role_policy_attachment(string @policyArn,
                                              string @role)
        {
            @PolicyArn = @policyArn;
            @Role = @role;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "policy_arn", @out: false, min: 1, max: 1)]
        public string @PolicyArn { get; }

        [nterraform.Core.TerraformProperty(name: "role", @out: false, min: 1, max: 1)]
        public string @Role { get; }
    }

}
