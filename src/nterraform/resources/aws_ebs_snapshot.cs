using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ebs_snapshot")]
    public sealed class aws_ebs_snapshot : nterraform.resource
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

        [nterraform.TerraformProperty(name: "volume_id", @out: false, min: 1, max: 1)]
        public string @VolumeId { get; }

        [nterraform.TerraformProperty(name: "data_encryption_key_id", @out: true, min: 0, max: 1)]
        public string @DataEncryptionKeyId { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "owner_alias", @out: true, min: 0, max: 1)]
        public string @OwnerAlias { get; }

        [nterraform.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
        public int? @VolumeSize { get; }
    }

}
