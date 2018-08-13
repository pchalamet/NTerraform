using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_kms_alias")]
    public sealed class aws_kms_alias : nterraform.Core.resource
    {
        public aws_kms_alias(string @targetKeyId,
                             string @name = null,
                             string @namePrefix = null)
        {
            @TargetKeyId = @targetKeyId;
            @Name = @name;
            @NamePrefix = @namePrefix;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "target_key_id", @out: false, min: 1, max: 1)]
        public string @TargetKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "target_key_arn", @out: true, min: 0, max: 1)]
        public string @TargetKeyArn { get; }
    }

}
