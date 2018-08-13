using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_secretsmanager_secret")]
    public sealed class aws_secretsmanager_secret : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "rotation_rules")]
        public sealed class rotation_rules : nterraform.Core.structure
        {
            public rotation_rules(int @automaticallyAfterDays)
            {
                @AutomaticallyAfterDays = @automaticallyAfterDays;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "automatically_after_days", @out: false, min: 1, max: 1)]
            public int @AutomaticallyAfterDays { get; }
        }

        public aws_secretsmanager_secret(string @name,
                                         string @description = null,
                                         string @kmsKeyId = null,
                                         string @policy = null,
                                         int? @recoveryWindowInDays = null,
                                         string @rotationLambdaArn = null,
                                         rotation_rules[] @rotationRules = null,
                                         Dictionary<string,string> @tags = null)
        {
            @Name = @name;
            @Description = @description;
            @KmsKeyId = @kmsKeyId;
            @Policy = @policy;
            @RecoveryWindowInDays = @recoveryWindowInDays;
            @RotationLambdaArn = @rotationLambdaArn;
            @RotationRules = @rotationRules;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: false, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "recovery_window_in_days", @out: false, min: 0, max: 1)]
        public int? @RecoveryWindowInDays { get; }

        [nterraform.Core.TerraformProperty(name: "rotation_enabled", @out: true, min: 0, max: 1)]
        public bool? @RotationEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "rotation_lambda_arn", @out: false, min: 0, max: 1)]
        public string @RotationLambdaArn { get; }

        [nterraform.Core.TerraformProperty(name: "rotation_rules", @out: false, min: 0, max: 1)]
        public rotation_rules[] @RotationRules { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
