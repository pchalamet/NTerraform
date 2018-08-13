using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_batch_compute_environment")]
    public sealed class aws_batch_compute_environment : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "compute_resources")]
        public sealed class compute_resources : nterraform.structure
        {
            public compute_resources(string @instanceRole,
                                     string[] @instanceType,
                                     int @maxVcpus,
                                     int @minVcpus,
                                     string[] @securityGroupIds,
                                     string[] @subnets,
                                     string @type,
                                     int? @bidPercentage = null,
                                     int? @desiredVcpus = null,
                                     string @ec2KeyPair = null,
                                     string @imageId = null,
                                     string @spotIamFleetRole = null,
                                     Dictionary<string,string> @tags = null)
            {
                @InstanceRole = @instanceRole;
                @InstanceType = @instanceType;
                @MaxVcpus = @maxVcpus;
                @MinVcpus = @minVcpus;
                @SecurityGroupIds = @securityGroupIds;
                @Subnets = @subnets;
                @Type = @type;
                @BidPercentage = @bidPercentage;
                @DesiredVcpus = @desiredVcpus;
                @Ec2KeyPair = @ec2KeyPair;
                @ImageId = @imageId;
                @SpotIamFleetRole = @spotIamFleetRole;
                @Tags = @tags;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "instance_role", @out: false, min: 1, max: 1)]
            public string @InstanceRole { get; }

            [nterraform.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
            public string[] @InstanceType { get; }

            [nterraform.TerraformProperty(name: "max_vcpus", @out: false, min: 1, max: 1)]
            public int @MaxVcpus { get; }

            [nterraform.TerraformProperty(name: "min_vcpus", @out: false, min: 1, max: 1)]
            public int @MinVcpus { get; }

            [nterraform.TerraformProperty(name: "security_group_ids", @out: false, min: 1, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.TerraformProperty(name: "subnets", @out: false, min: 1, max: 1)]
            public string[] @Subnets { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "bid_percentage", @out: false, min: 0, max: 1)]
            public int? @BidPercentage { get; }

            [nterraform.TerraformProperty(name: "desired_vcpus", @out: false, min: 0, max: 1)]
            public int? @DesiredVcpus { get; }

            [nterraform.TerraformProperty(name: "ec2_key_pair", @out: false, min: 0, max: 1)]
            public string @Ec2KeyPair { get; }

            [nterraform.TerraformProperty(name: "image_id", @out: false, min: 0, max: 1)]
            public string @ImageId { get; }

            [nterraform.TerraformProperty(name: "spot_iam_fleet_role", @out: false, min: 0, max: 1)]
            public string @SpotIamFleetRole { get; }

            [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Tags { get; }
        }

        public aws_batch_compute_environment(string @computeEnvironmentName,
                                             string @serviceRole,
                                             string @type,
                                             compute_resources[] @computeResources = null,
                                             string @state = null)
        {
            @ComputeEnvironmentName = @computeEnvironmentName;
            @ServiceRole = @serviceRole;
            @Type = @type;
            @ComputeResources = @computeResources;
            @State = @state;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "compute_environment_name", @out: false, min: 1, max: 1)]
        public string @ComputeEnvironmentName { get; }

        [nterraform.TerraformProperty(name: "service_role", @out: false, min: 1, max: 1)]
        public string @ServiceRole { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "compute_resources", @out: false, min: 0, max: 1)]
        public compute_resources[] @ComputeResources { get; }

        [nterraform.TerraformProperty(name: "ecc_cluster_arn", @out: true, min: 0, max: 1)]
        public string @EccClusterArn { get; }

        [nterraform.TerraformProperty(name: "ecs_cluster_arn", @out: true, min: 0, max: 1)]
        public string @EcsClusterArn { get; }

        [nterraform.TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "status_reason", @out: true, min: 0, max: 1)]
        public string @StatusReason { get; }
    }

}
