using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_managed_disk")]
    public sealed class azurerm_managed_disk : NTerraform.data
    {
        public azurerm_managed_disk(string @name,
                                    string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
        public int? @DiskSizeGb { get; }

        [TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
        public string @OsType { get; }

        [TerraformProperty(name: "source_resource_id", @out: true, min: 0, max: 1)]
        public string @SourceResourceId { get; }

        [TerraformProperty(name: "source_uri", @out: true, min: 0, max: 1)]
        public string @SourceUri { get; }

        [TerraformProperty(name: "storage_account_type", @out: true, min: 0, max: 1)]
        public string @StorageAccountType { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "zones", @out: true, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
