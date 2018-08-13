using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_iam_account_alias")]
    public sealed class aws_iam_account_alias : nterraform.Core.data
    {
        public aws_iam_account_alias()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "account_alias", @out: true, min: 0, max: 1)]
        public string @AccountAlias { get; }
    }

}
