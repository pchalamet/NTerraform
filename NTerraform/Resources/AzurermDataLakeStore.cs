using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_data_lake_store")]
    public sealed class azurerm_data_lake_store : NTerraform.resource
    {
        public azurerm_data_lake_store(string @location,
                                       string @name,
                                       string @resourceGroupName,
                                       string @encryptionState = null,
                                       string @firewallAllowAzureIps = null,
                                       string @firewallState = null,
                                       string @tier = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @EncryptionState = @encryptionState;
            @FirewallAllowAzureIps = @firewallAllowAzureIps;
            @FirewallState = @firewallState;
            @Tier = @tier;
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "encryption_state", @out: false, min: 0, max: 1)]
        public string @EncryptionState { get; }

        [TerraformProperty(name: "encryption_type", @out: true, min: 0, max: 1)]
        public string @EncryptionType { get; }

        [TerraformProperty(name: "firewall_allow_azure_ips", @out: false, min: 0, max: 1)]
        public string @FirewallAllowAzureIps { get; }

        [TerraformProperty(name: "firewall_state", @out: false, min: 0, max: 1)]
        public string @FirewallState { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "tier", @out: false, min: 0, max: 1)]
        public string @Tier { get; }
    }

}
