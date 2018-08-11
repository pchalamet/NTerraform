using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_storage_share")]
    public sealed class azurerm_storage_share : NTerraform.resource
    {
        public azurerm_storage_share(string @name,
                                     string @resourceGroupName,
                                     string @storageAccountName,
                                     int? @quota = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountName = @storageAccountName;
            @Quota = @quota;
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
        public string @StorageAccountName { get; }

        [TerraformProperty(name: "quota", @out: false, min: 0, max: 1)]
        public int? @Quota { get; }

        [TerraformProperty(name: "url", @out: true, min: 0, max: 1)]
        public string @Url { get; }
    }

}
