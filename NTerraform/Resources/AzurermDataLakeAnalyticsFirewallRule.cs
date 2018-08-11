using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_data_lake_analytics_firewall_rule : NTerraform.resource
    {
        public azurerm_data_lake_analytics_firewall_rule(string @accountName,
                                                         string @endIpAddress,
                                                         string @name,
                                                         string @resourceGroupName,
                                                         string @startIpAddress)
        {
            @AccountName = @accountName;
            @EndIpAddress = @endIpAddress;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StartIpAddress = @startIpAddress;
        }

        public string @AccountName { get; }
        public string @EndIpAddress { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @StartIpAddress { get; }
    }

}
