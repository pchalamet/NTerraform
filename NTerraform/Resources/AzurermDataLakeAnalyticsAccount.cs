using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_data_lake_analytics_account")]
    public sealed class azurerm_data_lake_analytics_account : NTerraform.resource
    {
        public azurerm_data_lake_analytics_account(string @defaultStoreAccountName,
                                                   string @location,
                                                   string @name,
                                                   string @resourceGroupName,
                                                   string @tier = null)
        {
            @DefaultStoreAccountName = @defaultStoreAccountName;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Tier = @tier;
            base._validate_();
        }

        [TerraformProperty(name: "default_store_account_name", @out: false, min: 1, max: 1)]
        public string @DefaultStoreAccountName { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "tier", @out: false, min: 0, max: 1)]
        public string @Tier { get; }
    }

}
