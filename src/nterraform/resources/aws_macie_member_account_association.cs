using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_macie_member_account_association")]
    public sealed class aws_macie_member_account_association : nterraform.Core.resource
    {
        public aws_macie_member_account_association(string @memberAccountId)
        {
            @MemberAccountId = @memberAccountId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "member_account_id", @out: false, min: 1, max: 1)]
        public string @MemberAccountId { get; }
    }

}
