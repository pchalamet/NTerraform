using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_role_policy_attachment")]
    public sealed class aws_iam_role_policy_attachment : nterraform.resource
    {
        public aws_iam_role_policy_attachment(string @policyArn,
                                              string @role)
        {
            @PolicyArn = @policyArn;
            @Role = @role;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "policy_arn", @out: false, min: 1, max: 1)]
        public string @PolicyArn { get; }

        [nterraform.TerraformProperty(name: "role", @out: false, min: 1, max: 1)]
        public string @Role { get; }
    }

}
