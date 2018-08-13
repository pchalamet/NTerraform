using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_launch_template")]
    public sealed class aws_launch_template : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "iam_instance_profile")]
        public sealed class iam_instance_profile : nterraform.structure
        {
            public iam_instance_profile(string @arn = null,
                                        string @name = null)
            {
                @Arn = @arn;
                @Name = @name;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "arn", @out: false, min: 0, max: 1)]
            public string @Arn { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "instance_market_options")]
        public sealed class instance_market_options : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "spot_options")]
            public sealed class spot_options : nterraform.structure
            {
                public spot_options(int? @blockDurationMinutes = null,
                                    string @instanceInterruptionBehavior = null,
                                    string @maxPrice = null,
                                    string @spotInstanceType = null)
                {
                    @BlockDurationMinutes = @blockDurationMinutes;
                    @InstanceInterruptionBehavior = @instanceInterruptionBehavior;
                    @MaxPrice = @maxPrice;
                    @SpotInstanceType = @spotInstanceType;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "block_duration_minutes", @out: false, min: 0, max: 1)]
                public int? @BlockDurationMinutes { get; }

                [nterraform.TerraformProperty(name: "instance_interruption_behavior", @out: false, min: 0, max: 1)]
                public string @InstanceInterruptionBehavior { get; }

                [nterraform.TerraformProperty(name: "max_price", @out: false, min: 0, max: 1)]
                public string @MaxPrice { get; }

                [nterraform.TerraformProperty(name: "spot_instance_type", @out: false, min: 0, max: 1)]
                public string @SpotInstanceType { get; }

                [nterraform.TerraformProperty(name: "valid_until", @out: true, min: 0, max: 1)]
                public string @ValidUntil { get; }
            }

            public instance_market_options(string @marketType = null,
                                           spot_options[] @spotOptions = null)
            {
                @MarketType = @marketType;
                @SpotOptions = @spotOptions;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "market_type", @out: false, min: 0, max: 1)]
            public string @MarketType { get; }

            [nterraform.TerraformProperty(name: "spot_options", @out: false, min: 0, max: 1)]
            public spot_options[] @SpotOptions { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "elastic_gpu_specifications")]
        public sealed class elastic_gpu_specifications : nterraform.structure
        {
            public elastic_gpu_specifications(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
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

        [nterraform.TerraformStructure(category: "resource", typeName: "network_interfaces")]
        public sealed class network_interfaces : nterraform.structure
        {
            public network_interfaces(bool? @associatePublicIpAddress = null,
                                      bool? @deleteOnTermination = null,
                                      string @description = null,
                                      int? @deviceIndex = null,
                                      string[] @ipv4Addresses = null,
                                      string[] @ipv6Addresses = null,
                                      string @networkInterfaceId = null,
                                      string @privateIpAddress = null,
                                      string[] @securityGroups = null,
                                      string @subnetId = null)
            {
                @AssociatePublicIpAddress = @associatePublicIpAddress;
                @DeleteOnTermination = @deleteOnTermination;
                @Description = @description;
                @DeviceIndex = @deviceIndex;
                @Ipv4Addresses = @ipv4Addresses;
                @Ipv6Addresses = @ipv6Addresses;
                @NetworkInterfaceId = @networkInterfaceId;
                @PrivateIpAddress = @privateIpAddress;
                @SecurityGroups = @securityGroups;
                @SubnetId = @subnetId;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "associate_public_ip_address", @out: false, min: 0, max: 1)]
            public bool? @AssociatePublicIpAddress { get; }

            [nterraform.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.TerraformProperty(name: "device_index", @out: false, min: 0, max: 1)]
            public int? @DeviceIndex { get; }

            [nterraform.TerraformProperty(name: "ipv4_address_count", @out: true, min: 0, max: 1)]
            public int? @Ipv4AddressCount { get; }

            [nterraform.TerraformProperty(name: "ipv4_addresses", @out: false, min: 0, max: 1)]
            public string[] @Ipv4Addresses { get; }

            [nterraform.TerraformProperty(name: "ipv6_address_count", @out: true, min: 0, max: 1)]
            public int? @Ipv6AddressCount { get; }

            [nterraform.TerraformProperty(name: "ipv6_addresses", @out: false, min: 0, max: 1)]
            public string[] @Ipv6Addresses { get; }

            [nterraform.TerraformProperty(name: "network_interface_id", @out: false, min: 0, max: 1)]
            public string @NetworkInterfaceId { get; }

            [nterraform.TerraformProperty(name: "private_ip_address", @out: false, min: 0, max: 1)]
            public string @PrivateIpAddress { get; }

            [nterraform.TerraformProperty(name: "security_groups", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroups { get; }

            [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "monitoring")]
        public sealed class monitoring : nterraform.structure
        {
            public monitoring(bool? @enabled = null)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "tag_specifications")]
        public sealed class tag_specifications : nterraform.structure
        {
            public tag_specifications(string @resourceType = null,
                                      Dictionary<string,string> @tags = null)
            {
                @ResourceType = @resourceType;
                @Tags = @tags;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "resource_type", @out: false, min: 0, max: 1)]
            public string @ResourceType { get; }

            [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Tags { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "placement")]
        public sealed class placement : nterraform.structure
        {
            public placement(string @affinity = null,
                             string @availabilityZone = null,
                             string @groupName = null,
                             string @hostId = null,
                             string @spreadDomain = null,
                             string @tenancy = null)
            {
                @Affinity = @affinity;
                @AvailabilityZone = @availabilityZone;
                @GroupName = @groupName;
                @HostId = @hostId;
                @SpreadDomain = @spreadDomain;
                @Tenancy = @tenancy;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "affinity", @out: false, min: 0, max: 1)]
            public string @Affinity { get; }

            [nterraform.TerraformProperty(name: "availability_zone", @out: false, min: 0, max: 1)]
            public string @AvailabilityZone { get; }

            [nterraform.TerraformProperty(name: "group_name", @out: false, min: 0, max: 1)]
            public string @GroupName { get; }

            [nterraform.TerraformProperty(name: "host_id", @out: false, min: 0, max: 1)]
            public string @HostId { get; }

            [nterraform.TerraformProperty(name: "spread_domain", @out: false, min: 0, max: 1)]
            public string @SpreadDomain { get; }

            [nterraform.TerraformProperty(name: "tenancy", @out: false, min: 0, max: 1)]
            public string @Tenancy { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "block_device_mappings")]
        public sealed class block_device_mappings : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "ebs")]
            public sealed class ebs : nterraform.structure
            {
                public ebs(bool? @deleteOnTermination = null,
                           bool? @encrypted = null,
                           string @kmsKeyId = null,
                           string @snapshotId = null)
                {
                    @DeleteOnTermination = @deleteOnTermination;
                    @Encrypted = @encrypted;
                    @KmsKeyId = @kmsKeyId;
                    @SnapshotId = @snapshotId;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
                public bool? @DeleteOnTermination { get; }

                [nterraform.TerraformProperty(name: "encrypted", @out: false, min: 0, max: 1)]
                public bool? @Encrypted { get; }

                [nterraform.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
                public int? @Iops { get; }

                [nterraform.TerraformProperty(name: "kms_key_id", @out: false, min: 0, max: 1)]
                public string @KmsKeyId { get; }

                [nterraform.TerraformProperty(name: "snapshot_id", @out: false, min: 0, max: 1)]
                public string @SnapshotId { get; }

                [nterraform.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
                public int? @VolumeSize { get; }

                [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
                public string @VolumeType { get; }
            }

            public block_device_mappings(string @deviceName = null,
                                         ebs[] @ebs = null,
                                         string @noDevice = null,
                                         string @virtualName = null)
            {
                @DeviceName = @deviceName;
                @Ebs = @ebs;
                @NoDevice = @noDevice;
                @VirtualName = @virtualName;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "device_name", @out: false, min: 0, max: 1)]
            public string @DeviceName { get; }

            [nterraform.TerraformProperty(name: "ebs", @out: false, min: 0, max: 1)]
            public ebs[] @Ebs { get; }

            [nterraform.TerraformProperty(name: "no_device", @out: false, min: 0, max: 1)]
            public string @NoDevice { get; }

            [nterraform.TerraformProperty(name: "virtual_name", @out: false, min: 0, max: 1)]
            public string @VirtualName { get; }
        }

        public aws_launch_template(block_device_mappings[] @blockDeviceMappings = null,
                                   credit_specification[] @creditSpecification = null,
                                   string @description = null,
                                   bool? @disableApiTermination = null,
                                   bool? @ebsOptimized = null,
                                   elastic_gpu_specifications[] @elasticGpuSpecifications = null,
                                   iam_instance_profile[] @iamInstanceProfile = null,
                                   string @imageId = null,
                                   string @instanceInitiatedShutdownBehavior = null,
                                   instance_market_options[] @instanceMarketOptions = null,
                                   string @instanceType = null,
                                   string @kernelId = null,
                                   string @keyName = null,
                                   monitoring[] @monitoring = null,
                                   string @namePrefix = null,
                                   network_interfaces[] @networkInterfaces = null,
                                   placement[] @placement = null,
                                   string @ramDiskId = null,
                                   string[] @securityGroupNames = null,
                                   tag_specifications[] @tagSpecifications = null,
                                   Dictionary<string,string> @tags = null,
                                   string @userData = null,
                                   string[] @vpcSecurityGroupIds = null)
        {
            @BlockDeviceMappings = @blockDeviceMappings;
            @CreditSpecification = @creditSpecification;
            @Description = @description;
            @DisableApiTermination = @disableApiTermination;
            @EbsOptimized = @ebsOptimized;
            @ElasticGpuSpecifications = @elasticGpuSpecifications;
            @IamInstanceProfile = @iamInstanceProfile;
            @ImageId = @imageId;
            @InstanceInitiatedShutdownBehavior = @instanceInitiatedShutdownBehavior;
            @InstanceMarketOptions = @instanceMarketOptions;
            @InstanceType = @instanceType;
            @KernelId = @kernelId;
            @KeyName = @keyName;
            @Monitoring = @monitoring;
            @NamePrefix = @namePrefix;
            @NetworkInterfaces = @networkInterfaces;
            @Placement = @placement;
            @RamDiskId = @ramDiskId;
            @SecurityGroupNames = @securityGroupNames;
            @TagSpecifications = @tagSpecifications;
            @Tags = @tags;
            @UserData = @userData;
            @VpcSecurityGroupIds = @vpcSecurityGroupIds;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "block_device_mappings", @out: false, min: 0, max: 0)]
        public block_device_mappings[] @BlockDeviceMappings { get; }

        [nterraform.TerraformProperty(name: "credit_specification", @out: false, min: 0, max: 1)]
        public credit_specification[] @CreditSpecification { get; }

        [nterraform.TerraformProperty(name: "default_version", @out: true, min: 0, max: 1)]
        public int? @DefaultVersion { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "disable_api_termination", @out: false, min: 0, max: 1)]
        public bool? @DisableApiTermination { get; }

        [nterraform.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.TerraformProperty(name: "elastic_gpu_specifications", @out: false, min: 0, max: 0)]
        public elastic_gpu_specifications[] @ElasticGpuSpecifications { get; }

        [nterraform.TerraformProperty(name: "iam_instance_profile", @out: false, min: 0, max: 1)]
        public iam_instance_profile[] @IamInstanceProfile { get; }

        [nterraform.TerraformProperty(name: "image_id", @out: false, min: 0, max: 1)]
        public string @ImageId { get; }

        [nterraform.TerraformProperty(name: "instance_initiated_shutdown_behavior", @out: false, min: 0, max: 1)]
        public string @InstanceInitiatedShutdownBehavior { get; }

        [nterraform.TerraformProperty(name: "instance_market_options", @out: false, min: 0, max: 1)]
        public instance_market_options[] @InstanceMarketOptions { get; }

        [nterraform.TerraformProperty(name: "instance_type", @out: false, min: 0, max: 1)]
        public string @InstanceType { get; }

        [nterraform.TerraformProperty(name: "kernel_id", @out: false, min: 0, max: 1)]
        public string @KernelId { get; }

        [nterraform.TerraformProperty(name: "key_name", @out: false, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.TerraformProperty(name: "latest_version", @out: true, min: 0, max: 1)]
        public int? @LatestVersion { get; }

        [nterraform.TerraformProperty(name: "monitoring", @out: false, min: 0, max: 1)]
        public monitoring[] @Monitoring { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "network_interfaces", @out: false, min: 0, max: 0)]
        public network_interfaces[] @NetworkInterfaces { get; }

        [nterraform.TerraformProperty(name: "placement", @out: false, min: 0, max: 1)]
        public placement[] @Placement { get; }

        [nterraform.TerraformProperty(name: "ram_disk_id", @out: false, min: 0, max: 1)]
        public string @RamDiskId { get; }

        [nterraform.TerraformProperty(name: "security_group_names", @out: false, min: 0, max: 1)]
        public string[] @SecurityGroupNames { get; }

        [nterraform.TerraformProperty(name: "tag_specifications", @out: false, min: 0, max: 0)]
        public tag_specifications[] @TagSpecifications { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "user_data", @out: false, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.TerraformProperty(name: "vpc_security_group_ids", @out: false, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
