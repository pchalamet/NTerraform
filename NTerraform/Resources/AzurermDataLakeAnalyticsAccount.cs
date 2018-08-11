using System.Collections.Generic;

namespace NTerraform.Resources
{
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
        }

        public string @DefaultStoreAccountName { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Tier { get; }
    }

}
