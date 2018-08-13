using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_subnet")]
    public sealed class azurerm_subnet : nterraform.data
    {
        public azurerm_subnet(string @name,
                              string @resourceGroupName,
                              string @virtualNetworkName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @VirtualNetworkName = @virtualNetworkName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "virtual_network_name", @out: false, min: 1, max: 1)]
        public string @VirtualNetworkName { get; }

        [nterraform.TerraformProperty(name: "address_prefix", @out: true, min: 0, max: 1)]
        public string @AddressPrefix { get; }

        [nterraform.TerraformProperty(name: "ip_configurations", @out: true, min: 0, max: 1)]
        public string[] @IpConfigurations { get; }

        [nterraform.TerraformProperty(name: "network_security_group_id", @out: true, min: 0, max: 1)]
        public string @NetworkSecurityGroupId { get; }

        [nterraform.TerraformProperty(name: "route_table_id", @out: true, min: 0, max: 1)]
        public string @RouteTableId { get; }
    }

}
