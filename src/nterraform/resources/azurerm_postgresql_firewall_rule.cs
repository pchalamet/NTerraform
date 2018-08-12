using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_postgresql_firewall_rule")]
    public sealed class azurerm_postgresql_firewall_rule : nterraform.Core.resource
    {
        public azurerm_postgresql_firewall_rule(string @endIpAddress,
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

        [nterraform.Core.TerraformProperty(name: "end_ip_address", @out: false, min: 1, max: 1)]
        public string @EndIpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [nterraform.Core.TerraformProperty(name: "start_ip_address", @out: false, min: 1, max: 1)]
        public string @StartIpAddress { get; }
    }

}
