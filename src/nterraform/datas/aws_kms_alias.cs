using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_kms_alias")]
    public sealed class aws_kms_alias : nterraform.data
    {
        public aws_kms_alias(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "target_key_arn", @out: true, min: 0, max: 1)]
        public string @TargetKeyArn { get; }

        [nterraform.TerraformProperty(name: "target_key_id", @out: true, min: 0, max: 1)]
        public string @TargetKeyId { get; }
    }

}
