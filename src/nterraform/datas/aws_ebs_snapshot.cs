using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_ebs_snapshot")]
    public sealed class aws_ebs_snapshot : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_ebs_snapshot(filter[] @filter = null,
                                bool? @mostRecent = null,
                                string[] @owners = null,
                                string[] @restorableByUserIds = null,
                                string[] @snapshotIds = null)
        {
            @Filter = @filter;
            @MostRecent = @mostRecent;
            @Owners = @owners;
            @RestorableByUserIds = @restorableByUserIds;
            @SnapshotIds = @snapshotIds;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "data_encryption_key_id", @out: true, min: 0, max: 1)]
        public string @DataEncryptionKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "most_recent", @out: false, min: 0, max: 1)]
        public bool? @MostRecent { get; }

        [nterraform.Core.TerraformProperty(name: "owner_alias", @out: true, min: 0, max: 1)]
        public string @OwnerAlias { get; }

        [nterraform.Core.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.Core.TerraformProperty(name: "owners", @out: false, min: 0, max: 1)]
        public string[] @Owners { get; }

        [nterraform.Core.TerraformProperty(name: "restorable_by_user_ids", @out: false, min: 0, max: 1)]
        public string[] @RestorableByUserIds { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_id", @out: true, min: 0, max: 1)]
        public string @SnapshotId { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_ids", @out: false, min: 0, max: 1)]
        public string[] @SnapshotIds { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "volume_id", @out: true, min: 0, max: 1)]
        public string @VolumeId { get; }

        [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
        public int? @VolumeSize { get; }
    }

}
