using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_image : NTerraform.resource
    {
        public sealed class os_disk
        {
            public os_disk(string @caching = null,
                           string @osState = null,
                           string @osType = null)
            {
                @Caching = @caching;
                @OsState = @osState;
                @OsType = @osType;
            }

            public string @BlobUri { get; }
            public string @Caching { get; }
            public string @ManagedDiskId { get; }
            public string @OsState { get; }
            public string @OsType { get; }
            public int? @SizeGb { get; }
        }

        public sealed class data_disk
        {
            public data_disk(string @caching = null,
                             int? @lun = null,
                             string @managedDiskId = null)
            {
                @Caching = @caching;
                @Lun = @lun;
                @ManagedDiskId = @managedDiskId;
            }

            public string @BlobUri { get; }
            public string @Caching { get; }
            public int? @Lun { get; }
            public string @ManagedDiskId { get; }
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
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public data_disk[] @DataDisk { get; }
        public os_disk[] @OsDisk { get; }
        public string @SourceVirtualMachineId { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
