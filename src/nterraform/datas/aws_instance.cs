using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_instance")]
    public sealed class aws_instance : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "root_block_device")]
        public sealed class root_block_device : nterraform.structure
        {
            public root_block_device()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "delete_on_termination", @out: true, min: 0, max: 1)]
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

        [nterraform.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "ebs_block_device")]
        public sealed class ebs_block_device : nterraform.structure
        {
            public ebs_block_device()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "delete_on_termination", @out: true, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.TerraformProperty(name: "device_name", @out: true, min: 0, max: 1)]
            public string @DeviceName { get; }

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

        [nterraform.TerraformStructure(category: "data", typeName: "credit_specification")]
        public sealed class credit_specification : nterraform.structure
        {
            public credit_specification()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cpu_credits", @out: true, min: 0, max: 1)]
            public string @CpuCredits { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "ephemeral_block_device")]
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

        [nterraform.TerraformProperty(name: "ami", @out: true, min: 0, max: 1)]
        public string @Ami { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "associate_public_ip_address", @out: true, min: 0, max: 1)]
        public bool? @AssociatePublicIpAddress { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "credit_specification", @out: false, min: 0, max: 0)]
        public credit_specification[] @CreditSpecification { get; }

        [nterraform.TerraformProperty(name: "disable_api_termination", @out: true, min: 0, max: 1)]
        public bool? @DisableApiTermination { get; }

        [nterraform.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.TerraformProperty(name: "ebs_optimized", @out: true, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "get_password_data", @out: false, min: 0, max: 1)]
        public bool? @GetPasswordData { get; }

        [nterraform.TerraformProperty(name: "iam_instance_profile", @out: true, min: 0, max: 1)]
        public string @IamInstanceProfile { get; }

        [nterraform.TerraformProperty(name: "instance_id", @out: false, min: 0, max: 1)]
        public string @InstanceId { get; }

        [nterraform.TerraformProperty(name: "instance_state", @out: true, min: 0, max: 1)]
        public string @InstanceState { get; }

        [nterraform.TerraformProperty(name: "instance_tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @InstanceTags { get; }

        [nterraform.TerraformProperty(name: "instance_type", @out: true, min: 0, max: 1)]
        public string @InstanceType { get; }

        [nterraform.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.TerraformProperty(name: "monitoring", @out: true, min: 0, max: 1)]
        public bool? @Monitoring { get; }

        [nterraform.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "password_data", @out: true, min: 0, max: 1)]
        public string @PasswordData { get; }

        [nterraform.TerraformProperty(name: "placement_group", @out: true, min: 0, max: 1)]
        public string @PlacementGroup { get; }

        [nterraform.TerraformProperty(name: "private_dns", @out: true, min: 0, max: 1)]
        public string @PrivateDns { get; }

        [nterraform.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.TerraformProperty(name: "public_dns", @out: true, min: 0, max: 1)]
        public string @PublicDns { get; }

        [nterraform.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
        public string @PublicIp { get; }

        [nterraform.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 0)]
        public root_block_device[] @RootBlockDevice { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "source_dest_check", @out: true, min: 0, max: 1)]
        public bool? @SourceDestCheck { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "tenancy", @out: true, min: 0, max: 1)]
        public string @Tenancy { get; }

        [nterraform.TerraformProperty(name: "user_data", @out: true, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.TerraformProperty(name: "vpc_security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @VpcSecurityGroupIds { get; }
    }

}
