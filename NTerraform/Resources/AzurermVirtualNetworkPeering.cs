using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_virtual_network_peering : NTerraform.resource
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
        }

        public string @Name { get; }
        public string @RemoteVirtualNetworkId { get; }
        public string @ResourceGroupName { get; }
        public string @VirtualNetworkName { get; }
        public bool? @AllowForwardedTraffic { get; }
        public bool? @AllowGatewayTransit { get; }
        public bool? @AllowVirtualNetworkAccess { get; }
        public bool? @UseRemoteGateways { get; }
    }

}
