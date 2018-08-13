using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_db_snapshot")]
    public sealed class aws_db_snapshot : nterraform.Core.data
    {
        public aws_db_snapshot(string @dbInstanceIdentifier = null,
                               string @dbSnapshotIdentifier = null,
                               bool? @includePublic = null,
                               bool? @includeShared = null,
                               bool? @mostRecent = null,
                               string @snapshotType = null)
        {
            @DbInstanceIdentifier = @dbInstanceIdentifier;
            @DbSnapshotIdentifier = @dbSnapshotIdentifier;
            @IncludePublic = @includePublic;
            @IncludeShared = @includeShared;
            @MostRecent = @mostRecent;
            @SnapshotType = @snapshotType;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "allocated_storage", @out: true, min: 0, max: 1)]
        public int? @AllocatedStorage { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "db_instance_identifier", @out: false, min: 0, max: 1)]
        public string @DbInstanceIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "db_snapshot_arn", @out: true, min: 0, max: 1)]
        public string @DbSnapshotArn { get; }

        [nterraform.Core.TerraformProperty(name: "db_snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @DbSnapshotIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.Core.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.Core.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "include_public", @out: false, min: 0, max: 1)]
        public bool? @IncludePublic { get; }

        [nterraform.Core.TerraformProperty(name: "include_shared", @out: false, min: 0, max: 1)]
        public bool? @IncludeShared { get; }

        [nterraform.Core.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
        public int? @Iops { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "license_model", @out: true, min: 0, max: 1)]
        public string @LicenseModel { get; }

        [nterraform.Core.TerraformProperty(name: "most_recent", @out: false, min: 0, max: 1)]
        public bool? @MostRecent { get; }

        [nterraform.Core.TerraformProperty(name: "option_group_name", @out: true, min: 0, max: 1)]
        public string @OptionGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_create_time", @out: true, min: 0, max: 1)]
        public string @SnapshotCreateTime { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_type", @out: false, min: 0, max: 1)]
        public string @SnapshotType { get; }

        [nterraform.Core.TerraformProperty(name: "source_db_snapshot_identifier", @out: true, min: 0, max: 1)]
        public string @SourceDbSnapshotIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "source_region", @out: true, min: 0, max: 1)]
        public string @SourceRegion { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "storage_type", @out: true, min: 0, max: 1)]
        public string @StorageType { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
