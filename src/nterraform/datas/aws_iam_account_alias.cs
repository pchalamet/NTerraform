using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_iam_account_alias")]
    public sealed class aws_iam_account_alias : nterraform.data
    {
        public aws_iam_account_alias()
        {
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_alias", @out: true, min: 0, max: 1)]
        public string @AccountAlias { get; }
    }

}
