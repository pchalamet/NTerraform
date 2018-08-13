using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_rds_cluster")]
    public sealed class aws_rds_cluster : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "s3_import")]
        public sealed class s3_import : nterraform.structure
        {
            public s3_import(string @bucketName,
                             string @ingestionRole,
                             string @sourceEngine,
                             string @sourceEngineVersion,
                             string @bucketPrefix = null)
            {
                @BucketName = @bucketName;
                @IngestionRole = @ingestionRole;
                @SourceEngine = @sourceEngine;
                @SourceEngineVersion = @sourceEngineVersion;
                @BucketPrefix = @bucketPrefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "bucket_name", @out: false, min: 1, max: 1)]
            public string @BucketName { get; }

            [nterraform.TerraformProperty(name: "ingestion_role", @out: false, min: 1, max: 1)]
            public string @IngestionRole { get; }

            [nterraform.TerraformProperty(name: "source_engine", @out: false, min: 1, max: 1)]
            public string @SourceEngine { get; }

            [nterraform.TerraformProperty(name: "source_engine_version", @out: false, min: 1, max: 1)]
            public string @SourceEngineVersion { get; }

            [nterraform.TerraformProperty(name: "bucket_prefix", @out: false, min: 0, max: 1)]
            public string @BucketPrefix { get; }
        }

        public aws_rds_cluster(int? @backtrackWindow = null,
                               int? @backupRetentionPeriod = null,
                               string[] @enabledCloudwatchLogsExports = null,
                               string @engine = null,
                               string @finalSnapshotIdentifier = null,
                               bool? @iamDatabaseAuthenticationEnabled = null,
                               string[] @iamRoles = null,
                               string @masterPassword = null,
                               string @replicationSourceIdentifier = null,
                               s3_import[] @s3Import = null,
                               bool? @skipFinalSnapshot = null,
                               string @snapshotIdentifier = null,
                               string @sourceRegion = null,
                               bool? @storageEncrypted = null,
                               Dictionary<string,string> @tags = null)
        {
            @BacktrackWindow = @backtrackWindow;
            @BackupRetentionPeriod = @backupRetentionPeriod;
            @EnabledCloudwatchLogsExports = @enabledCloudwatchLogsExports;
            @Engine = @engine;
            @FinalSnapshotIdentifier = @finalSnapshotIdentifier;
            @IamDatabaseAuthenticationEnabled = @iamDatabaseAuthenticationEnabled;
            @IamRoles = @iamRoles;
            @MasterPassword = @masterPassword;
            @ReplicationSourceIdentifier = @replicationSourceIdentifier;
            @S3Import = @s3Import;
            @SkipFinalSnapshot = @skipFinalSnapshot;
            @SnapshotIdentifier = @snapshotIdentifier;
            @SourceRegion = @sourceRegion;
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

        [nterraform.TerraformProperty(name: "backtrack_window", @out: false, min: 0, max: 1)]
        public int? @BacktrackWindow { get; }

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

        [nterraform.TerraformProperty(name: "database_name", @out: true, min: 0, max: 1)]
        public string @DatabaseName { get; }

        [nterraform.TerraformProperty(name: "db_cluster_parameter_group_name", @out: true, min: 0, max: 1)]
        public string @DbClusterParameterGroupName { get; }

        [nterraform.TerraformProperty(name: "db_subnet_group_name", @out: true, min: 0, max: 1)]
        public string @DbSubnetGroupName { get; }

        [nterraform.TerraformProperty(name: "enabled_cloudwatch_logs_exports", @out: false, min: 0, max: 1)]
        public string[] @EnabledCloudwatchLogsExports { get; }

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

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "master_password", @out: false, min: 0, max: 1)]
        public string @MasterPassword { get; }

        [nterraform.TerraformProperty(name: "master_username", @out: true, min: 0, max: 1)]
        public string @MasterUsername { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "preferred_backup_window", @out: true, min: 0, max: 1)]
        public string @PreferredBackupWindow { get; }

        [nterraform.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.TerraformProperty(name: "reader_endpoint", @out: true, min: 0, max: 1)]
        public string @ReaderEndpoint { get; }

        [nterraform.TerraformProperty(name: "replication_source_identifier", @out: false, min: 0, max: 1)]
        public string @ReplicationSourceIdentifier { get; }

        [nterraform.TerraformProperty(name: "s3_import", @out: false, min: 0, max: 1)]
        public s3_import[] @S3Import { get; }

        [nterraform.TerraformProperty(name: "skip_final_snapshot", @out: false, min: 0, max: 1)]
        public bool? @SkipFinalSnapshot { get; }

        [nterraform.TerraformProperty(name: "snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @SnapshotIdentifier { get; }

        [nterraform.TerraformProperty(name: "source_region", @out: false, min: 0, max: 1)]
        public string @SourceRegion { get; }

        [nterraform.TerraformProperty(name: "storage_encrypted", @out: false, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
