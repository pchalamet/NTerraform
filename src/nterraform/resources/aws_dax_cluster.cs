using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dax_cluster")]
    public sealed class aws_dax_cluster : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "nodes")]
        public sealed class nodes : nterraform.Core.structure
        {
            public nodes()
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

        public aws_dax_cluster(string @clusterName,
                               string @iamRoleArn,
                               string @nodeType,
                               int @replicationFactor,
                               string[] @availabilityZones = null,
                               string @description = null,
                               nodes[] @nodes = null,
                               string @notificationTopicArn = null,
                               Dictionary<string,string> @tags = null)
        {
            @ClusterName = @clusterName;
            @IamRoleArn = @iamRoleArn;
            @NodeType = @nodeType;
            @ReplicationFactor = @replicationFactor;
            @AvailabilityZones = @availabilityZones;
            @Description = @description;
            @Nodes = @nodes;
            @NotificationTopicArn = @notificationTopicArn;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cluster_name", @out: false, min: 1, max: 1)]
        public string @ClusterName { get; }

        [nterraform.Core.TerraformProperty(name: "iam_role_arn", @out: false, min: 1, max: 1)]
        public string @IamRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "node_type", @out: false, min: 1, max: 1)]
        public string @NodeType { get; }

        [nterraform.Core.TerraformProperty(name: "replication_factor", @out: false, min: 1, max: 1)]
        public int @ReplicationFactor { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zones", @out: false, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.Core.TerraformProperty(name: "cluster_address", @out: true, min: 0, max: 1)]
        public string @ClusterAddress { get; }

        [nterraform.Core.TerraformProperty(name: "configuration_endpoint", @out: true, min: 0, max: 1)]
        public string @ConfigurationEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "maintenance_window", @out: true, min: 0, max: 1)]
        public string @MaintenanceWindow { get; }

        [nterraform.Core.TerraformProperty(name: "nodes", @out: false, min: 0, max: 0)]
        public nodes[] @Nodes { get; }

        [nterraform.Core.TerraformProperty(name: "notification_topic_arn", @out: false, min: 0, max: 1)]
        public string @NotificationTopicArn { get; }

        [nterraform.Core.TerraformProperty(name: "parameter_group_name", @out: true, min: 0, max: 1)]
        public string @ParameterGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupIds { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_group_name", @out: true, min: 0, max: 1)]
        public string @SubnetGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
