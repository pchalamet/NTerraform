using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_image")]
    public sealed class azurerm_image : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "data_disk")]
        public sealed class data_disk: NTerraform.structure
        {
            public data_disk(string @caching = null,
                             int? @lun = null,
                             string @managedDiskId = null)
            {
                @Caching = @caching;
                @Lun = @lun;
                @ManagedDiskId = @managedDiskId;
                base._validate_();
            }

            [TerraformProperty(name: "blob_uri", @out: true, min: 0, max: 1)]
            public string @BlobUri { get; }

            [TerraformProperty(name: "caching", @out: false, min: 0, max: 1)]
            public string @Caching { get; }

            [TerraformProperty(name: "lun", @out: false, min: 0, max: 1)]
            public int? @Lun { get; }

            [TerraformProperty(name: "managed_disk_id", @out: false, min: 0, max: 1)]
            public string @ManagedDiskId { get; }

            [TerraformProperty(name: "size_gb", @out: true, min: 0, max: 1)]
            public int? @SizeGb { get; }
        }

        [TerraformStructure(category: "", typeName: "os_disk")]
        public sealed class os_disk: NTerraform.structure
        {
            public os_disk(string @caching = null,
                           string @osState = null,
                           string @osType = null)
            {
                @Caching = @caching;
                @OsState = @osState;
                @OsType = @osType;
                base._validate_();
            }

            [TerraformProperty(name: "blob_uri", @out: true, min: 0, max: 1)]
            public string @BlobUri { get; }

            [TerraformProperty(name: "caching", @out: false, min: 0, max: 1)]
            public string @Caching { get; }

            [TerraformProperty(name: "managed_disk_id", @out: true, min: 0, max: 1)]
            public string @ManagedDiskId { get; }

            [TerraformProperty(name: "os_state", @out: false, min: 0, max: 1)]
            public string @OsState { get; }

            [TerraformProperty(name: "os_type", @out: false, min: 0, max: 1)]
            public string @OsType { get; }

            [TerraformProperty(name: "size_gb", @out: true, min: 0, max: 1)]
            public int? @SizeGb { get; }
        }

        public azurerm_image(string @location,
                             string @name,
                             string @resourceGroupName,
                             data_disk[] @dataDisk = null,
                             os_disk[] @osDisk = null,
                             string @sourceVirtualMachineId = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @DataDisk = @dataDisk;
            @OsDisk = @osDisk;
            @SourceVirtualMachineId = @sourceVirtualMachineId;
            base._validate_();
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "data_disk", @out: false, min: 0, max: 0)]
        public data_disk[] @DataDisk { get; }

        [TerraformProperty(name: "os_disk", @out: false, min: 0, max: 1)]
        public os_disk[] @OsDisk { get; }

        [TerraformProperty(name: "source_virtual_machine_id", @out: false, min: 0, max: 1)]
        public string @SourceVirtualMachineId { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
