using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dx_gateway_association")]
    public sealed class aws_dx_gateway_association : nterraform.resource
    {
        public aws_dx_gateway_association(string @dxGatewayId,
                                          string @vpnGatewayId)
        {
            @DxGatewayId = @dxGatewayId;
            @VpnGatewayId = @vpnGatewayId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "dx_gateway_id", @out: false, min: 1, max: 1)]
        public string @DxGatewayId { get; }

        [nterraform.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 1, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
