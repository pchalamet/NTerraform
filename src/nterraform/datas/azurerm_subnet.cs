using System.Collections.Generic;

namespace nterraform.datas.azurerm
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_subnet")]
    public sealed class azurerm_subnet : nterraform.Core.data
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "virtual_network_name", @out: false, min: 1, max: 1)]
        public string @VirtualNetworkName { get; }

        [nterraform.Core.TerraformProperty(name: "address_prefix", @out: true, min: 0, max: 1)]
        public string @AddressPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "ip_configurations", @out: true, min: 0, max: 1)]
        public string[] @IpConfigurations { get; }

        [nterraform.Core.TerraformProperty(name: "network_security_group_id", @out: true, min: 0, max: 1)]
        public string @NetworkSecurityGroupId { get; }

        [nterraform.Core.TerraformProperty(name: "route_table_id", @out: true, min: 0, max: 1)]
        public string @RouteTableId { get; }
    }

}
