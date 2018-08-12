using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_managed_disk")]
    public sealed class azurerm_managed_disk : nterraform.Core.data
    {
        public azurerm_managed_disk(string @name,
                                    string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
        public int? @DiskSizeGb { get; }

        [nterraform.Core.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
        public string @OsType { get; }

        [nterraform.Core.TerraformProperty(name: "source_resource_id", @out: true, min: 0, max: 1)]
        public string @SourceResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "source_uri", @out: true, min: 0, max: 1)]
        public string @SourceUri { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account_type", @out: true, min: 0, max: 1)]
        public string @StorageAccountType { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "zones", @out: true, min: 0, max: 1)]
        public FSharpList<string> @Zones { get; }
    }

}
