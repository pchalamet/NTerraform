using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_db_cluster_snapshot")]
    public sealed class aws_db_cluster_snapshot : nterraform.Core.resource
    {
        public aws_db_cluster_snapshot(string @dbClusterIdentifier,
                                       string @dbClusterSnapshotIdentifier)
        {
            @DbClusterIdentifier = @dbClusterIdentifier;
            @DbClusterSnapshotIdentifier = @dbClusterSnapshotIdentifier;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "db_cluster_identifier", @out: false, min: 1, max: 1)]
        public string @DbClusterIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "db_cluster_snapshot_identifier", @out: false, min: 1, max: 1)]
        public string @DbClusterSnapshotIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "allocated_storage", @out: true, min: 0, max: 1)]
        public int? @AllocatedStorage { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.Core.TerraformProperty(name: "db_cluster_snapshot_arn", @out: true, min: 0, max: 1)]
        public string @DbClusterSnapshotArn { get; }

        [nterraform.Core.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.Core.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "license_model", @out: true, min: 0, max: 1)]
        public string @LicenseModel { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_type", @out: true, min: 0, max: 1)]
        public string @SnapshotType { get; }

        [nterraform.Core.TerraformProperty(name: "source_db_cluster_snapshot_arn", @out: true, min: 0, max: 1)]
        public string @SourceDbClusterSnapshotArn { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "storage_encrypted", @out: true, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
