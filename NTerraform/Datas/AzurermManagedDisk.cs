using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_managed_disk : NTerraform.data
    {
        public azurerm_managed_disk(string @name,
                                    string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public int? @DiskSizeGb { get; }
        public string @OsType { get; }
        public string @SourceResourceId { get; }
        public string @SourceUri { get; }
        public string @StorageAccountType { get; }
        public Dictionary<string,string> @Tags { get; }
        public string[] @Zones { get; }
    }

}
