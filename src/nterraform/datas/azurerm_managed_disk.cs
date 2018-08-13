using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_managed_disk")]
    public sealed class azurerm_managed_disk : nterraform.data
    {
        public azurerm_managed_disk(string @name,
                                    string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
        public int? @DiskSizeGb { get; }

        [nterraform.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
        public string @OsType { get; }

        [nterraform.TerraformProperty(name: "source_resource_id", @out: true, min: 0, max: 1)]
        public string @SourceResourceId { get; }

        [nterraform.TerraformProperty(name: "source_uri", @out: true, min: 0, max: 1)]
        public string @SourceUri { get; }

        [nterraform.TerraformProperty(name: "storage_account_type", @out: true, min: 0, max: 1)]
        public string @StorageAccountType { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "zones", @out: true, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
