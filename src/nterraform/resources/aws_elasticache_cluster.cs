using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_elasticache_cluster")]
    public sealed class aws_elasticache_cluster : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "cache_nodes")]
        public sealed class cache_nodes : nterraform.structure
        {
            public cache_nodes()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "address", @out: true, min: 0, max: 1)]
            public string @Address { get; }

            [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
            public string @AvailabilityZone { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "cluster_id", @out: false, min: 1, max: 1)]
        public string @ClusterId { get; }

        [nterraform.TerraformProperty(name: "apply_immediately", @out: true, min: 0, max: 1)]
        public bool? @ApplyImmediately { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "availability_zones", @out: false, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.TerraformProperty(name: "az_mode", @out: true, min: 0, max: 1)]
        public string @AzMode { get; }

        [nterraform.TerraformProperty(name: "cache_nodes", @out: false, min: 0, max: 0)]
        public cache_nodes[] @CacheNodes { get; }

        [nterraform.TerraformProperty(name: "cluster_address", @out: true, min: 0, max: 1)]
        public string @ClusterAddress { get; }

        [nterraform.TerraformProperty(name: "configuration_endpoint", @out: true, min: 0, max: 1)]
        public string @ConfigurationEndpoint { get; }

        [nterraform.TerraformProperty(name: "engine", @out: true, min: 0, max: 1)]
        public string @Engine { get; }

        [nterraform.TerraformProperty(name: "engine_version", @out: true, min: 0, max: 1)]
        public string @EngineVersion { get; }

        [nterraform.TerraformProperty(name: "maintenance_window", @out: true, min: 0, max: 1)]
        public string @MaintenanceWindow { get; }

        [nterraform.TerraformProperty(name: "node_type", @out: true, min: 0, max: 1)]
        public string @NodeType { get; }

        [nterraform.TerraformProperty(name: "notification_topic_arn", @out: false, min: 0, max: 1)]
        public string @NotificationTopicArn { get; }

        [nterraform.TerraformProperty(name: "num_cache_nodes", @out: true, min: 0, max: 1)]
        public int? @NumCacheNodes { get; }

        [nterraform.TerraformProperty(name: "parameter_group_name", @out: true, min: 0, max: 1)]
        public string @ParameterGroupName { get; }

        [nterraform.TerraformProperty(name: "port", @out: false, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "preferred_availability_zones", @out: false, min: 0, max: 1)]
        public string[] @PreferredAvailabilityZones { get; }

        [nterraform.TerraformProperty(name: "replication_group_id", @out: true, min: 0, max: 1)]
        public string @ReplicationGroupId { get; }

        [nterraform.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupIds { get; }

        [nterraform.TerraformProperty(name: "security_group_names", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupNames { get; }

        [nterraform.TerraformProperty(name: "snapshot_arns", @out: false, min: 0, max: 1)]
        public string[] @SnapshotArns { get; }

        [nterraform.TerraformProperty(name: "snapshot_name", @out: false, min: 0, max: 1)]
        public string @SnapshotName { get; }

        [nterraform.TerraformProperty(name: "snapshot_retention_limit", @out: false, min: 0, max: 1)]
        public int? @SnapshotRetentionLimit { get; }

        [nterraform.TerraformProperty(name: "snapshot_window", @out: true, min: 0, max: 1)]
        public string @SnapshotWindow { get; }

        [nterraform.TerraformProperty(name: "subnet_group_name", @out: true, min: 0, max: 1)]
        public string @SubnetGroupName { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
