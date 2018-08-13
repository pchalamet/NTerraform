using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_virtual_network_peering")]
    public sealed class azurerm_virtual_network_peering : nterraform.resource
    {
        public azurerm_virtual_network_peering(string @name,
                                               string @remoteVirtualNetworkId,
                                               string @resourceGroupName,
                                               string @virtualNetworkName)
        {
            @Name = @name;
            @RemoteVirtualNetworkId = @remoteVirtualNetworkId;
            @ResourceGroupName = @resourceGroupName;
            @VirtualNetworkName = @virtualNetworkName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "remote_virtual_network_id", @out: false, min: 1, max: 1)]
        public string @RemoteVirtualNetworkId { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "virtual_network_name", @out: false, min: 1, max: 1)]
        public string @VirtualNetworkName { get; }

        [nterraform.TerraformProperty(name: "allow_forwarded_traffic", @out: true, min: 0, max: 1)]
        public bool? @AllowForwardedTraffic { get; }

        [nterraform.TerraformProperty(name: "allow_gateway_transit", @out: true, min: 0, max: 1)]
        public bool? @AllowGatewayTransit { get; }

        [nterraform.TerraformProperty(name: "allow_virtual_network_access", @out: true, min: 0, max: 1)]
        public bool? @AllowVirtualNetworkAccess { get; }

        [nterraform.TerraformProperty(name: "use_remote_gateways", @out: true, min: 0, max: 1)]
        public bool? @UseRemoteGateways { get; }
    }

}
