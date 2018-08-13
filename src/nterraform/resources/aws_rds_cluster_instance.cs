using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_rds_cluster_instance")]
    public sealed class aws_rds_cluster_instance : nterraform.resource
    {
        public aws_rds_cluster_instance(string @clusterIdentifier,
                                        string @instanceClass,
                                        bool? @autoMinorVersionUpgrade = null,
                                        string @engine = null,
                                        int? @monitoringInterval = null,
                                        int? @promotionTier = null,
                                        bool? @publiclyAccessible = null,
                                        Dictionary<string,string> @tags = null)
        {
            @ClusterIdentifier = @clusterIdentifier;
            @InstanceClass = @instanceClass;
            @AutoMinorVersionUpgrade = @autoMinorVersionUpgrade;
            @Engine = @engine;
            @MonitoringInterval = @monitoringInterval;
            @PromotionTier = @promotionTier;
            @PubliclyAccessible = @publiclyAccessible;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "cluster_identifier", @out: false, min: 1, max: 1)]
        public string @ClusterIdentifier { get; }

        [nterraform.TerraformProperty(name: "instance_class", @out: false, min: 1, max: 1)]
        public string @InstanceClass { get; }

        [nterraform.TerraformProperty(name: "apply_immediately", @out: true, min: 0, max: 1)]
        public bool? @ApplyImmediately { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "auto_minor_version_upgrade", @out: false, min: 0, max: 1)]
        public bool? @AutoMinorVersionUpgrade { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "db_parameter_group_name", @out: true, min: 0, max: 1)]
        public string @DbParameterGroupName { get; }

        [nterraform.TerraformProperty(name: "db_subnet_group_name", @out: true, min: 0, max: 1)]
        public string @DbSubnetGroupName { get; }

        [nterraform.TerraformProperty(name: "dbi_resource_id", @out: true, min: 0, max: 1)]
        public string @DbiResourceId { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "engine", @out: false, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "identifier", @out: true, min: 0, max: 1)]
        public string @Identifier { get; }

        [nterraform.TerraformProperty(name: "identifier_prefix", @out: true, min: 0, max: 1)]
        public string @IdentifierPrefix { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "monitoring_interval", @out: false, min: 0, max: 1)]
        public int? @MonitoringInterval { get; }

        [nterraform.TerraformProperty(name: "monitoring_role_arn", @out: true, min: 0, max: 1)]
        public string @MonitoringRoleArn { get; }

        [nterraform.TerraformProperty(name: "performance_insights_enabled", @out: true, min: 0, max: 1)]
        public bool? @PerformanceInsightsEnabled { get; }

        [nterraform.TerraformProperty(name: "performance_insights_kms_key_id", @out: true, min: 0, max: 1)]
        public string @PerformanceInsightsKmsKeyId { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "preferred_backup_window", @out: true, min: 0, max: 1)]
        public string @PreferredBackupWindow { get; }

        [nterraform.TerraformProperty(name: "preferred_maintenance_window", @out: true, min: 0, max: 1)]
        public string @PreferredMaintenanceWindow { get; }

        [nterraform.TerraformProperty(name: "promotion_tier", @out: false, min: 0, max: 1)]
        public int? @PromotionTier { get; }

        [nterraform.TerraformProperty(name: "publicly_accessible", @out: false, min: 0, max: 1)]
        public bool? @PubliclyAccessible { get; }

        [nterraform.TerraformProperty(name: "storage_encrypted", @out: true, min: 0, max: 1)]
        public bool? @StorageEncrypted { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "writer", @out: true, min: 0, max: 1)]
        public bool? @Writer { get; }
    }

}
