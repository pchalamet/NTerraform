using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_iam_account_alias")]
    public sealed class aws_iam_account_alias : nterraform.resource
    {
        public aws_iam_account_alias(string @accountAlias)
        {
            @AccountAlias = @accountAlias;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_alias", @out: false, min: 1, max: 1)]
        public string @AccountAlias { get; }
    }

}
