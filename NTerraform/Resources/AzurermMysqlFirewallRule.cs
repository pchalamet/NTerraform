using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_mysql_firewall_rule : NTerraform.resource
    {
        public azurerm_mysql_firewall_rule(string @endIpAddress,
                                           string @name,
                                           string @resourceGroupName,
                                           string @serverName,
                                           string @startIpAddress)
        {
            @EndIpAddress = @endIpAddress;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
            @StartIpAddress = @startIpAddress;
        }

        public string @EndIpAddress { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @ServerName { get; }
        public string @StartIpAddress { get; }
    }

}
