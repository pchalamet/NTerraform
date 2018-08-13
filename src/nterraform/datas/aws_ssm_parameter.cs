using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_ssm_parameter")]
    public sealed class aws_ssm_parameter : nterraform.Core.data
    {
        public aws_ssm_parameter(string @name,
                                 bool? @withDecryption = null)
        {
            @Name = @name;
            @WithDecryption = @withDecryption;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
        public string @Value { get; }

        [nterraform.Core.TerraformProperty(name: "with_decryption", @out: false, min: 0, max: 1)]
        public bool? @WithDecryption { get; }
    }

}
