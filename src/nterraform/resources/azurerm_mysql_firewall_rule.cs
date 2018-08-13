using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_mysql_firewall_rule")]
    public sealed class azurerm_mysql_firewall_rule : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "end_ip_address", @out: false, min: 1, max: 1)]
        public string @EndIpAddress { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [nterraform.TerraformProperty(name: "start_ip_address", @out: false, min: 1, max: 1)]
        public string @StartIpAddress { get; }
    }

}
