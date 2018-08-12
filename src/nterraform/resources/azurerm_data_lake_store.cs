using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_data_lake_store")]
    public sealed class azurerm_data_lake_store : nterraform.Core.resource
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_state", @out: false, min: 0, max: 1)]
        public string @EncryptionState { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_type", @out: true, min: 0, max: 1)]
        public string @EncryptionType { get; }

        [nterraform.Core.TerraformProperty(name: "firewall_allow_azure_ips", @out: false, min: 0, max: 1)]
        public string @FirewallAllowAzureIps { get; }

        [nterraform.Core.TerraformProperty(name: "firewall_state", @out: false, min: 0, max: 1)]
        public string @FirewallState { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "tier", @out: false, min: 0, max: 1)]
        public string @Tier { get; }
    }

}
