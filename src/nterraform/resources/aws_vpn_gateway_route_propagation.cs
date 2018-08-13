using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpn_gateway_route_propagation")]
    public sealed class aws_vpn_gateway_route_propagation : nterraform.Core.resource
    {
        public aws_vpn_gateway_route_propagation(string @routeTableId,
                                                 string @vpnGatewayId)
        {
            @RouteTableId = @routeTableId;
            @VpnGatewayId = @vpnGatewayId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 1, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
