using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_db_instance")]
    public sealed class aws_db_instance : nterraform.resource
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

        public aws_db_instance(string @instanceClass,
                               bool? @allowMajorVersionUpgrade = null,
                               bool? @autoMinorVersionUpgrade = null,
                               bool? @copyTagsToSnapshot = null,
                               string[] @enabledCloudwatchLogsExports = null,
                               string @finalSnapshotIdentifier = null,
                               bool? @iamDatabaseAuthenticationEnabled = null,
                               int? @iops = null,
                               int? @monitoringInterval = null,
                               string @password = null,
                               bool? @publiclyAccessible = null,
                               string @replicateSourceDb = null,
                               s3_import[] @s3Import = null,
                               string[] @securityGroupNames = null,
                               bool? @skipFinalSnapshot = null,
                               string @snapshotIdentifier = null,
                               bool? @storageEncrypted = null,
                               Dictionary<string,string> @tags = null)
        {
            @InstanceClass = @instanceClass;
            @AllowMajorVersionUpgrade = @allowMajorVersionUpgrade;
            @AutoMinorVersionUpgrade = @autoMinorVersionUpgrade;
            @CopyTagsToSnapshot = @copyTagsToSnapshot;
            @EnabledCloudwatchLogsExports = @enabledCloudwatchLogsExports;
            @FinalSnapshotIdentifier = @finalSnapshotIdentifier;
            @IamDatabaseAuthenticationEnabled = @iamDatabaseAuthenticationEnabled;
            @Iops = @iops;
            @MonitoringInterval = @monitoringInterval;
            @Password = @password;
            @PubliclyAccessible = @publiclyAccessible;
            @ReplicateSourceDb = @replicateSourceDb;
            @S3Import = @s3Import;
            @SecurityGroupNames = @securityGroupNames;
            @SkipFinalSnapshot = @skipFinalSnapshot;
            @SnapshotIdentifier = @snapshotIdentifier;
            @StorageEncrypted = @storageEncrypted;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "instance_class", @out: false, min: 1, max: 1)]
        public string @InstanceClass { get; }

        [nterraform.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public string @Address { get; }

        [nterraform.TerraformProperty(name: "allocated_storage", @out: true, min: 0, max: 1)]
        public int? @AllocatedStorage { get; }

        [nterraform.TerraformProperty(name: "allow_major_version_upgrade", @out: false, min: 0, max: 1)]
        public bool? @AllowMajorVersionUpgrade { get; }

        [nterraform.TerraformProperty(name: "apply_immediately", @out: true, min: 0, max: 1)]
        public bool? @ApplyImmediately { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "auto_minor_version_upgrade", @out: false, min: 0, max: 1)]
        public bool? @AutoMinorVersionUpgrade { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "backup_retention_period", @out: true, min: 0, max: 1)]
        public int? @BackupRetentionPeriod { get; }

        [nterraform.TerraformProperty(name: "backup_window", @out: true, min: 0, max: 1)]
        public string @BackupWindow { get; }

        [nterraform.TerraformProperty(name: "ca_cert_identifier", @out: true, min: 0, max: 1)]
        public string @CaCertIdentifier { get; }

        [nterraform.TerraformProperty(name: "character_set_name", @out: true, min: 0, max: 1)]
        public string @CharacterSetName { get; }

        [nterraform.TerraformProperty(name: "copy_tags_to_snapshot", @out: false, min: 0, max: 1)]
        public bool? @CopyTagsToSnapshot { get; }

        [nterraform.TerraformProperty(name: "db_subnet_group_name", @out: true, min: 0, max: 1)]
        public string @DbSubnetGroupName { get; }

        [nterraform.TerraformProperty(name: "enabled_cloudwatch_logs_exports", @out: false, min: 0, max: 1)]
        public string[] @EnabledCloudwatchLogsExports { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "final_snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @FinalSnapshotIdentifier { get; }

        [nterraform.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.TerraformProperty(name: "iam_database_authentication_enabled", @out: false, min: 0, max: 1)]
        public bool? @IamDatabaseAuthenticationEnabled { get; }

        [nterraform.TerraformProperty(name: "identifier", @out: true, min: 0, max: 1)]
        public string @Identifier { get; }

        [nterraform.TerraformProperty(name: "identifier_prefix", @out: true, min: 0, max: 1)]
        public string @IdentifierPrefix { get; }

        [nterraform.TerraformProperty(name: "iops", @out: false, min: 0, max: 1)]
        public int? @Iops { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "license_model", @out: true, min: 0, max: 1)]
        public string @LicenseModel { get; }

        [nterraform.TerraformProperty(name: "maintenance_window", @out: true, min: 0, max: 1)]
        public string @MaintenanceWindow { get; }

        [nterraform.TerraformProperty(name: "monitoring_interval", @out: false, min: 0, max: 1)]
        public int? @MonitoringInterval { get; }

        [nterraform.TerraformProperty(name: "monitoring_role_arn", @out: true, min: 0, max: 1)]
        public string @MonitoringRoleArn { get; }

        [nterraform.TerraformProperty(name: "multi_az", @out: true, min: 0, max: 1)]
        public bool? @MultiAz { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "option_group_name", @out: true, min: 0, max: 1)]
        public string @OptionGroupName { get; }

        [nterraform.TerraformProperty(name: "parameter_group_name", @out: true, min: 0, max: 1)]
        public string @ParameterGroupName { get; }

        [nterraform.TerraformProperty(name: "password", @out: false, min: 0, max: 1)]
        public string @Password { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "publicly_accessible", @out: false, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.TerraformProperty(name: "replicas", @out: true, min: 0, max: 1)]
        public string[] @Replicas { get; }

        [nterraform.TerraformProperty(name: "replicate_source_db", @out: false, min: 0, max: 1)]
        public string @ReplicateSourceDb { get; }

        [nterraform.TerraformProperty(name: "resource_id", @out: true, min: 0, max: 1)]
        public string @ResourceId { get; }

        [nterraform.TerraformProperty(name: "s3_import", @out: false, min: 0, max: 1)]
        public s3_import[] @S3Import { get; }

        [nterraform.TerraformProperty(name: "security_group_names", @out: false, min: 0, max: 1)]
        public string[] @SecurityGroupNames { get; }

        [nterraform.TerraformProperty(name: "skip_final_snapshot", @out: false, min: 0, max: 1)]
        public bool? @SkipFinalSnapshot { get; }

        [nterraform.TerraformProperty(name: "snapshot_identifier", @out: false, min: 0, max: 1)]
        public string @SnapshotIdentifier { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "storage_encrypted", @out: false, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.TerraformProperty(name: "storage_type", @out: true, min: 0, max: 1)]
        public string @StorageType { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "timezone", @out: true, min: 0, max: 1)]
        public string @Timezone { get; }

        [nterraform.TerraformProperty(name: "username", @out: true, min: 0, max: 1)]
        public string @Username { get; }

        [nterraform.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
