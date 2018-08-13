using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_organizations_policy_attachment")]
    public sealed class aws_organizations_policy_attachment : nterraform.resource
    {
        public aws_organizations_policy_attachment(string @policyId,
                                                   string @targetId)
        {
            @PolicyId = @policyId;
            @TargetId = @targetId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "policy_id", @out: false, min: 1, max: 1)]
        public string @PolicyId { get; }

        [nterraform.TerraformProperty(name: "target_id", @out: false, min: 1, max: 1)]
        public string @TargetId { get; }
    }

}
