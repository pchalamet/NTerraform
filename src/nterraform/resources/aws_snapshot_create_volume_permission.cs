using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_snapshot_create_volume_permission")]
    public sealed class aws_snapshot_create_volume_permission : nterraform.resource
    {
        public aws_snapshot_create_volume_permission(string @accountId,
                                                     string @snapshotId)
        {
            @AccountId = @accountId;
            @SnapshotId = @snapshotId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_id", @out: false, min: 1, max: 1)]
        public string @AccountId { get; }

        [nterraform.TerraformProperty(name: "snapshot_id", @out: false, min: 1, max: 1)]
        public string @SnapshotId { get; }
    }

}
