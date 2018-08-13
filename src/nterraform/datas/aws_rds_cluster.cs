using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_rds_cluster")]
    public sealed class aws_rds_cluster : nterraform.Core.data
    {
        public aws_rds_cluster(string @clusterIdentifier)
        {
            @ClusterIdentifier = @clusterIdentifier;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cluster_identifier", @out: false, min: 1, max: 1)]
        public string @ClusterIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zones", @out: true, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.Core.TerraformProperty(name: "backup_retention_period", @out: true, min: 0, max: 1)]
        public int? @BackupRetentionPeriod { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_members", @out: true, min: 0, max: 1)]
        public string[] @ClusterMembers { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_resource_id", @out: true, min: 0, max: 1)]
        public string @ClusterResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "database_name", @out: true, min: 0, max: 1)]
        public string @DatabaseName { get; }

        [nterraform.Core.TerraformProperty(name: "db_cluster_parameter_group_name", @out: true, min: 0, max: 1)]
        public string @DbClusterParameterGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "db_subnet_group_name", @out: true, min: 0, max: 1)]
        public string @DbSubnetGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_cloudwatch_logs_exports", @out: true, min: 0, max: 1)]
        public string[] @EnabledCloudwatchLogsExports { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.Core.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "final_snapshot_identifier", @out: true, min: 0, max: 1)]
        public string @FinalSnapshotIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "iam_database_authentication_enabled", @out: true, min: 0, max: 1)]
        public bool? @IamDatabaseAuthenticationEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "iam_roles", @out: true, min: 0, max: 1)]
        public string[] @IamRoles { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "master_username", @out: true, min: 0, max: 1)]
        public string @MasterUsername { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "preferred_backup_window", @out: true, min: 0, max: 1)]
        public string @PreferredBackupWindow { get; }

        [nterraform.Core.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.Core.TerraformProperty(name: "reader_endpoint", @out: true, min: 0, max: 1)]
        public string @ReaderEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "replication_source_identifier", @out: true, min: 0, max: 1)]
        public string @ReplicationSourceIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "storage_encrypted", @out: true, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
