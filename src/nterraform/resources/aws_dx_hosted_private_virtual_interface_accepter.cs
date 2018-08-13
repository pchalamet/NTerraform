using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dx_hosted_private_virtual_interface_accepter")]
    public sealed class aws_dx_hosted_private_virtual_interface_accepter : nterraform.Core.resource
    {
        public aws_dx_hosted_private_virtual_interface_accepter(string @virtualInterfaceId,
                                                                string @dxGatewayId = null,
                                                                Dictionary<string,string> @tags = null,
                                                                string @vpnGatewayId = null)
        {
            @VirtualInterfaceId = @virtualInterfaceId;
            @DxGatewayId = @dxGatewayId;
            @Tags = @tags;
            @VpnGatewayId = @vpnGatewayId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "virtual_interface_id", @out: false, min: 1, max: 1)]
        public string @VirtualInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "dx_gateway_id", @out: false, min: 0, max: 1)]
        public string @DxGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 0, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
