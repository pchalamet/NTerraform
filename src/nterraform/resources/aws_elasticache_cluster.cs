using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_elasticache_cluster")]
    public sealed class aws_elasticache_cluster : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "cache_nodes")]
        public sealed class cache_nodes : nterraform.Core.structure
        {
            public cache_nodes()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
            public string @Address { get; }

            [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
            public string @AvailabilityZone { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
            public int? @Port { get; }
        }

        public aws_elasticache_cluster(string @clusterId,
                                       string[] @availabilityZones = null,
                                       cache_nodes[] @cacheNodes = null,
                                       string @notificationTopicArn = null,
                                       int? @port = null,
                                       string[] @preferredAvailabilityZones = null,
                                       string[] @snapshotArns = null,
                                       string @snapshotName = null,
                                       int? @snapshotRetentionLimit = null,
                                       Dictionary<string,string> @tags = null)
        {
            @ClusterId = @clusterId;
            @AvailabilityZones = @availabilityZones;
            @CacheNodes = @cacheNodes;
            @NotificationTopicArn = @notificationTopicArn;
            @Port = @port;
            @PreferredAvailabilityZones = @preferredAvailabilityZones;
            @SnapshotArns = @snapshotArns;
            @SnapshotName = @snapshotName;
            @SnapshotRetentionLimit = @snapshotRetentionLimit;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cluster_id", @out: false, min: 1, max: 1)]
        public string @ClusterId { get; }

        [nterraform.Core.TerraformProperty(name: "apply_immediately", @out: true, min: 0, max: 1)]
        public bool? @ApplyImmediately { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zones", @out: false, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.Core.TerraformProperty(name: "az_mode", @out: true, min: 0, max: 1)]
        public string @AzMode { get; }

        [nterraform.Core.TerraformProperty(name: "cache_nodes", @out: false, min: 0, max: 0)]
        public cache_nodes[] @CacheNodes { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_address", @out: true, min: 0, max: 1)]
        public string @ClusterAddress { get; }

        [nterraform.Core.TerraformProperty(name: "configuration_endpoint", @out: true, min: 0, max: 1)]
        public string @ConfigurationEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.Core.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.Core.TerraformProperty(name: "maintenance_window", @out: true, min: 0, max: 1)]
        public string @MaintenanceWindow { get; }

        [nterraform.Core.TerraformProperty(name: "node_type", @out: true, min: 0, max: 1)]
        public string @NodeType { get; }

        [nterraform.Core.TerraformProperty(name: "notification_topic_arn", @out: false, min: 0, max: 1)]
        public string @NotificationTopicArn { get; }

        [nterraform.Core.TerraformProperty(name: "num_cache_nodes", @out: true, min: 0, max: 1)]
        public int? @NumCacheNodes { get; }

        [nterraform.Core.TerraformProperty(name: "parameter_group_name", @out: true, min: 0, max: 1)]
        public string @ParameterGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "preferred_availability_zones", @out: false, min: 0, max: 1)]
        public string[] @PreferredAvailabilityZones { get; }

        [nterraform.Core.TerraformProperty(name: "replication_group_id", @out: true, min: 0, max: 1)]
        public string @ReplicationGroupId { get; }

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
    }

}
