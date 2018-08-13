using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_batch_compute_environment")]
    public sealed class aws_batch_compute_environment : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "compute_resources")]
        public sealed class compute_resources : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "instance_role", @out: false, min: 1, max: 1)]
            public string @InstanceRole { get; }

            [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
            public string[] @InstanceType { get; }

            [nterraform.Core.TerraformProperty(name: "max_vcpus", @out: false, min: 1, max: 1)]
            public int @MaxVcpus { get; }

            [nterraform.Core.TerraformProperty(name: "min_vcpus", @out: false, min: 1, max: 1)]
            public int @MinVcpus { get; }

            [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: false, min: 1, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "subnets", @out: false, min: 1, max: 1)]
            public string[] @Subnets { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "bid_percentage", @out: false, min: 0, max: 1)]
            public int? @BidPercentage { get; }

            [nterraform.Core.TerraformProperty(name: "desired_vcpus", @out: false, min: 0, max: 1)]
            public int? @DesiredVcpus { get; }

            [nterraform.Core.TerraformProperty(name: "ec2_key_pair", @out: false, min: 0, max: 1)]
            public string @Ec2KeyPair { get; }

            [nterraform.Core.TerraformProperty(name: "image_id", @out: false, min: 0, max: 1)]
            public string @ImageId { get; }

            [nterraform.Core.TerraformProperty(name: "spot_iam_fleet_role", @out: false, min: 0, max: 1)]
            public string @SpotIamFleetRole { get; }

            [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "compute_environment_name", @out: false, min: 1, max: 1)]
        public string @ComputeEnvironmentName { get; }

        [nterraform.Core.TerraformProperty(name: "service_role", @out: false, min: 1, max: 1)]
        public string @ServiceRole { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "compute_resources", @out: false, min: 0, max: 1)]
        public compute_resources[] @ComputeResources { get; }

        [nterraform.Core.TerraformProperty(name: "ecc_cluster_arn", @out: true, min: 0, max: 1)]
        public string @EccClusterArn { get; }

        [nterraform.Core.TerraformProperty(name: "ecs_cluster_arn", @out: true, min: 0, max: 1)]
        public string @EcsClusterArn { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "status_reason", @out: true, min: 0, max: 1)]
        public string @StatusReason { get; }
    }

}
