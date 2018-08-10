using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_data_lake_store_firewall_rule : NTerraform.resource
    {
        public azurerm_data_lake_store_firewall_rule(string @accountName,
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
