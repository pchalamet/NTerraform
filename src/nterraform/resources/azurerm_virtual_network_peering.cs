using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_virtual_network_peering")]
    public sealed class azurerm_virtual_network_peering : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "remote_virtual_network_id", @out: false, min: 1, max: 1)]
        public string @RemoteVirtualNetworkId { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "virtual_network_name", @out: false, min: 1, max: 1)]
        public string @VirtualNetworkName { get; }

        [nterraform.Core.TerraformProperty(name: "allow_forwarded_traffic", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @AllowForwardedTraffic { get; }

        [nterraform.Core.TerraformProperty(name: "allow_gateway_transit", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @AllowGatewayTransit { get; }

        [nterraform.Core.TerraformProperty(name: "allow_virtual_network_access", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @AllowVirtualNetworkAccess { get; }

        [nterraform.Core.TerraformProperty(name: "use_remote_gateways", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @UseRemoteGateways { get; }
    }

}
