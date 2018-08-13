using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_account_alias")]
    public sealed class aws_iam_account_alias : nterraform.Core.resource
    {
        public aws_iam_account_alias(string @accountAlias)
        {
            @AccountAlias = @accountAlias;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "account_alias", @out: false, min: 1, max: 1)]
        public string @AccountAlias { get; }
    }

}
