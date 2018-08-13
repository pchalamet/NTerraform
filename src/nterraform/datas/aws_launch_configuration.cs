using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_launch_configuration")]
    public sealed class aws_launch_configuration : nterraform.Core.data
    {
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

            [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
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

            [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.Core.TerraformProperty(name: "volume_type", @out: true, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "ephemeral_block_device")]
        public sealed class ephemeral_block_device : nterraform.Core.structure
        {
            public ephemeral_block_device()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "device_name", @out: true, min: 0, max: 1)]
            public string @DeviceName { get; }

            [nterraform.Core.TerraformProperty(name: "virtual_name", @out: true, min: 0, max: 1)]
            public string @VirtualName { get; }
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "associate_public_ip_address", @out: true, min: 0, max: 1)]
        public bool? @AssociatePublicIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_optimized", @out: true, min: 0, max: 1)]
        public bool? @EbsOptimized { get; }

        [nterraform.Core.TerraformProperty(name: "enable_monitoring", @out: true, min: 0, max: 1)]
        public bool? @EnableMonitoring { get; }

        [nterraform.Core.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "iam_instance_profile", @out: true, min: 0, max: 1)]
        public string @IamInstanceProfile { get; }

        [nterraform.Core.TerraformProperty(name: "image_id", @out: true, min: 0, max: 1)]
        public string @ImageId { get; }

        [nterraform.Core.TerraformProperty(name: "instance_type", @out: true, min: 0, max: 1)]
        public string @InstanceType { get; }

        [nterraform.Core.TerraformProperty(name: "key_name", @out: true, min: 0, max: 1)]
        public string @KeyName { get; }

        [nterraform.Core.TerraformProperty(name: "placement_tenancy", @out: true, min: 0, max: 1)]
        public string @PlacementTenancy { get; }

        [nterraform.Core.TerraformProperty(name: "root_block_device", @out: false, min: 0, max: 0)]
        public root_block_device[] @RootBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "spot_price", @out: true, min: 0, max: 1)]
        public string @SpotPrice { get; }

        [nterraform.Core.TerraformProperty(name: "user_data", @out: true, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_classic_link_id", @out: true, min: 0, max: 1)]
        public string @VpcClassicLinkId { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_classic_link_security_groups", @out: true, min: 0, max: 1)]
        public string[] @VpcClassicLinkSecurityGroups { get; }
    }

}
