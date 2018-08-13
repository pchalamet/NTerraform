using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dx_gateway_association")]
    public sealed class aws_dx_gateway_association : nterraform.Core.resource
    {
        public aws_dx_gateway_association(string @dxGatewayId,
                                          string @vpnGatewayId)
        {
            @DxGatewayId = @dxGatewayId;
            @VpnGatewayId = @vpnGatewayId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "dx_gateway_id", @out: false, min: 1, max: 1)]
        public string @DxGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 1, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
