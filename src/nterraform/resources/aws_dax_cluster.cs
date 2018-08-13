using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dax_cluster")]
    public sealed class aws_dax_cluster : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "nodes")]
        public sealed class nodes : nterraform.structure
        {
            public nodes()
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

        [nterraform.TerraformProperty(name: "cluster_name", @out: false, min: 1, max: 1)]
        public string @ClusterName { get; }

        [nterraform.TerraformProperty(name: "iam_role_arn", @out: false, min: 1, max: 1)]
        public string @IamRoleArn { get; }

        [nterraform.TerraformProperty(name: "node_type", @out: false, min: 1, max: 1)]
        public string @NodeType { get; }

        [nterraform.TerraformProperty(name: "replication_factor", @out: false, min: 1, max: 1)]
        public int @ReplicationFactor { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "availability_zones", @out: false, min: 0, max: 1)]
        public string[] @AvailabilityZones { get; }

        [nterraform.TerraformProperty(name: "cluster_address", @out: true, min: 0, max: 1)]
        public string @ClusterAddress { get; }

        [nterraform.TerraformProperty(name: "configuration_endpoint", @out: true, min: 0, max: 1)]
        public string @ConfigurationEndpoint { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "maintenance_window", @out: true, min: 0, max: 1)]
        public string @MaintenanceWindow { get; }

        [nterraform.TerraformProperty(name: "nodes", @out: false, min: 0, max: 0)]
        public nodes[] @Nodes { get; }

        [nterraform.TerraformProperty(name: "notification_topic_arn", @out: false, min: 0, max: 1)]
        public string @NotificationTopicArn { get; }

        [nterraform.TerraformProperty(name: "parameter_group_name", @out: true, min: 0, max: 1)]
        public string @ParameterGroupName { get; }

        [nterraform.TerraformProperty(name: "port", @out: true, min: 0, max: 1)]
        public int? @Port { get; }

        [nterraform.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupIds { get; }

        [nterraform.TerraformProperty(name: "subnet_group_name", @out: true, min: 0, max: 1)]
        public string @SubnetGroupName { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
