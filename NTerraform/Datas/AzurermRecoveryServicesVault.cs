using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_recovery_services_vault")]
    public sealed class azurerm_recovery_services_vault : NTerraform.data
    {
        public azurerm_recovery_services_vault(string @name,
                                               string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "sku", @out: true, nested: true, min: 0, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
