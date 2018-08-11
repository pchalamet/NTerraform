using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_image : NTerraform.data
    {
        public sealed class os_disk
        {
            public os_disk()
            {
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
            public data_disk()
            {
            }

            public string @BlobUri { get; }
            public string @Caching { get; }
            public int? @Lun { get; }
            public string @ManagedDiskId { get; }
            public int? @SizeGb { get; }
        }

        public azurerm_image(string @resourceGroupName,
                             data_disk[] @dataDisk = null,
                             string @name = null,
                             string @nameRegex = null,
                             os_disk[] @osDisk = null,
                             bool? @sortDescending = null)
        {
            @ResourceGroupName = @resourceGroupName;
            @DataDisk = @dataDisk;
            @Name = @name;
            @NameRegex = @nameRegex;
            @OsDisk = @osDisk;
            @SortDescending = @sortDescending;
        }

        public string @ResourceGroupName { get; }
        public data_disk[] @DataDisk { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @NameRegex { get; }
        public os_disk[] @OsDisk { get; }
        public bool? @SortDescending { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
