using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpn_gateway_attachment")]
    public sealed class aws_vpn_gateway_attachment : nterraform.Core.resource
    {
        public aws_vpn_gateway_attachment(string @vpcId,
                                          string @vpnGatewayId)
        {
            @VpcId = @vpcId;
            @VpnGatewayId = @vpnGatewayId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 1, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
