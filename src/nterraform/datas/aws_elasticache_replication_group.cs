using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_elasticache_replication_group")]
    public sealed class aws_elasticache_replication_group : nterraform.data
    {
        public aws_elasticache_replication_group(string @replicationGroupId)
        {
            @ReplicationGroupId = @replicationGroupId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "replication_group_id", @out: false, min: 1, max: 1)]
        public string @ReplicationGroupId { get; }

        [nterraform.TerraformProperty(name: "auth_token_enabled", @out: true, min: 0, max: 1)]
        public bool? @AuthTokenEnabled { get; }

        [nterraform.TerraformProperty(name: "automatic_failover_enabled", @out: true, min: 0, max: 1)]
        public bool? @AutomaticFailoverEnabled { get; }

        [nterraform.TerraformProperty(name: "configuration_endpoint_address", @out: true, min: 0, max: 1)]
        public string @ConfigurationEndpointAddress { get; }

        [nterraform.TerraformProperty(name: "member_clusters", @out: true, min: 0, max: 1)]
        public string[] @MemberClusters { get; }

        [nterraform.TerraformProperty(name: "node_type", @out: true, min: 0, max: 1)]
        public string @NodeType { get; }

        [nterraform.TerraformProperty(name: "number_cache_clusters", @out: true, min: 0, max: 1)]
        public int? @NumberCacheClusters { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "primary_endpoint_address", @out: true, min: 0, max: 1)]
        public string @PrimaryEndpointAddress { get; }

        [nterraform.TerraformProperty(name: "replication_group_description", @out: true, min: 0, max: 1)]
        public string @ReplicationGroupDescription { get; }

        [nterraform.TerraformProperty(name: "snapshot_retention_limit", @out: true, min: 0, max: 1)]
        public int? @SnapshotRetentionLimit { get; }

        [nterraform.TerraformProperty(name: "snapshot_window", @out: true, min: 0, max: 1)]
        public string @SnapshotWindow { get; }
    }

}
