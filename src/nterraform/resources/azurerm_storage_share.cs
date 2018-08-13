using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_storage_share")]
    public sealed class azurerm_storage_share : nterraform.resource
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
        public string @StorageAccountName { get; }

        [nterraform.TerraformProperty(name: "quota", @out: false, min: 0, max: 1)]
        public int? @Quota { get; }

        [nterraform.TerraformProperty(name: "url", @out: true, min: 0, max: 1)]
        public string @Url { get; }
    }

}
