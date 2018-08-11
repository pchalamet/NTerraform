using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_data_lake_store")]
    public sealed class azurerm_data_lake_store : NTerraform.data
    {
        public azurerm_data_lake_store(string @name,
                                       string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "encryption_state", @out: true, nested: true, min: 0, max: 1)]
        public string @EncryptionState { get; }

        [TerraformProperty(name: "encryption_type", @out: true, nested: true, min: 0, max: 1)]
        public string @EncryptionType { get; }

        [TerraformProperty(name: "firewall_allow_azure_ips", @out: true, nested: true, min: 0, max: 1)]
        public string @FirewallAllowAzureIps { get; }

        [TerraformProperty(name: "firewall_state", @out: true, nested: true, min: 0, max: 1)]
        public string @FirewallState { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "tier", @out: true, nested: true, min: 0, max: 1)]
        public string @Tier { get; }
    }

}
