using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ami")]
    public sealed class aws_ami : nterraform.Core.resource
    {
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

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ebs_block_device")]
        public sealed class ebs_block_device : nterraform.Core.structure
        {
            public ebs_block_device(string @deviceName,
                                    bool? @deleteOnTermination = null,
                                    bool? @encrypted = null,
                                    int? @iops = null,
                                    string @snapshotId = null,
                                    string @volumeType = null)
            {
                @DeviceName = @deviceName;
                @DeleteOnTermination = @deleteOnTermination;
                @Encrypted = @encrypted;
                @Iops = @iops;
                @SnapshotId = @snapshotId;
                @VolumeType = @volumeType;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "device_name", @out: false, min: 1, max: 1)]
            public string @DeviceName { get; }

            [nterraform.Core.TerraformProperty(name: "delete_on_termination", @out: false, min: 0, max: 1)]
            public bool? @DeleteOnTermination { get; }

            [nterraform.Core.TerraformProperty(name: "encrypted", @out: false, min: 0, max: 1)]
            public bool? @Encrypted { get; }

            [nterraform.Core.TerraformProperty(name: "iops", @out: false, min: 0, max: 1)]
            public int? @Iops { get; }

            [nterraform.Core.TerraformProperty(name: "snapshot_id", @out: false, min: 0, max: 1)]
            public string @SnapshotId { get; }

            [nterraform.Core.TerraformProperty(name: "volume_size", @out: true, min: 0, max: 1)]
            public int? @VolumeSize { get; }

            [nterraform.Core.TerraformProperty(name: "volume_type", @out: false, min: 0, max: 1)]
            public string @VolumeType { get; }
        }

        public aws_ami(string @name,
                       string @architecture = null,
                       string @description = null,
                       ebs_block_device[] @ebsBlockDevice = null,
                       bool? @enaSupport = null,
                       ephemeral_block_device[] @ephemeralBlockDevice = null,
                       string @kernelId = null,
                       string @ramdiskId = null,
                       string @rootDeviceName = null,
                       string @sriovNetSupport = null,
                       Dictionary<string,string> @tags = null,
                       string @virtualizationType = null)
        {
            @Name = @name;
            @Architecture = @architecture;
            @Description = @description;
            @EbsBlockDevice = @ebsBlockDevice;
            @EnaSupport = @enaSupport;
            @EphemeralBlockDevice = @ephemeralBlockDevice;
            @KernelId = @kernelId;
            @RamdiskId = @ramdiskId;
            @RootDeviceName = @rootDeviceName;
            @SriovNetSupport = @sriovNetSupport;
            @Tags = @tags;
            @VirtualizationType = @virtualizationType;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "architecture", @out: false, min: 0, max: 1)]
        public string @Architecture { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "ena_support", @out: false, min: 0, max: 1)]
        public bool? @EnaSupport { get; }

        [nterraform.Core.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.Core.TerraformProperty(name: "image_location", @out: true, min: 0, max: 1)]
        public string @ImageLocation { get; }

        [nterraform.Core.TerraformProperty(name: "kernel_id", @out: false, min: 0, max: 1)]
        public string @KernelId { get; }

        [nterraform.Core.TerraformProperty(name: "manage_ebs_snapshots", @out: true, min: 0, max: 1)]
        public bool? @ManageEbsSnapshots { get; }

        [nterraform.Core.TerraformProperty(name: "ramdisk_id", @out: false, min: 0, max: 1)]
        public string @RamdiskId { get; }

        [nterraform.Core.TerraformProperty(name: "root_device_name", @out: false, min: 0, max: 1)]
        public string @RootDeviceName { get; }

        [nterraform.Core.TerraformProperty(name: "root_snapshot_id", @out: true, min: 0, max: 1)]
        public string @RootSnapshotId { get; }

        [nterraform.Core.TerraformProperty(name: "sriov_net_support", @out: false, min: 0, max: 1)]
        public string @SriovNetSupport { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "virtualization_type", @out: false, min: 0, max: 1)]
        public string @VirtualizationType { get; }
    }

}
