using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_secretsmanager_secret")]
    public sealed class aws_secretsmanager_secret : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "rotation_rules")]
        public sealed class rotation_rules : nterraform.structure
        {
            public rotation_rules()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "automatically_after_days", @out: true, min: 0, max: 1)]
            public int? @AutomaticallyAfterDays { get; }
        }

        public aws_secretsmanager_secret(rotation_rules[] @rotationRules = null)
        {
            @RotationRules = @rotationRules;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "rotation_enabled", @out: true, min: 0, max: 1)]
        public bool? @RotationEnabled { get; }

        [nterraform.TerraformProperty(name: "rotation_lambda_arn", @out: true, min: 0, max: 1)]
        public string @RotationLambdaArn { get; }

        [nterraform.TerraformProperty(name: "rotation_rules", @out: false, min: 0, max: 0)]
        public rotation_rules[] @RotationRules { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
