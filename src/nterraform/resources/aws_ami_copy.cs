using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ami_copy")]
    public sealed class aws_ami_copy : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "ebs_block_device")]
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

        [nterraform.TerraformStructure(category: "resource", typeName: "ephemeral_block_device")]
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

        public aws_ami_copy(string @name,
                            string @sourceAmiId,
                            string @sourceAmiRegion,
                            string @description = null,
                            ebs_block_device[] @ebsBlockDevice = null,
                            bool? @encrypted = null,
                            ephemeral_block_device[] @ephemeralBlockDevice = null,
                            Dictionary<string,string> @tags = null)
        {
            @Name = @name;
            @SourceAmiId = @sourceAmiId;
            @SourceAmiRegion = @sourceAmiRegion;
            @Description = @description;
            @EbsBlockDevice = @ebsBlockDevice;
            @Encrypted = @encrypted;
            @EphemeralBlockDevice = @ephemeralBlockDevice;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "source_ami_id", @out: false, min: 1, max: 1)]
        public string @SourceAmiId { get; }

        [nterraform.TerraformProperty(name: "source_ami_region", @out: false, min: 1, max: 1)]
        public string @SourceAmiRegion { get; }

        [nterraform.TerraformProperty(name: "architecture", @out: true, min: 0, max: 1)]
        public string @Architecture { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "ebs_block_device", @out: false, min: 0, max: 0)]
        public ebs_block_device[] @EbsBlockDevice { get; }

        [nterraform.TerraformProperty(name: "ena_support", @out: true, min: 0, max: 1)]
        public bool? @EnaSupport { get; }

        [nterraform.TerraformProperty(name: "encrypted", @out: false, min: 0, max: 1)]
        public bool? @Encrypted { get; }

        [nterraform.TerraformProperty(name: "ephemeral_block_device", @out: false, min: 0, max: 0)]
        public ephemeral_block_device[] @EphemeralBlockDevice { get; }

        [nterraform.TerraformProperty(name: "image_location", @out: true, min: 0, max: 1)]
        public string @ImageLocation { get; }

        [nterraform.TerraformProperty(name: "kernel_id", @out: true, min: 0, max: 1)]
        public string @KernelId { get; }

        [nterraform.TerraformProperty(name: "kms_key_id", @out: true, min: 0, max: 1)]
        public string @KmsKeyId { get; }

        [nterraform.TerraformProperty(name: "manage_ebs_snapshots", @out: true, min: 0, max: 1)]
        public bool? @ManageEbsSnapshots { get; }

        [nterraform.TerraformProperty(name: "ramdisk_id", @out: true, min: 0, max: 1)]
        public string @RamdiskId { get; }

        [nterraform.TerraformProperty(name: "root_device_name", @out: true, min: 0, max: 1)]
        public string @RootDeviceName { get; }

        [nterraform.TerraformProperty(name: "root_snapshot_id", @out: true, min: 0, max: 1)]
        public string @RootSnapshotId { get; }

        [nterraform.TerraformProperty(name: "sriov_net_support", @out: true, min: 0, max: 1)]
        public string @SriovNetSupport { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "virtualization_type", @out: true, min: 0, max: 1)]
        public string @VirtualizationType { get; }
    }

}
