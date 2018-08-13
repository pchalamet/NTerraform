using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_kms_key")]
    public sealed class aws_kms_key : nterraform.resource
    {
        public aws_kms_key(int? @deletionWindowInDays = null,
                           bool? @enableKeyRotation = null,
                           bool? @isEnabled = null,
                           Dictionary<string,string> @tags = null)
        {
            @DeletionWindowInDays = @deletionWindowInDays;
            @EnableKeyRotation = @enableKeyRotation;
            @IsEnabled = @isEnabled;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "deletion_window_in_days", @out: false, min: 0, max: 1)]
        public int? @DeletionWindowInDays { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "enable_key_rotation", @out: false, min: 0, max: 1)]
        public bool? @EnableKeyRotation { get; }

        [nterraform.TerraformProperty(name: "is_enabled", @out: false, min: 0, max: 1)]
        public bool? @IsEnabled { get; }

        [nterraform.TerraformProperty(name: "key_id", @out: true, min: 0, max: 1)]
        public string @KeyId { get; }

        [nterraform.TerraformProperty(name: "key_usage", @out: true, min: 0, max: 1)]
        public string @KeyUsage { get; }

        [nterraform.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
