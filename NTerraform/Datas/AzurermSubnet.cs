using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_subnet")]
    public sealed class azurerm_subnet : NTerraform.data
    {
        public azurerm_subnet(string @name,
                              string @resourceGroupName,
                              string @virtualNetworkName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @VirtualNetworkName = @virtualNetworkName;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "virtual_network_name", @out: false, nested: true, min: 1, max: 1)]
        public string @VirtualNetworkName { get; }

        [TerraformProperty(name: "address_prefix", @out: true, nested: true, min: 0, max: 1)]
        public string @AddressPrefix { get; }

        [TerraformProperty(name: "ip_configurations", @out: true, nested: true, min: 0, max: 1)]
        public string[] @IpConfigurations { get; }

        [TerraformProperty(name: "network_security_group_id", @out: true, nested: true, min: 0, max: 1)]
        public string @NetworkSecurityGroupId { get; }

        [TerraformProperty(name: "route_table_id", @out: true, nested: true, min: 0, max: 1)]
        public string @RouteTableId { get; }
    }

}
