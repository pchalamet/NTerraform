using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_db_cluster_snapshot")]
    public sealed class aws_db_cluster_snapshot : nterraform.data
    {
        public aws_db_cluster_snapshot(string @dbClusterIdentifier = null,
                                       string @dbClusterSnapshotIdentifier = null,
                                       bool? @includePublic = null,
                                       bool? @includeShared = null,
                                       bool? @mostRecent = null,
                                       string @snapshotType = null)
        {
            @DbClusterIdentifier = @dbClusterIdentifier;
            @DbClusterSnapshotIdentifier = @dbClusterSnapshotIdentifier;
            @IncludePublic = @includePublic;
            @IncludeShared = @includeShared;
            @MostRecent = @mostRecent;
            @SnapshotType = @snapshotType;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "allocated_storage", @out: true, min: 0, max: 1)]
        public int? @AllocatedStorage { get; }

        [nterraform.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.TerraformProperty(name: "db_cluster_identifier", @out: false, min: 0, max: 1)]
        public string @DbClusterIdentifier { get; }

        [nterraform.TerraformProperty(name: "db_cluster_snapshot_arn", @out: true, min: 0, max: 1)]
        public string @DbClusterSnapshotArn { get; }

        [nterraform.TerraformProperty(name: "db_cluster_snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @DbClusterSnapshotIdentifier { get; }

        [nterraform.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "include_public", @out: false, min: 0, max: 1)]
        public bool? @IncludePublic { get; }

        [nterraform.TerraformProperty(name: "include_shared", @out: false, min: 0, max: 1)]
        public bool? @IncludeShared { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "license_model", @out: true, min: 0, max: 1)]
        public string @LicenseModel { get; }

        [nterraform.TerraformProperty(name: "most_recent", @out: false, min: 0, max: 1)]
        public bool? @MostRecent { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "snapshot_create_time", @out: true, min: 0, max: 1)]
        public string @SnapshotCreateTime { get; }

        [nterraform.TerraformProperty(name: "snapshot_type", @out: false, min: 0, max: 1)]
        public string @SnapshotType { get; }

        [nterraform.TerraformProperty(name: "source_db_cluster_snapshot_arn", @out: true, min: 0, max: 1)]
        public string @SourceDbClusterSnapshotArn { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "storage_encrypted", @out: true, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
