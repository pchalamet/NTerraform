using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_sql_virtual_network_rule")]
    public sealed class azurerm_sql_virtual_network_rule : nterraform.Core.resource
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "ignore_missing_vnet_service_endpoint", @out: false, min: 0, max: 1)]
        public bool? @IgnoreMissingVnetServiceEndpoint { get; }
    }

}