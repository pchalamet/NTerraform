using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_image : NTerraform.resource
    {
        public class os_disk
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

        public class data_disk
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
                             List<data_disk> @dataDisk = null,
                             List<os_disk> @osDisk = null,
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
        public List<data_disk> @DataDisk { get; }
        public List<os_disk> @OsDisk { get; }
        public string @SourceVirtualMachineId { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
