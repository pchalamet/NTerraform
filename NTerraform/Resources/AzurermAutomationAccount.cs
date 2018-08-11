using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_automation_account")]
    public sealed class azurerm_automation_account : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku(string @name = null)
            {
                @Name = @name;
            }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        public azurerm_automation_account(string @location,
                                          string @name,
                                          string @resourceGroupName,
                                          sku[] @sku)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
        }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
