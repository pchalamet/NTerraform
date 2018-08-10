using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_data_lake_store : NTerraform.resource
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

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @EncryptionState { get; }
        public string @EncryptionType { get; }
        public string @FirewallAllowAzureIps { get; }
        public string @FirewallState { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Tier { get; }
    }

}
