using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_neptune_cluster")]
    public sealed class aws_neptune_cluster : nterraform.resource
    {
        public aws_neptune_cluster(int? @backupRetentionPeriod = null,
                                   string @engine = null,
                                   string @finalSnapshotIdentifier = null,
                                   bool? @iamDatabaseAuthenticationEnabled = null,
                                   string[] @iamRoles = null,
                                   string @neptuneClusterParameterGroupName = null,
                                   int? @port = null,
                                   string @replicationSourceIdentifier = null,
                                   bool? @skipFinalSnapshot = null,
                                   string @snapshotIdentifier = null,
                                   bool? @storageEncrypted = null,
                                   Dictionary<string,string> @tags = null)
        {
            @BackupRetentionPeriod = @backupRetentionPeriod;
            @Engine = @engine;
            @FinalSnapshotIdentifier = @finalSnapshotIdentifier;
            @IamDatabaseAuthenticationEnabled = @iamDatabaseAuthenticationEnabled;
            @IamRoles = @iamRoles;
            @NeptuneClusterParameterGroupName = @neptuneClusterParameterGroupName;
            @Port = @port;
            @ReplicationSourceIdentifier = @replicationSourceIdentifier;
            @SkipFinalSnapshot = @skipFinalSnapshot;
            @SnapshotIdentifier = @snapshotIdentifier;
            @StorageEncrypted = @storageEncrypted;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "apply_immediately", @out: true, min: 0, max: 1)]
        public bool? @ApplyImmediately { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.TerraformProperty(name: "backup_retention_period", @out: false, min: 0, max: 1)]
        public int? @BackupRetentionPeriod { get; }

        [nterraform.TerraformProperty(name: "cluster_identifier", @out: true, min: 0, max: 1)]
        public string @ClusterIdentifier { get; }

        [nterraform.TerraformProperty(name: "cluster_identifier_prefix", @out: true, min: 0, max: 1)]
        public string @ClusterIdentifierPrefix { get; }

        [nterraform.TerraformProperty(name: "cluster_members", @out: true, min: 0, max: 1)]
        public string[] @ClusterMembers { get; }

        [nterraform.TerraformProperty(name: "cluster_resource_id", @out: true, min: 0, max: 1)]
        public string @ClusterResourceId { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "engine", @out: false, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "final_snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @FinalSnapshotIdentifier { get; }

        [nterraform.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.TerraformProperty(name: "iam_database_authentication_enabled", @out: false, min: 0, max: 1)]
        public bool? @IamDatabaseAuthenticationEnabled { get; }

        [nterraform.TerraformProperty(name: "iam_roles", @out: false, min: 0, max: 1)]
        public string[] @IamRoles { get; }

        [nterraform.TerraformProperty(name: "kms_key_arn", @out: true, min: 0, max: 1)]
        public string @KmsKeyArn { get; }

        [nterraform.TerraformProperty(name: "neptune_cluster_parameter_group_name", @out: false, min: 0, max: 1)]
        public string @NeptuneClusterParameterGroupName { get; }

        [nterraform.TerraformProperty(name: "neptune_subnet_group_name", @out: true, min: 0, max: 1)]
        public string @NeptuneSubnetGroupName { get; }

        [nterraform.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "preferred_backup_window", @out: true, min: 0, max: 1)]
        public string @PreferredBackupWindow { get; }

        [nterraform.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.TerraformProperty(name: "reader_endpoint", @out: true, min: 0, max: 1)]
        public string @ReaderEndpoint { get; }

        [nterraform.TerraformProperty(name: "replication_source_identifier", @out: false, min: 0, max: 1)]
        public string @ReplicationSourceIdentifier { get; }

        [nterraform.TerraformProperty(name: "skip_final_snapshot", @out: false, min: 0, max: 1)]
        public bool? @SkipFinalSnapshot { get; }

        [nterraform.TerraformProperty(name: "snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @SnapshotIdentifier { get; }

        [nterraform.TerraformProperty(name: "storage_encrypted", @out: false, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
