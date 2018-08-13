using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ebs_snapshot")]
    public sealed class aws_ebs_snapshot : nterraform.Core.resource
    {
        public aws_ebs_snapshot(string @volumeId,
                                string @description = null,
                                Dictionary<string,string> @tags = null)
        {
            @VolumeId = @volumeId;
            @Description = @description;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "volume_id", @out: false, min: 1, max: 1)]
        public string @VolumeId { get; }

        [nterraform.Core.TerraformProperty(name: "data_encryption_key_id", @out: true, min: 0, max: 1)]
        public string @DataEncryptionKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "owner_alias", @out: true, min: 0, max: 1)]
        public string @OwnerAlias { get; }

        [nterraform.Core.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
        public int? @VolumeSize { get; }
    }

}
