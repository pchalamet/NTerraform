using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpn_gateway_route_propagation")]
    public sealed class aws_vpn_gateway_route_propagation : nterraform.resource
    {
        public aws_vpn_gateway_route_propagation(string @routeTableId,
                                                 string @vpnGatewayId)
        {
            @RouteTableId = @routeTableId;
            @VpnGatewayId = @vpnGatewayId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 1, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
