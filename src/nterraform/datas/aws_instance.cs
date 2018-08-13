using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_instance")]
    public sealed class aws_instance : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "ephemeral_block_device")]
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

        [nterraform.Core.TerraformStructure(category: "data", typeName: "root_block_device")]
        public sealed class root_block_device : nterraform.Core.structure
        {
            public root_block_device()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: true, min: 0, max: 1)]
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

        [nterraform.Core.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "ebs_block_device")]
        public sealed class ebs_block_device : nterraform.Core.structure
        {
            public ebs_block_device()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: true, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.Core.TerraformProperty(name: "device_name", @out: true, min: 0, max: 1)]
            public string @DeviceName { get; }

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

        [nterraform.Core.TerraformStructure(category: "data", typeName: "credit_specification")]
        public sealed class credit_specification : nterraform.Core.structure
        {
            public credit_specification()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "cpu_credits", @out: true, min: 0, max: 1)]
            public string @CpuCredits { get; }
        }

        public aws_instance(credit_specification[] @creditSpecification = null,
                            ebs_block_device[] @ebsBlockDevice = null,
                            ephemeral_block_device[] @ephemeralBlockDevice = null,
                            filter[] @filter = null,
                            bool? @getPasswordData = null,
                            string @instanceId = null,
                            root_block_device[] @rootBlockDevice = null)
        {
            @CreditSpecification = @creditSpecification;
            @EbsBlockDevice = @ebsBlockDevice;
            @EphemeralBlockDevice = @ephemeralBlockDevice;
            @Filter = @filter;
            @GetPasswordData = @getPasswordData;
            @InstanceId = @instanceId;
            @RootBlockDevice = @rootBlockDevice;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "ami", @out: true, min: 0, max: 1)]
        public string @Ami { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "associate_public_ip_address", @out: true, min: 0, max: 1)]
        public bool? @AssociatePublicIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "credit_specification", @out: false, min: 0, max: 0)]
        public credit_specification[] @CreditSpecification { get; }

        [nterraform.Core.TerraformProperty(name: "disable_api_termination", @out: true, min: 0, max: 1)]
        public bool? @DisableApiTermination { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_optimized", @out: true, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.Core.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "get_password_data", @out: false, min: 0, max: 1)]
        public bool? @GetPasswordData { get; }

        [nterraform.Core.TerraformProperty(name: "iam_instance_profile", @out: true, min: 0, max: 1)]
        public string @IamInstanceProfile { get; }

        [nterraform.Core.TerraformProperty(name: "instance_id", @out: false, min: 0, max: 1)]
        public string @InstanceId { get; }

        [nterraform.Core.TerraformProperty(name: "instance_state", @out: true, min: 0, max: 1)]
        public string @InstanceState { get; }

        [nterraform.Core.TerraformProperty(name: "instance_tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @InstanceTags { get; }

        [nterraform.Core.TerraformProperty(name: "instance_type", @out: true, min: 0, max: 1)]
        public string @InstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.Core.TerraformProperty(name: "monitoring", @out: true, min: 0, max: 1)]
        public bool? @Monitoring { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "password_data", @out: true, min: 0, max: 1)]
        public string @PasswordData { get; }

        [nterraform.Core.TerraformProperty(name: "placement_group", @out: true, min: 0, max: 1)]
        public string @PlacementGroup { get; }

        [nterraform.Core.TerraformProperty(name: "private_dns", @out: true, min: 0, max: 1)]
        public string @PrivateDns { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.Core.TerraformProperty(name: "public_dns", @out: true, min: 0, max: 1)]
        public string @PublicDns { get; }

        [nterraform.Core.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }

        [nterraform.Core.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 0)]
        public root_block_device[] @RootBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "source_dest_check", @out: true, min: 0, max: 1)]
        public bool? @SourceDestCheck { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "tenancy", @out: true, min: 0, max: 1)]
        public string @Tenancy { get; }

        [nterraform.Core.TerraformProperty(name: "user_data", @out: true, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
