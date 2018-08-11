using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_virtual_network_peering")]
    public sealed class azurerm_virtual_network_peering : NTerraform.resource
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

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "remote_virtual_network_id", @out: false, min: 1, max: 1)]
        public string @RemoteVirtualNetworkId { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "virtual_network_name", @out: false, min: 1, max: 1)]
        public string @VirtualNetworkName { get; }

        [TerraformProperty(name: "allow_forwarded_traffic", @out: true, min: 0, max: 1)]
        public bool? @AllowForwardedTraffic { get; }

        [TerraformProperty(name: "allow_gateway_transit", @out: true, min: 0, max: 1)]
        public bool? @AllowGatewayTransit { get; }

        [TerraformProperty(name: "allow_virtual_network_access", @out: true, min: 0, max: 1)]
        public bool? @AllowVirtualNetworkAccess { get; }

        [TerraformProperty(name: "use_remote_gateways", @out: true, min: 0, max: 1)]
        public bool? @UseRemoteGateways { get; }
    }

}
