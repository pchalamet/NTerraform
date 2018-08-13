using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_data_lake_analytics_account")]
    public sealed class azurerm_data_lake_analytics_account : nterraform.resource
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

        [nterraform.TerraformProperty(name: "default_store_account_name", @out: false, min: 1, max: 1)]
        public string @DefaultStoreAccountName { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "tier", @out: false, min: 0, max: 1)]
        public string @Tier { get; }
    }

}
