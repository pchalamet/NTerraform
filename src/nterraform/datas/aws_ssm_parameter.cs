using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_ssm_parameter")]
    public sealed class aws_ssm_parameter : nterraform.data
    {
        public aws_ssm_parameter(string @name,
                                 bool? @withDecryption = null)
        {
            @Name = @name;
            @WithDecryption = @withDecryption;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
        public string @Value { get; }

        [nterraform.TerraformProperty(name: "with_decryption", @out: false, min: 0, max: 1)]
        public bool? @WithDecryption { get; }
    }

}
