using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_sql_virtual_network_rule : NTerraform.resource
    {
        public azurerm_sql_virtual_network_rule(string @name,
                                                string @resourceGroupName,
                                                string @serverName,
                                                string @subnetId,
                                                bool? @ignoreMissingVnetServiceEndpoint = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
            @SubnetId = @subnetId;
            @IgnoreMissingVnetServiceEndpoint = @ignoreMissingVnetServiceEndpoint;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @ServerName { get; }
        public string @SubnetId { get; }
        public bool? @IgnoreMissingVnetServiceEndpoint { get; }
    }

}
