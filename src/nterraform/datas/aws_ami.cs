using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_ami")]
    public sealed class aws_ami : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "product_codes")]
        public sealed class product_codes : nterraform.structure
        {
            public product_codes()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "product_code_id", @out: true, min: 0, max: 1)]
            public string @ProductCodeId { get; }

            [nterraform.TerraformProperty(name: "product_code_type", @out: true, min: 0, max: 1)]
            public string @ProductCodeType { get; }
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

        [nterraform.TerraformStructure(category: "data", typeName: "block_device_mappings")]
        public sealed class block_device_mappings : nterraform.structure
        {
            public block_device_mappings()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "device_name", @out: true, min: 0, max: 1)]
            public string @DeviceName { get; }

            [nterraform.TerraformProperty(name: "ebs", @out: true, min: 0, max: 1)]
            public Dictionary<string,string> @Ebs { get; }

            [nterraform.TerraformProperty(name: "no_device", @out: true, min: 0, max: 1)]
            public string @NoDevice { get; }

            [nterraform.TerraformProperty(name: "virtual_name", @out: true, min: 0, max: 1)]
            public string @VirtualName { get; }
        }

        public aws_ami(block_device_mappings[] @blockDeviceMappings = null,
                       string[] @executableUsers = null,
                       filter[] @filter = null,
                       bool? @mostRecent = null,
                       string @nameRegex = null,
                       string[] @owners = null,
                       product_codes[] @productCodes = null)
        {
            @BlockDeviceMappings = @blockDeviceMappings;
            @ExecutableUsers = @executableUsers;
            @Filter = @filter;
            @MostRecent = @mostRecent;
            @NameRegex = @nameRegex;
            @Owners = @owners;
            @ProductCodes = @productCodes;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "architecture", @out: true, min: 0, max: 1)]
        public string @Architecture { get; }

        [nterraform.TerraformProperty(name: "block_device_mappings", @out: false, min: 0, max: 0)]
        public block_device_mappings[] @BlockDeviceMappings { get; }

        [nterraform.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "executable_users", @out: false, min: 0, max: 1)]
        public string[] @ExecutableUsers { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "hypervisor", @out: true, min: 0, max: 1)]
        public string @Hypervisor { get; }

        [nterraform.TerraformProperty(name: "image_id", @out: true, min: 0, max: 1)]
        public string @ImageId { get; }

        [nterraform.TerraformProperty(name: "image_location", @out: true, min: 0, max: 1)]
        public string @ImageLocation { get; }

        [nterraform.TerraformProperty(name: "image_owner_alias", @out: true, min: 0, max: 1)]
        public string @ImageOwnerAlias { get; }

        [nterraform.TerraformProperty(name: "image_type", @out: true, min: 0, max: 1)]
        public string @ImageType { get; }

        [nterraform.TerraformProperty(name: "kernel_id", @out: true, min: 0, max: 1)]
        public string @KernelId { get; }

        [nterraform.TerraformProperty(name: "most_recent", @out: false, min: 0, max: 1)]
        public bool? @MostRecent { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_regex", @out: false, min: 0, max: 1)]
        public string @NameRegex { get; }

        [nterraform.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.TerraformProperty(name: "owners", @out: false, min: 0, max: 1)]
        public string[] @Owners { get; }

        [nterraform.TerraformProperty(name: "platform", @out: true, min: 0, max: 1)]
        public string @Platform { get; }

        [nterraform.TerraformProperty(name: "product_codes", @out: false, min: 0, max: 0)]
        public product_codes[] @ProductCodes { get; }

        [nterraform.TerraformProperty(name: "public", @out: true, min: 0, max: 1)]
        public bool? @Public { get; }

        [nterraform.TerraformProperty(name: "ramdisk_id", @out: true, min: 0, max: 1)]
        public string @RamdiskId { get; }

        [nterraform.TerraformProperty(name: "root_device_name", @out: true, min: 0, max: 1)]
        public string @RootDeviceName { get; }

        [nterraform.TerraformProperty(name: "root_device_type", @out: true, min: 0, max: 1)]
        public string @RootDeviceType { get; }

        [nterraform.TerraformProperty(name: "root_snapshot_id", @out: true, min: 0, max: 1)]
        public string @RootSnapshotId { get; }

        [nterraform.TerraformProperty(name: "sriov_net_support", @out: true, min: 0, max: 1)]
        public string @SriovNetSupport { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "state_reason", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @StateReason { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "virtualization_type", @out: true, min: 0, max: 1)]
        public string @VirtualizationType { get; }
    }

}
