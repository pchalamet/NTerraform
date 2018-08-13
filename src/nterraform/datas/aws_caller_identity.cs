using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_caller_identity")]
    public sealed class aws_caller_identity : nterraform.data
    {
        public aws_caller_identity()
        {
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_id", @out: true, min: 0, max: 1)]
        public string @AccountId { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "user_id", @out: true, min: 0, max: 1)]
        public string @UserId { get; }
    }

}
