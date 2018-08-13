using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_db_instance")]
    public sealed class aws_db_instance : nterraform.data
    {
        public aws_db_instance(string @dbInstanceIdentifier)
        {
            @DbInstanceIdentifier = @dbInstanceIdentifier;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "db_instance_identifier", @out: false, min: 1, max: 1)]
        public string @DbInstanceIdentifier { get; }

        [nterraform.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
        public string @Address { get; }

        [nterraform.TerraformProperty(name: "allocated_storage", @out: true, min: 0, max: 1)]
        public int? @AllocatedStorage { get; }

        [nterraform.TerraformProperty(name: "auto_minor_version_upgrade", @out: true, min: 0, max: 1)]
        public bool? @AutoMinorVersionUpgrade { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "backup_retention_period", @out: true, min: 0, max: 1)]
        public int? @BackupRetentionPeriod { get; }

        [nterraform.TerraformProperty(name: "ca_cert_identifier", @out: true, min: 0, max: 1)]
        public string @CaCertIdentifier { get; }

        [nterraform.TerraformProperty(name: "db_cluster_identifier", @out: true, min: 0, max: 1)]
        public string @DbClusterIdentifier { get; }

        [nterraform.TerraformProperty(name: "db_instance_arn", @out: true, min: 0, max: 1)]
        public string @DbInstanceArn { get; }

        [nterraform.TerraformProperty(name: "db_instance_class", @out: true, min: 0, max: 1)]
        public string @DbInstanceClass { get; }

        [nterraform.TerraformProperty(name: "db_instance_port", @out: true, min: 0, max: 1)]
        public int? @DbInstancePort { get; }

        [nterraform.TerraformProperty(name: "db_name", @out: true, min: 0, max: 1)]
        public string @DbName { get; }

        [nterraform.TerraformProperty(name: "db_parameter_groups", @out: true, min: 0, max: 1)]
        public string[] @DbParameterGroups { get; }

        [nterraform.TerraformProperty(name: "db_security_groups", @out: true, min: 0, max: 1)]
        public string[] @DbSecurityGroups { get; }

        [nterraform.TerraformProperty(name: "db_subnet_group", @out: true, min: 0, max: 1)]
        public string @DbSubnetGroup { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
        public string @HostedZoneId { get; }

        [nterraform.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
        public int? @Iops { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "license_model", @out: true, min: 0, max: 1)]
        public string @LicenseModel { get; }

        [nterraform.TerraformProperty(name: "master_username", @out: true, min: 0, max: 1)]
        public string @MasterUsername { get; }

        [nterraform.TerraformProperty(name: "monitoring_interval", @out: true, min: 0, max: 1)]
        public int? @MonitoringInterval { get; }

        [nterraform.TerraformProperty(name: "monitoring_role_arn", @out: true, min: 0, max: 1)]
        public string @MonitoringRoleArn { get; }

        [nterraform.TerraformProperty(name: "multi_az", @out: true, min: 0, max: 1)]
        public bool? @MultiAz { get; }

        [nterraform.TerraformProperty(name: "option_group_memberships", @out: true, min: 0, max: 1)]
        public string[] @OptionGroupMemberships { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "preferred_backup_window", @out: true, min: 0, max: 1)]
        public string @PreferredBackupWindow { get; }

        [nterraform.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.TerraformProperty(name: "publicly_accessible", @out: true, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.TerraformProperty(name: "replicate_source_db", @out: true, min: 0, max: 1)]
        public string @ReplicateSourceDb { get; }

        [nterraform.TerraformProperty(name: "storage_encrypted", @out: true, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.TerraformProperty(name: "storage_type", @out: true, min: 0, max: 1)]
        public string @StorageType { get; }

        [nterraform.TerraformProperty(name: "timezone", @out: true, min: 0, max: 1)]
        public string @Timezone { get; }

        [nterraform.TerraformProperty(name: "vpc_security_groups", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroups { get; }
    }

}
