using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_image")]
    public sealed class azurerm_image : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "os_disk")]
        public sealed class os_disk : nterraform.Core.structure
        {
            public os_disk(FSharpOption<string> @caching = null,
                           FSharpOption<string> @osState = null,
                           FSharpOption<string> @osType = null)
            {
                @Caching = @caching;
                @OsState = @osState;
                @OsType = @osType;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "blob_uri", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @BlobUri { get; }

            [nterraform.Core.TerraformProperty(name: "caching", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Caching { get; }

            [nterraform.Core.TerraformProperty(name: "managed_disk_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ManagedDiskId { get; }

            [nterraform.Core.TerraformProperty(name: "os_state", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @OsState { get; }

            [nterraform.Core.TerraformProperty(name: "os_type", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @OsType { get; }

            [nterraform.Core.TerraformProperty(name: "size_gb", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @SizeGb { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "data_disk")]
        public sealed class data_disk : nterraform.Core.structure
        {
            public data_disk(FSharpOption<string> @caching = null,
                             FSharpOption<int> @lun = null,
                             FSharpOption<string> @managedDiskId = null)
            {
                @Caching = @caching;
                @Lun = @lun;
                @ManagedDiskId = @managedDiskId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "blob_uri", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @BlobUri { get; }

            [nterraform.Core.TerraformProperty(name: "caching", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Caching { get; }

            [nterraform.Core.TerraformProperty(name: "lun", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @Lun { get; }

            [nterraform.Core.TerraformProperty(name: "managed_disk_id", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @ManagedDiskId { get; }

            [nterraform.Core.TerraformProperty(name: "size_gb", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @SizeGb { get; }
        }

        public azurerm_image(string @location,
                             string @name,
                             string @resourceGroupName,
                             FSharpOption<FSharpList<data_disk>> @dataDisk = null,
                             FSharpOption<FSharpList<os_disk>> @osDisk = null,
                             FSharpOption<string> @sourceVirtualMachineId = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @DataDisk = @dataDisk ?? FSharpList<data_disk>.Empty;
            @OsDisk = @osDisk ?? FSharpList<os_disk>.Empty;
            @SourceVirtualMachineId = @sourceVirtualMachineId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "data_disk", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<data_disk>> @DataDisk { get; }

        [nterraform.Core.TerraformProperty(name: "os_disk", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<os_disk>> @OsDisk { get; }

        [nterraform.Core.TerraformProperty(name: "source_virtual_machine_id", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @SourceVirtualMachineId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
