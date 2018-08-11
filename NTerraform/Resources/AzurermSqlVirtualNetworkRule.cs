using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_sql_virtual_network_rule")]
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
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
        public string @SubnetId { get; }

        [TerraformProperty(name: "ignore_missing_vnet_service_endpoint", @out: false, min: 0, max: 1)]
        public bool? @IgnoreMissingVnetServiceEndpoint { get; }
    }

}
