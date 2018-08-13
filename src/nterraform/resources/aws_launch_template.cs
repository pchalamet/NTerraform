using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_launch_template")]
    public sealed class aws_launch_template : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "tag_specifications")]
        public sealed class tag_specifications : nterraform.Core.structure
        {
            public tag_specifications(string @resourceType = null,
                                      Dictionary<string,string> @tags = null)
            {
                @ResourceType = @resourceType;
                @Tags = @tags;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "resource_type", @out: false, min: 0, max: 1)]
            public string @ResourceType { get; }

            [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Tags { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "iam_instance_profile")]
        public sealed class iam_instance_profile : nterraform.Core.structure
        {
            public iam_instance_profile(string @arn = null,
                                        string @name = null)
            {
                @Arn = @arn;
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "arn", @out: false, min: 0, max: 1)]
            public string @Arn { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "network_interfaces")]
        public sealed class network_interfaces : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "associate_public_ip_address", @out: false, min: 0, max: 1)]
            public bool? @AssociatePublicIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
            public string @Description { get; }

            [nterraform.Core.TerraformProperty(name: "device_index", @out: false, min: 0, max: 1)]
            public int? @DeviceIndex { get; }

            [nterraform.Core.TerraformProperty(name: "ipv4_address_count", @out: true, min: 0, max: 1)]
            public int? @Ipv4AddressCount { get; }

            [nterraform.Core.TerraformProperty(name: "ipv4_addresses", @out: false, min: 0, max: 1)]
            public string[] @Ipv4Addresses { get; }

            [nterraform.Core.TerraformProperty(name: "ipv6_address_count", @out: true, min: 0, max: 1)]
            public int? @Ipv6AddressCount { get; }

            [nterraform.Core.TerraformProperty(name: "ipv6_addresses", @out: false, min: 0, max: 1)]
            public string[] @Ipv6Addresses { get; }

            [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: false, min: 0, max: 1)]
            public string @NetworkInterfaceId { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address", @out: false, min: 0, max: 1)]
            public string @PrivateIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "security_groups", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroups { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "placement")]
        public sealed class placement : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "affinity", @out: false, min: 0, max: 1)]
            public string @Affinity { get; }

            [nterraform.Core.TerraformProperty(name: "availability_zone", @out: false, min: 0, max: 1)]
            public string @AvailabilityZone { get; }

            [nterraform.Core.TerraformProperty(name: "group_name", @out: false, min: 0, max: 1)]
            public string @GroupName { get; }

            [nterraform.Core.TerraformProperty(name: "host_id", @out: false, min: 0, max: 1)]
            public string @HostId { get; }

            [nterraform.Core.TerraformProperty(name: "spread_domain", @out: false, min: 0, max: 1)]
            public string @SpreadDomain { get; }

            [nterraform.Core.TerraformProperty(name: "tenancy", @out: false, min: 0, max: 1)]
            public string @Tenancy { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "instance_market_options")]
        public sealed class instance_market_options : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "spot_options")]
            public sealed class spot_options : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "block_duration_minutes", @out: false, min: 0, max: 1)]
                public int? @BlockDurationMinutes { get; }

                [nterraform.Core.TerraformProperty(name: "instance_interruption_behavior", @out: false, min: 0, max: 1)]
                public string @InstanceInterruptionBehavior { get; }

                [nterraform.Core.TerraformProperty(name: "max_price", @out: false, min: 0, max: 1)]
                public string @MaxPrice { get; }

                [nterraform.Core.TerraformProperty(name: "spot_instance_type", @out: false, min: 0, max: 1)]
                public string @SpotInstanceType { get; }

                [nterraform.Core.TerraformProperty(name: "valid_until", @out: true, min: 0, max: 1)]
                public string @ValidUntil { get; }
            }

            public instance_market_options(string @marketType = null,
                                           spot_options[] @spotOptions = null)
            {
                @MarketType = @marketType;
                @SpotOptions = @spotOptions;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "market_type", @out: false, min: 0, max: 1)]
            public string @MarketType { get; }

            [nterraform.Core.TerraformProperty(name: "spot_options", @out: false, min: 0, max: 1)]
            public spot_options[] @SpotOptions { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "block_device_mappings")]
        public sealed class block_device_mappings : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ebs")]
            public sealed class ebs : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
                public bool? @DeleteOnTermination { get; }

                [nterraform.Core.TerraformProperty(name: "encrypted", @out: false, min: 0, max: 1)]
                public bool? @Encrypted { get; }

                [nterraform.Core.TerraformProperty(name: "iops", @out: true, min: 0, max: 1)]
                public int? @Iops { get; }

                [nterraform.Core.TerraformProperty(name: "kms_key_id", @out: false, min: 0, max: 1)]
                public string @KmsKeyId { get; }

                [nterraform.Core.TerraformProperty(name: "snapshot_id", @out: false, min: 0, max: 1)]
                public string @SnapshotId { get; }

                [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
                public int? @VolumeSize { get; }

                [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
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

            [nterraform.Core.TerraformProperty(name: "device_name", @out: false, min: 0, max: 1)]
            public string @DeviceName { get; }

            [nterraform.Core.TerraformProperty(name: "ebs", @out: false, min: 0, max: 1)]
            public ebs[] @Ebs { get; }

            [nterraform.Core.TerraformProperty(name: "no_device", @out: false, min: 0, max: 1)]
            public string @NoDevice { get; }

            [nterraform.Core.TerraformProperty(name: "virtual_name", @out: false, min: 0, max: 1)]
            public string @VirtualName { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "monitoring")]
        public sealed class monitoring : nterraform.Core.structure
        {
            public monitoring(bool? @enabled = null)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "elastic_gpu_specifications")]
        public sealed class elastic_gpu_specifications : nterraform.Core.structure
        {
            public elastic_gpu_specifications(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
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

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "block_device_mappings", @out: false, min: 0, max: 0)]
        public block_device_mappings[] @BlockDeviceMappings { get; }

        [nterraform.Core.TerraformProperty(name: "credit_specification", @out: false, min: 0, max: 1)]
        public credit_specification[] @CreditSpecification { get; }

        [nterraform.Core.TerraformProperty(name: "default_version", @out: true, min: 0, max: 1)]
        public int? @DefaultVersion { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "disable_api_termination", @out: false, min: 0, max: 1)]
        public bool? @DisableApiTermination { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_optimized", @out: false, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.Core.TerraformProperty(name: "elastic_gpu_specifications", @out: false, min: 0, max: 0)]
        public elastic_gpu_specifications[] @ElasticGpuSpecifications { get; }

        [nterraform.Core.TerraformProperty(name: "iam_instance_profile", @out: false, min: 0, max: 1)]
        public iam_instance_profile[] @IamInstanceProfile { get; }

        [nterraform.Core.TerraformProperty(name: "image_id", @out: false, min: 0, max: 1)]
        public string @ImageId { get; }

        [nterraform.Core.TerraformProperty(name: "instance_initiated_shutdown_behavior", @out: false, min: 0, max: 1)]
        public string @InstanceInitiatedShutdownBehavior { get; }

        [nterraform.Core.TerraformProperty(name: "instance_market_options", @out: false, min: 0, max: 1)]
        public instance_market_options[] @InstanceMarketOptions { get; }

        [nterraform.Core.TerraformProperty(name: "instance_type", @out: false, min: 0, max: 1)]
        public string @InstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "kernel_id", @out: false, min: 0, max: 1)]
        public string @KernelId { get; }

        [nterraform.Core.TerraformProperty(name: "key_name", @out: false, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.Core.TerraformProperty(name: "latest_version", @out: true, min: 0, max: 1)]
        public int? @LatestVersion { get; }

        [nterraform.Core.TerraformProperty(name: "monitoring", @out: false, min: 0, max: 1)]
        public monitoring[] @Monitoring { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "network_interfaces", @out: false, min: 0, max: 0)]
        public network_interfaces[] @NetworkInterfaces { get; }

        [nterraform.Core.TerraformProperty(name: "placement", @out: false, min: 0, max: 1)]
        public placement[] @Placement { get; }

        [nterraform.Core.TerraformProperty(name: "ram_disk_id", @out: false, min: 0, max: 1)]
        public string @RamDiskId { get; }

        [nterraform.Core.TerraformProperty(name: "security_group_names", @out: false, min: 0, max: 1)]
        public string[] @SecurityGroupNames { get; }

        [nterraform.Core.TerraformProperty(name: "tag_specifications", @out: false, min: 0, max: 0)]
        public tag_specifications[] @TagSpecifications { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "user_data", @out: false, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_security_group_ids", @out: false, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
