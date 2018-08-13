using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpn_gateway_attachment")]
    public sealed class aws_vpn_gateway_attachment : nterraform.resource
    {
        public aws_vpn_gateway_attachment(string @vpcId,
                                          string @vpnGatewayId)
        {
            @VpcId = @vpcId;
            @VpnGatewayId = @vpnGatewayId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 1, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
