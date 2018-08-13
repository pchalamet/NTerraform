using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_launch_configuration")]
    public sealed class aws_launch_configuration : nterraform.data
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

            [nterraform.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "ephemeral_block_device")]
        public sealed class ephemeral_block_device : nterraform.structure
        {
            public ephemeral_block_device()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "device_name", @out: true, min: 0, max: 1)]
            public string @DeviceName { get; }

            [nterraform.TerraformProperty(name: "virtual_name", @out: true, min: 0, max: 1)]
            public string @VirtualName { get; }
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

            [nterraform.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        public aws_launch_configuration(string @name,
                                        ebs_block_device[] @ebsBlockDevice = null,
                                        ephemeral_block_device[] @ephemeralBlockDevice = null,
                                        root_block_device[] @rootBlockDevice = null)
        {
            @Name = @name;
            @EbsBlockDevice = @ebsBlockDevice;
            @EphemeralBlockDevice = @ephemeralBlockDevice;
            @RootBlockDevice = @rootBlockDevice;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "associate_public_ip_address", @out: true, min: 0, max: 1)]
        public bool? @AssociatePublicIpAddress { get; }

        [nterraform.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.TerraformProperty(name: "ebs_optimized", @out: true, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.TerraformProperty(name: "enable_monitoring", @out: true, min: 0, max: 1)]
        public bool? @EnableMonitoring { get; }

        [nterraform.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.TerraformProperty(name: "iam_instance_profile", @out: true, min: 0, max: 1)]
        public string @IamInstanceProfile { get; }

        [nterraform.TerraformProperty(name: "image_id", @out: true, min: 0, max: 1)]
        public string @ImageId { get; }

        [nterraform.TerraformProperty(name: "instance_type", @out: true, min: 0, max: 1)]
        public string @InstanceType { get; }

        [nterraform.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.TerraformProperty(name: "placement_tenancy", @out: true, min: 0, max: 1)]
        public string @PlacementTenancy { get; }

        [nterraform.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 0)]
        public root_block_device[] @RootBlockDevice { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "spot_price", @out: true, min: 0, max: 1)]
        public string @SpotPrice { get; }

        [nterraform.TerraformProperty(name: "user_data", @out: true, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.TerraformProperty(name: "vpc_classic_link_id", @out: true, min: 0, max: 1)]
        public string @VpcClassicLinkId { get; }

        [nterraform.TerraformProperty(name: "vpc_classic_link_security_groups", @out: true, min: 0, max: 1)]
        public string[] @VpcClassicLinkSecurityGroups { get; }
    }

}
