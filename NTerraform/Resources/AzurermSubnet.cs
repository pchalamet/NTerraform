using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_subnet")]
    public sealed class azurerm_subnet : NTerraform.resource
    {
        public azurerm_subnet(string @addressPrefix,
                              string @name,
                              string @resourceGroupName,
                              string @virtualNetworkName,
                              string @networkSecurityGroupId = null,
                              string @routeTableId = null,
                              string[] @serviceEndpoints = null)
        {
            @AddressPrefix = @addressPrefix;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @VirtualNetworkName = @virtualNetworkName;
            @NetworkSecurityGroupId = @networkSecurityGroupId;
            @RouteTableId = @routeTableId;
            @ServiceEndpoints = @serviceEndpoints;
        }

        [TerraformProperty(name: "address_prefix", @out: false, nested: true, min: 1, max: 1)]
        public string @AddressPrefix { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "virtual_network_name", @out: false, nested: true, min: 1, max: 1)]
        public string @VirtualNetworkName { get; }

        [TerraformProperty(name: "ip_configurations", @out: true, nested: true, min: 0, max: 1)]
        public string[] @IpConfigurations { get; }

        [TerraformProperty(name: "network_security_group_id", @out: false, nested: true, min: 0, max: 1)]
        public string @NetworkSecurityGroupId { get; }

        [TerraformProperty(name: "route_table_id", @out: false, nested: true, min: 0, max: 1)]
        public string @RouteTableId { get; }

        [TerraformProperty(name: "service_endpoints", @out: false, nested: true, min: 0, max: 1)]
        public string[] @ServiceEndpoints { get; }
    }

}
