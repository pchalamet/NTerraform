using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_kms_key")]
    public sealed class aws_kms_key : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "deletion_window_in_days", @out: false, min: 0, max: 1)]
        public int? @DeletionWindowInDays { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "enable_key_rotation", @out: false, min: 0, max: 1)]
        public bool? @EnableKeyRotation { get; }

        [nterraform.Core.TerraformProperty(name: "is_enabled", @out: false, min: 0, max: 1)]
        public bool? @IsEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "key_id", @out: true, min: 0, max: 1)]
        public string @KeyId { get; }

        [nterraform.Core.TerraformProperty(name: "key_usage", @out: true, min: 0, max: 1)]
        public string @KeyUsage { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
