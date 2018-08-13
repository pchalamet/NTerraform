using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elasticache_replication_group")]
    public sealed class aws_elasticache_replication_group : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cluster_mode")]
        public sealed class cluster_mode : nterraform.Core.structure
        {
            public cluster_mode(int @numNodeGroups,
                                int @replicasPerNodeGroup)
            {
                @NumNodeGroups = @numNodeGroups;
                @ReplicasPerNodeGroup = @replicasPerNodeGroup;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "num_node_groups", @out: false, min: 1, max: 1)]
            public int @NumNodeGroups { get; }

            [nterraform.Core.TerraformProperty(name: "replicas_per_node_group", @out: false, min: 1, max: 1)]
            public int @ReplicasPerNodeGroup { get; }
        }

        public aws_elasticache_replication_group(string @replicationGroupDescription,
                                                 string @replicationGroupId,
                                                 bool? @atRestEncryptionEnabled = null,
                                                 string @authToken = null,
                                                 bool? @autoMinorVersionUpgrade = null,
                                                 bool? @automaticFailoverEnabled = null,
                                                 string[] @availabilityZones = null,
                                                 cluster_mode[] @clusterMode = null,
                                                 string @engine = null,
                                                 string @notificationTopicArn = null,
                                                 int? @port = null,
                                                 string[] @snapshotArns = null,
                                                 string @snapshotName = null,
                                                 int? @snapshotRetentionLimit = null,
                                                 Dictionary<string,string> @tags = null,
                                                 bool? @transitEncryptionEnabled = null)
        {
            @ReplicationGroupDescription = @replicationGroupDescription;
            @ReplicationGroupId = @replicationGroupId;
            @AtRestEncryptionEnabled = @atRestEncryptionEnabled;
            @AuthToken = @authToken;
            @AutoMinorVersionUpgrade = @autoMinorVersionUpgrade;
            @AutomaticFailoverEnabled = @automaticFailoverEnabled;
            @AvailabilityZones = @availabilityZones;
            @ClusterMode = @clusterMode;
            @Engine = @engine;
            @NotificationTopicArn = @notificationTopicArn;
            @Port = @port;
            @SnapshotArns = @snapshotArns;
            @SnapshotName = @snapshotName;
            @SnapshotRetentionLimit = @snapshotRetentionLimit;
            @Tags = @tags;
            @TransitEncryptionEnabled = @transitEncryptionEnabled;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "replication_group_description", @out: false, min: 1, max: 1)]
        public string @ReplicationGroupDescription { get; }

        [nterraform.Core.TerraformProperty(name: "replication_group_id", @out: false, min: 1, max: 1)]
        public string @ReplicationGroupId { get; }

        [nterraform.Core.TerraformProperty(name: "apply_immediately", @out: true, min: 0, max: 1)]
        public bool? @ApplyImmediately { get; }

        [nterraform.Core.TerraformProperty(name: "at_rest_encryption_enabled", @out: false, min: 0, max: 1)]
        public bool? @AtRestEncryptionEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "auth_token", @out: false, min: 0, max: 1)]
        public string @AuthToken { get; }

        [nterraform.Core.TerraformProperty(name: "auto_minor_version_upgrade", @out: false, min: 0, max: 1)]
        public bool? @AutoMinorVersionUpgrade { get; }

        [nterraform.Core.TerraformProperty(name: "automatic_failover_enabled", @out: false, min: 0, max: 1)]
        public bool? @AutomaticFailoverEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zones", @out: false, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_mode", @out: false, min: 0, max: 1)]
        public cluster_mode[] @ClusterMode { get; }

        [nterraform.Core.TerraformProperty(name: "configuration_endpoint_address", @out: true, min: 0, max: 1)]
        public string @ConfigurationEndpointAddress { get; }

        [nterraform.Core.TerraformProperty(name: "engine", @out: false, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.Core.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "maintenance_window", @out: true, min: 0, max: 1)]
        public string @MaintenanceWindow { get; }

        [nterraform.Core.TerraformProperty(name: "member_clusters", @out: true, min: 0, max: 1)]
        public string[] @MemberClusters { get; }

        [nterraform.Core.TerraformProperty(name: "node_type", @out: true, min: 0, max: 1)]
        public string @NodeType { get; }

        [nterraform.Core.TerraformProperty(name: "notification_topic_arn", @out: false, min: 0, max: 1)]
        public string @NotificationTopicArn { get; }

        [nterraform.Core.TerraformProperty(name: "number_cache_clusters", @out: true, min: 0, max: 1)]
        public int? @NumberCacheClusters { get; }

        [nterraform.Core.TerraformProperty(name: "parameter_group_name", @out: true, min: 0, max: 1)]
        public string @ParameterGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "primary_endpoint_address", @out: true, min: 0, max: 1)]
        public string @PrimaryEndpointAddress { get; }

        [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupIds { get; }

        [nterraform.Core.TerraformProperty(name: "security_group_names", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupNames { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_arns", @out: false, min: 0, max: 1)]
        public string[] @SnapshotArns { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_name", @out: false, min: 0, max: 1)]
        public string @SnapshotName { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_retention_limit", @out: false, min: 0, max: 1)]
        public int? @SnapshotRetentionLimit { get; }

        [nterraform.Core.TerraformProperty(name: "snapshot_window", @out: true, min: 0, max: 1)]
        public string @SnapshotWindow { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_group_name", @out: true, min: 0, max: 1)]
        public string @SubnetGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "transit_encryption_enabled", @out: false, min: 0, max: 1)]
        public bool? @TransitEncryptionEnabled { get; }
    }

}
