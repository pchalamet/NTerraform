using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_dx_private_virtual_interface")]
    public sealed class aws_dx_private_virtual_interface : nterraform.Core.resource
    {
        public aws_dx_private_virtual_interface(string @addressFamily,
                                                int @bgpAsn,
                                                string @connectionId,
                                                string @name,
                                                int @vlan,
                                                string @dxGatewayId = null,
                                                Dictionary<string,string> @tags = null,
                                                string @vpnGatewayId = null)
        {
            @AddressFamily = @addressFamily;
            @BgpAsn = @bgpAsn;
            @ConnectionId = @connectionId;
            @Name = @name;
            @Vlan = @vlan;
            @DxGatewayId = @dxGatewayId;
            @Tags = @tags;
            @VpnGatewayId = @vpnGatewayId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "address_family", @out: false, min: 1, max: 1)]
        public string @AddressFamily { get; }

        [nterraform.Core.TerraformProperty(name: "bgp_asn", @out: false, min: 1, max: 1)]
        public int @BgpAsn { get; }

        [nterraform.Core.TerraformProperty(name: "connection_id", @out: false, min: 1, max: 1)]
        public string @ConnectionId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "vlan", @out: false, min: 1, max: 1)]
        public int @Vlan { get; }

        [nterraform.Core.TerraformProperty(name: "amazon_address", @out: true, min: 0, max: 1)]
        public string @AmazonAddress { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "bgp_auth_key", @out: true, min: 0, max: 1)]
        public string @BgpAuthKey { get; }

        [nterraform.Core.TerraformProperty(name: "customer_address", @out: true, min: 0, max: 1)]
        public string @CustomerAddress { get; }

        [nterraform.Core.TerraformProperty(name: "dx_gateway_id", @out: false, min: 0, max: 1)]
        public string @DxGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 0, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
