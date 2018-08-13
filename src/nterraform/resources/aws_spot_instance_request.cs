using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_spot_instance_request")]
    public sealed class aws_spot_instance_request : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "ephemeral_block_device")]
        public sealed class ephemeral_block_device : nterraform.structure
        {
            public ephemeral_block_device(string @deviceName,
                                          bool? @noDevice = null,
                                          string @virtualName = null)
            {
                @DeviceName = @deviceName;
                @NoDevice = @noDevice;
                @VirtualName = @virtualName;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
            public string @DeviceName { get; }

            [nterraform.TerraformProperty(name: "no_device", @out: false, min: 0, max: 1)]
            public bool? @NoDevice { get; }

            [nterraform.TerraformProperty(name: "virtual_name", @out: false, min: 0, max: 1)]
            public string @VirtualName { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "root_block_device")]
        public sealed class root_block_device : nterraform.structure
        {
            public root_block_device(bool? @deleteOnTermination = null)
            {
                @DeleteOnTermination = @deleteOnTermination;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.TerraformProperty(name: "volume_id", @out: true, min: 0, max: 1)]
            public string @VolumeId { get; }

            [nterraform.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ebs_block_device")]
        public sealed class ebs_block_device : nterraform.structure
        {
            public ebs_block_device(string @deviceName,
                                    bool? @deleteOnTermination = null)
            {
                @DeviceName = @deviceName;
                @DeleteOnTermination = @deleteOnTermination;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
            public string @DeviceName { get; }

            [nterraform.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.TerraformProperty(name: "encrypted", @out: true, min: 0, max: 1)]
            public bool? @Encrypted { get; }

            [nterraform.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.TerraformProperty(name: "snapshot_id", @out: true, min: 0, max: 1)]
            public string @SnapshotId { get; }

            [nterraform.TerraformProperty(name: "volume_id", @out: true, min: 0, max: 1)]
            public string @VolumeId { get; }

            [nterraform.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "network_interface")]
        public sealed class network_interface : nterraform.structure
        {
            public network_interface(int @deviceIndex,
                                     string @networkInterfaceId,
                                     bool? @deleteOnTermination = null)
            {
                @DeviceIndex = @deviceIndex;
                @NetworkInterfaceId = @networkInterfaceId;
                @DeleteOnTermination = @deleteOnTermination;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "device_index", @out: false, min: 1, max: 1)]
            public int @DeviceIndex { get; }

            [nterraform.TerraformProperty(name: "network_interface_id", @out: false, min: 1, max: 1)]
            public string @NetworkInterfaceId { get; }

            [nterraform.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "credit_specification")]
        public sealed class credit_specification : nterraform.structure
        {
            public credit_specification(string @cpuCredits = null)
            {
                @CpuCredits = @cpuCredits;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cpu_credits", @out: false, min: 0, max: 1)]
            public string @CpuCredits { get; }
        }

        public aws_spot_instance_request(string @ami,
                                         string @instanceType,
                                         Dictionary<string,string> @blockDevice = null,
                                         int? @blockDurationMinutes = null,
                                         credit_specification[] @creditSpecification = null,
                                         bool? @disableApiTermination = null,
                                         ebs_block_device[] @ebsBlockDevice = null,
                                         bool? @ebsOptimized = null,
                                         ephemeral_block_device[] @ephemeralBlockDevice = null,
                                         bool? @getPasswordData = null,
                                         string @iamInstanceProfile = null,
                                         string @instanceInitiatedShutdownBehavior = null,
                                         string @instanceInterruptionBehaviour = null,
                                         string @launchGroup = null,
                                         bool? @monitoring = null,
                                         network_interface[] @networkInterface = null,
                                         root_block_device[] @rootBlockDevice = null,
                                         bool? @sourceDestCheck = null,
                                         string @spotPrice = null,
                                         string @spotType = null,
                                         Dictionary<string,string> @tags = null,
                                         string @userData = null,
                                         string @userDataBase64 = null,
                                         Dictionary<string,string> @volumeTags = null,
                                         bool? @waitForFulfillment = null)
        {
            @Ami = @ami;
            @InstanceType = @instanceType;
            @BlockDevice = @blockDevice;
            @BlockDurationMinutes = @blockDurationMinutes;
            @CreditSpecification = @creditSpecification;
            @DisableApiTermination = @disableApiTermination;
            @EbsBlockDevice = @ebsBlockDevice;
            @EbsOptimized = @ebsOptimized;
            @EphemeralBlockDevice = @ephemeralBlockDevice;
            @GetPasswordData = @getPasswordData;
            @IamInstanceProfile = @iamInstanceProfile;
            @InstanceInitiatedShutdownBehavior = @instanceInitiatedShutdownBehavior;
            @InstanceInterruptionBehaviour = @instanceInterruptionBehaviour;
            @LaunchGroup = @launchGroup;
            @Monitoring = @monitoring;
            @NetworkInterface = @networkInterface;
            @RootBlockDevice = @rootBlockDevice;
            @SourceDestCheck = @sourceDestCheck;
            @SpotPrice = @spotPrice;
            @SpotType = @spotType;
            @Tags = @tags;
            @UserData = @userData;
            @UserDataBase64 = @userDataBase64;
            @VolumeTags = @volumeTags;
            @WaitForFulfillment = @waitForFulfillment;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "ami", @out: false, min: 1, max: 1)]
        public string @Ami { get; }

        [nterraform.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
        public string @InstanceType { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "associate_public_ip_address", @out: true, min: 0, max: 1)]
        public bool? @AssociatePublicIpAddress { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "block_device", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @BlockDevice { get; }

        [nterraform.TerraformProperty(name: "block_duration_minutes", @out: false, min: 0, max: 1)]
        public int? @BlockDurationMinutes { get; }

        [nterraform.TerraformProperty(name: "cpu_core_count", @out: true, min: 0, max: 1)]
        public int? @CpuCoreCount { get; }

        [nterraform.TerraformProperty(name: "cpu_threads_per_core", @out: true, min: 0, max: 1)]
        public int? @CpuThreadsPerCore { get; }

        [nterraform.TerraformProperty(name: "credit_specification", @out: false, min: 0, max: 1)]
        public credit_specification[] @CreditSpecification { get; }

        [nterraform.TerraformProperty(name: "disable_api_termination", @out: false, min: 0, max: 1)]
        public bool? @DisableApiTermination { get; }

        [nterraform.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.TerraformProperty(name: "get_password_data", @out: false, min: 0, max: 1)]
        public bool? @GetPasswordData { get; }

        [nterraform.TerraformProperty(name: "iam_instance_profile", @out: false, min: 0, max: 1)]
        public string @IamInstanceProfile { get; }

        [nterraform.TerraformProperty(name: "instance_initiated_shutdown_behavior", @out: false, min: 0, max: 1)]
        public string @InstanceInitiatedShutdownBehavior { get; }

        [nterraform.TerraformProperty(name: "instance_interruption_behaviour", @out: false, min: 0, max: 1)]
        public string @InstanceInterruptionBehaviour { get; }

        [nterraform.TerraformProperty(name: "instance_state", @out: true, min: 0, max: 1)]
        public string @InstanceState { get; }

        [nterraform.TerraformProperty(name: "ipv6_address_count", @out: true, min: 0, max: 1)]
        public int? @Ipv6AddressCount { get; }

        [nterraform.TerraformProperty(name: "ipv6_addresses", @out: true, min: 0, max: 1)]
        public string[] @Ipv6Addresses { get; }

        [nterraform.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.TerraformProperty(name: "launch_group", @out: false, min: 0, max: 1)]
        public string @LaunchGroup { get; }

        [nterraform.TerraformProperty(name: "monitoring", @out: false, min: 0, max: 1)]
        public bool? @Monitoring { get; }

        [nterraform.TerraformProperty(name: "network_interface", @out: false, min: 0, max: 0)]
        public network_interface[] @NetworkInterface { get; }

        [nterraform.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "password_data", @out: true, min: 0, max: 1)]
        public string @PasswordData { get; }

        [nterraform.TerraformProperty(name: "placement_group", @out: true, min: 0, max: 1)]
        public string @PlacementGroup { get; }

        [nterraform.TerraformProperty(name: "primary_network_interface_id", @out: true, min: 0, max: 1)]
        public string @PrimaryNetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "private_dns", @out: true, min: 0, max: 1)]
        public string @PrivateDns { get; }

        [nterraform.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.TerraformProperty(name: "public_dns", @out: true, min: 0, max: 1)]
        public string @PublicDns { get; }

        [nterraform.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }

        [nterraform.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 1)]
        public root_block_device[] @RootBlockDevice { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "source_dest_check", @out: false, min: 0, max: 1)]
        public bool? @SourceDestCheck { get; }

        [nterraform.TerraformProperty(name: "spot_bid_status", @out: true, min: 0, max: 1)]
        public string @SpotBidStatus { get; }

        [nterraform.TerraformProperty(name: "spot_instance_id", @out: true, min: 0, max: 1)]
        public string @SpotInstanceId { get; }

        [nterraform.TerraformProperty(name: "spot_price", @out: false, min: 0, max: 1)]
        public string @SpotPrice { get; }

        [nterraform.TerraformProperty(name: "spot_request_state", @out: true, min: 0, max: 1)]
        public string @SpotRequestState { get; }

        [nterraform.TerraformProperty(name: "spot_type", @out: false, min: 0, max: 1)]
        public string @SpotType { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "tenancy", @out: true, min: 0, max: 1)]
        public string @Tenancy { get; }

        [nterraform.TerraformProperty(name: "user_data", @out: false, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.TerraformProperty(name: "user_data_base64", @out: false, min: 0, max: 1)]
        public string @UserDataBase64 { get; }

        [nterraform.TerraformProperty(name: "valid_from", @out: true, min: 0, max: 1)]
        public string @ValidFrom { get; }

        [nterraform.TerraformProperty(name: "valid_until", @out: true, min: 0, max: 1)]
        public string @ValidUntil { get; }

        [nterraform.TerraformProperty(name: "volume_tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @VolumeTags { get; }

        [nterraform.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }

        [nterraform.TerraformProperty(name: "wait_for_fulfillment", @out: false, min: 0, max: 1)]
        public bool? @WaitForFulfillment { get; }
    }

}
