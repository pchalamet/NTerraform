using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_db_instance")]
    public sealed class aws_db_instance : nterraform.Core.data
    {
        public aws_db_instance(string @dbInstanceIdentifier)
        {
            @DbInstanceIdentifier = @dbInstanceIdentifier;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "db_instance_identifier", @out: false, min: 1, max: 1)]
        public string @DbInstanceIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public string @Address { get; }

        [nterraform.Core.TerraformProperty(name: "allocated_storage", @out: true, min: 0, max: 1)]
        public int? @AllocatedStorage { get; }

        [nterraform.Core.TerraformProperty(name: "auto_minor_version_upgrade", @out: true, min: 0, max: 1)]
        public bool? @AutoMinorVersionUpgrade { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "backup_retention_period", @out: true, min: 0, max: 1)]
        public int? @BackupRetentionPeriod { get; }

        [nterraform.Core.TerraformProperty(name: "ca_cert_identifier", @out: true, min: 0, max: 1)]
        public string @CaCertIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "db_cluster_identifier", @out: true, min: 0, max: 1)]
        public string @DbClusterIdentifier { get; }

        [nterraform.Core.TerraformProperty(name: "db_instance_arn", @out: true, min: 0, max: 1)]
        public string @DbInstanceArn { get; }

        [nterraform.Core.TerraformProperty(name: "db_instance_class", @out: true, min: 0, max: 1)]
        public string @DbInstanceClass { get; }

        [nterraform.Core.TerraformProperty(name: "db_instance_port", @out: true, min: 0, max: 1)]
        public int? @DbInstancePort { get; }

        [nterraform.Core.TerraformProperty(name: "db_name", @out: true, min: 0, max: 1)]
        public string @DbName { get; }

        [nterraform.Core.TerraformProperty(name: "db_parameter_groups", @out: true, min: 0, max: 1)]
        public string[] @DbParameterGroups { get; }

        [nterraform.Core.TerraformProperty(name: "db_security_groups", @out: true, min: 0, max: 1)]
        public string[] @DbSecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "db_subnet_group", @out: true, min: 0, max: 1)]
        public string @DbSubnetGroup { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.Core.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.Core.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
        public int? @Iops { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.Core.TerraformProperty(name: "license_model", @out: true, min: 0, max: 1)]
        public string @LicenseModel { get; }

        [nterraform.Core.TerraformProperty(name: "master_username", @out: true, min: 0, max: 1)]
        public string @MasterUsername { get; }

        [nterraform.Core.TerraformProperty(name: "monitoring_interval", @out: true, min: 0, max: 1)]
        public int? @MonitoringInterval { get; }

        [nterraform.Core.TerraformProperty(name: "monitoring_role_arn", @out: true, min: 0, max: 1)]
        public string @MonitoringRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "multi_az", @out: true, min: 0, max: 1)]
        public bool? @MultiAz { get; }

        [nterraform.Core.TerraformProperty(name: "option_group_memberships", @out: true, min: 0, max: 1)]
        public string[] @OptionGroupMemberships { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "preferred_backup_window", @out: true, min: 0, max: 1)]
        public string @PreferredBackupWindow { get; }

        [nterraform.Core.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.Core.TerraformProperty(name: "publicly_accessible", @out: true, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.Core.TerraformProperty(name: "replicate_source_db", @out: true, min: 0, max: 1)]
        public string @ReplicateSourceDb { get; }

        [nterraform.Core.TerraformProperty(name: "storage_encrypted", @out: true, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.Core.TerraformProperty(name: "storage_type", @out: true, min: 0, max: 1)]
        public string @StorageType { get; }

        [nterraform.Core.TerraformProperty(name: "timezone", @out: true, min: 0, max: 1)]
        public string @Timezone { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_security_groups", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroups { get; }
    }

}
