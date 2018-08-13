using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_instance")]
    public sealed class aws_instance : nterraform.Core.resource
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

            [nterraform.Core.TerraformProperty(name: "volume_id", @out: true, min: 0, max: 1)]
            public string @VolumeId { get; }

            [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ephemeral_block_device")]
        public sealed class ephemeral_block_device : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
            public string @DeviceName { get; }

            [nterraform.Core.TerraformProperty(name: "no_device", @out: false, min: 0, max: 1)]
            public bool? @NoDevice { get; }

            [nterraform.Core.TerraformProperty(name: "virtual_name", @out: false, min: 0, max: 1)]
            public string @VirtualName { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "network_interface")]
        public sealed class network_interface : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "device_index", @out: false, min: 1, max: 1)]
            public int @DeviceIndex { get; }

            [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: false, min: 1, max: 1)]
            public string @NetworkInterfaceId { get; }

            [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "credit_specification")]
        public sealed class credit_specification : nterraform.Core.structure
        {
            public credit_specification(string @cpuCredits = null)
            {
                @CpuCredits = @cpuCredits;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "cpu_credits", @out: false, min: 0, max: 1)]
            public string @CpuCredits { get; }
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

            [nterraform.Core.TerraformProperty(name: "volume_id", @out: true, min: 0, max: 1)]
            public string @VolumeId { get; }

            [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        public aws_instance(string @ami,
                            string @instanceType,
                            Dictionary<string,string> @blockDevice = null,
                            credit_specification[] @creditSpecification = null,
                            bool? @disableApiTermination = null,
                            ebs_block_device[] @ebsBlockDevice = null,
                            bool? @ebsOptimized = null,
                            ephemeral_block_device[] @ephemeralBlockDevice = null,
                            bool? @getPasswordData = null,
                            string @iamInstanceProfile = null,
                            string @instanceInitiatedShutdownBehavior = null,
                            bool? @monitoring = null,
                            network_interface[] @networkInterface = null,
                            root_block_device[] @rootBlockDevice = null,
                            bool? @sourceDestCheck = null,
                            Dictionary<string,string> @tags = null,
                            string @userData = null,
                            string @userDataBase64 = null)
        {
            @Ami = @ami;
            @InstanceType = @instanceType;
            @BlockDevice = @blockDevice;
            @CreditSpecification = @creditSpecification;
            @DisableApiTermination = @disableApiTermination;
            @EbsBlockDevice = @ebsBlockDevice;
            @EbsOptimized = @ebsOptimized;
            @EphemeralBlockDevice = @ephemeralBlockDevice;
            @GetPasswordData = @getPasswordData;
            @IamInstanceProfile = @iamInstanceProfile;
            @InstanceInitiatedShutdownBehavior = @instanceInitiatedShutdownBehavior;
            @Monitoring = @monitoring;
            @NetworkInterface = @networkInterface;
            @RootBlockDevice = @rootBlockDevice;
            @SourceDestCheck = @sourceDestCheck;
            @Tags = @tags;
            @UserData = @userData;
            @UserDataBase64 = @userDataBase64;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "ami", @out: false, min: 1, max: 1)]
        public string @Ami { get; }

        [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 1, max: 1)]
        public string @InstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "associate_public_ip_address", @out: true, min: 0, max: 1)]
        public bool? @AssociatePublicIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "block_device", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @BlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "cpu_core_count", @out: true, min: 0, max: 1)]
        public int? @CpuCoreCount { get; }

        [nterraform.Core.TerraformProperty(name: "cpu_threads_per_core", @out: true, min: 0, max: 1)]
        public int? @CpuThreadsPerCore { get; }

        [nterraform.Core.TerraformProperty(name: "credit_specification", @out: false, min: 0, max: 1)]
        public credit_specification[] @CreditSpecification { get; }

        [nterraform.Core.TerraformProperty(name: "disable_api_termination", @out: false, min: 0, max: 1)]
        public bool? @DisableApiTermination { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.Core.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "get_password_data", @out: false, min: 0, max: 1)]
        public bool? @GetPasswordData { get; }

        [nterraform.Core.TerraformProperty(name: "iam_instance_profile", @out: false, min: 0, max: 1)]
        public string @IamInstanceProfile { get; }

        [nterraform.Core.TerraformProperty(name: "instance_initiated_shutdown_behavior", @out: false, min: 0, max: 1)]
        public string @InstanceInitiatedShutdownBehavior { get; }

        [nterraform.Core.TerraformProperty(name: "instance_state", @out: true, min: 0, max: 1)]
        public string @InstanceState { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_address_count", @out: true, min: 0, max: 1)]
        public int? @Ipv6AddressCount { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_addresses", @out: true, min: 0, max: 1)]
        public string[] @Ipv6Addresses { get; }

        [nterraform.Core.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.Core.TerraformProperty(name: "monitoring", @out: false, min: 0, max: 1)]
        public bool? @Monitoring { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface", @out: false, min: 0, max: 0)]
        public network_interface[] @NetworkInterface { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "password_data", @out: true, min: 0, max: 1)]
        public string @PasswordData { get; }

        [nterraform.Core.TerraformProperty(name: "placement_group", @out: true, min: 0, max: 1)]
        public string @PlacementGroup { get; }

        [nterraform.Core.TerraformProperty(name: "primary_network_interface_id", @out: true, min: 0, max: 1)]
        public string @PrimaryNetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "private_dns", @out: true, min: 0, max: 1)]
        public string @PrivateDns { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.Core.TerraformProperty(name: "public_dns", @out: true, min: 0, max: 1)]
        public string @PublicDns { get; }

        [nterraform.Core.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }

        [nterraform.Core.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 1)]
        public root_block_device[] @RootBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "source_dest_check", @out: false, min: 0, max: 1)]
        public bool? @SourceDestCheck { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "tenancy", @out: true, min: 0, max: 1)]
        public string @Tenancy { get; }

        [nterraform.Core.TerraformProperty(name: "user_data", @out: false, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.Core.TerraformProperty(name: "user_data_base64", @out: false, min: 0, max: 1)]
        public string @UserDataBase64 { get; }

        [nterraform.Core.TerraformProperty(name: "volume_tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @VolumeTags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
