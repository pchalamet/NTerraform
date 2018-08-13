using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_spot_fleet_request")]
    public sealed class aws_spot_fleet_request : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "launch_specification")]
        public sealed class launch_specification : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ebs_block_device")]
            public sealed class ebs_block_device : nterraform.Core.structure
            {
                public ebs_block_device(string @deviceName,
                                        bool? @deleteOnTermination = null)
                {
                    @DeviceName = @deviceName;
                    @DeleteOnTermination = @deleteOnTermination;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
                public string @DeviceName { get; }

                [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
                public bool? @DeleteOnTermination { get; }

                [nterraform.Core.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
                public bool? @Encrypted { get; }

                [nterraform.Core.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
                public int? @Iops { get; }

                [nterraform.Core.TerraformProperty(name: "snapshot_id", @out: true, min: 0, max: 1)]
                public string @SnapshotId { get; }

                [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
                public int? @VolumeSize { get; }

                [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
                public string @VolumeType { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ephemeral_block_device")]
            public sealed class ephemeral_block_device : nterraform.Core.structure
            {
                public ephemeral_block_device(string @deviceName,
                                              string @virtualName)
                {
                    @DeviceName = @deviceName;
                    @VirtualName = @virtualName;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
                public string @DeviceName { get; }

                [nterraform.Core.TerraformProperty(name: "virtual_name", @out: false, min: 1, max: 1)]
                public string @VirtualName { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "root_block_device")]
            public sealed class root_block_device : nterraform.Core.structure
            {
                public root_block_device(bool? @deleteOnTermination = null)
                {
                    @DeleteOnTermination = @deleteOnTermination;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
                public bool? @DeleteOnTermination { get; }

                [nterraform.Core.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
                public int? @Iops { get; }

                [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
                public int? @VolumeSize { get; }

                [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
                public string @VolumeType { get; }
            }

            public launch_specification(string @ami,
                                        string @instanceType,
                                        bool? @associatePublicIpAddress = null,
                                        ebs_block_device[] @ebsBlockDevice = null,
                                        bool? @ebsOptimized = null,
                                        ephemeral_block_device[] @ephemeralBlockDevice = null,
                                        string @iamInstanceProfile = null,
                                        string @iamInstanceProfileArn = null,
                                        bool? @monitoring = null,
                                        string @placementTenancy = null,
                                        root_block_device[] @rootBlockDevice = null,
                                        string @spotPrice = null,
                                        Dictionary<string,string> @tags = null,
                                        string @userData = null,
                                        string @weightedCapacity = null)
            {
                @Ami = @ami;
                @InstanceType = @instanceType;
                @AssociatePublicIpAddress = @associatePublicIpAddress;
                @EbsBlockDevice = @ebsBlockDevice;
                @EbsOptimized = @ebsOptimized;
                @EphemeralBlockDevice = @ephemeralBlockDevice;
                @IamInstanceProfile = @iamInstanceProfile;
                @IamInstanceProfileArn = @iamInstanceProfileArn;
                @Monitoring = @monitoring;
                @PlacementTenancy = @placementTenancy;
                @RootBlockDevice = @rootBlockDevice;
                @SpotPrice = @spotPrice;
                @Tags = @tags;
                @UserData = @userData;
                @WeightedCapacity = @weightedCapacity;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "ami", @out: false, min: 1, max: 1)]
            public string @Ami { get; }

            [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
            public string @InstanceType { get; }

            [nterraform.Core.TerraformProperty(name: "associate_public_ip_address", @out: false, min: 0, max: 1)]
            public bool? @AssociatePublicIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
            public string @AvailabilityZone { get; }

            [nterraform.Core.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
            public ebs_block_device[] @EbsBlockDevice { get; }

            [nterraform.Core.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
            public bool? @EbsOptimized { get; }

            [nterraform.Core.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
            public ephemeral_block_device[] @EphemeralBlockDevice { get; }

            [nterraform.Core.TerraformProperty(name: "iam_instance_profile", @out: false, min: 0, max: 1)]
            public string @IamInstanceProfile { get; }

            [nterraform.Core.TerraformProperty(name: "iam_instance_profile_arn", @out: false, min: 0, max: 1)]
            public string @IamInstanceProfileArn { get; }

            [nterraform.Core.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
            public string @KeyName { get; }

            [nterraform.Core.TerraformProperty(name: "monitoring", @out: false, min: 0, max: 1)]
            public bool? @Monitoring { get; }

            [nterraform.Core.TerraformProperty(name: "placement_group", @out: true, min: 0, max: 1)]
            public string @PlacementGroup { get; }

            [nterraform.Core.TerraformProperty(name: "placement_tenancy", @out: false, min: 0, max: 1)]
            public string @PlacementTenancy { get; }

            [nterraform.Core.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 0)]
            public root_block_device[] @RootBlockDevice { get; }

            [nterraform.Core.TerraformProperty(name: "spot_price", @out: false, min: 0, max: 1)]
            public string @SpotPrice { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
            public string @SubnetId { get; }

            [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Tags { get; }

            [nterraform.Core.TerraformProperty(name: "user_data", @out: false, min: 0, max: 1)]
            public string @UserData { get; }

            [nterraform.Core.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
            public string[] @VpcSecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "weighted_capacity", @out: false, min: 0, max: 1)]
            public string @WeightedCapacity { get; }
        }

        public aws_spot_fleet_request(string @iamFleetRole,
                                      launch_specification[] @launchSpecification,
                                      int @targetCapacity,
                                      string @allocationStrategy = null,
                                      string @excessCapacityTerminationPolicy = null,
                                      string @fleetType = null,
                                      string @instanceInterruptionBehaviour = null,
                                      bool? @replaceUnhealthyInstances = null,
                                      string @spotPrice = null,
                                      bool? @terminateInstancesWithExpiration = null,
                                      string @validFrom = null,
                                      string @validUntil = null,
                                      bool? @waitForFulfillment = null)
        {
            @IamFleetRole = @iamFleetRole;
            @LaunchSpecification = @launchSpecification;
            @TargetCapacity = @targetCapacity;
            @AllocationStrategy = @allocationStrategy;
            @ExcessCapacityTerminationPolicy = @excessCapacityTerminationPolicy;
            @FleetType = @fleetType;
            @InstanceInterruptionBehaviour = @instanceInterruptionBehaviour;
            @ReplaceUnhealthyInstances = @replaceUnhealthyInstances;
            @SpotPrice = @spotPrice;
            @TerminateInstancesWithExpiration = @terminateInstancesWithExpiration;
            @ValidFrom = @validFrom;
            @ValidUntil = @validUntil;
            @WaitForFulfillment = @waitForFulfillment;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "iam_fleet_role", @out: false, min: 1, max: 1)]
        public string @IamFleetRole { get; }

        [nterraform.Core.TerraformProperty(name: "launch_specification", @out: false, min: 1, max: 0)]
        public launch_specification[] @LaunchSpecification { get; }

        [nterraform.Core.TerraformProperty(name: "target_capacity", @out: false, min: 1, max: 1)]
        public int @TargetCapacity { get; }

        [nterraform.Core.TerraformProperty(name: "allocation_strategy", @out: false, min: 0, max: 1)]
        public string @AllocationStrategy { get; }

        [nterraform.Core.TerraformProperty(name: "client_token", @out: true, min: 0, max: 1)]
        public string @ClientToken { get; }

        [nterraform.Core.TerraformProperty(name: "excess_capacity_termination_policy", @out: false, min: 0, max: 1)]
        public string @ExcessCapacityTerminationPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "fleet_type", @out: false, min: 0, max: 1)]
        public string @FleetType { get; }

        [nterraform.Core.TerraformProperty(name: "instance_interruption_behaviour", @out: false, min: 0, max: 1)]
        public string @InstanceInterruptionBehaviour { get; }

        [nterraform.Core.TerraformProperty(name: "load_balancers", @out: true, min: 0, max: 1)]
        public string[] @LoadBalancers { get; }

        [nterraform.Core.TerraformProperty(name: "replace_unhealthy_instances", @out: false, min: 0, max: 1)]
        public bool? @ReplaceUnhealthyInstances { get; }

        [nterraform.Core.TerraformProperty(name: "spot_price", @out: false, min: 0, max: 1)]
        public string @SpotPrice { get; }

        [nterraform.Core.TerraformProperty(name: "spot_request_state", @out: true, min: 0, max: 1)]
        public string @SpotRequestState { get; }

        [nterraform.Core.TerraformProperty(name: "target_group_arns", @out: true, min: 0, max: 1)]
        public string[] @TargetGroupArns { get; }

        [nterraform.Core.TerraformProperty(name: "terminate_instances_with_expiration", @out: false, min: 0, max: 1)]
        public bool? @TerminateInstancesWithExpiration { get; }

        [nterraform.Core.TerraformProperty(name: "valid_from", @out: false, min: 0, max: 1)]
        public string @ValidFrom { get; }

        [nterraform.Core.TerraformProperty(name: "valid_until", @out: false, min: 0, max: 1)]
        public string @ValidUntil { get; }

        [nterraform.Core.TerraformProperty(name: "wait_for_fulfillment", @out: false, min: 0, max: 1)]
        public bool? @WaitForFulfillment { get; }
    }

}
