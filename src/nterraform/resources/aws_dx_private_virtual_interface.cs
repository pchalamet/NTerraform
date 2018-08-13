using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dx_private_virtual_interface")]
    public sealed class aws_dx_private_virtual_interface : nterraform.resource
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

        [nterraform.TerraformProperty(name: "address_family", @out: false, min: 1, max: 1)]
        public string @AddressFamily { get; }

        [nterraform.TerraformProperty(name: "bgp_asn", @out: false, min: 1, max: 1)]
        public int @BgpAsn { get; }

        [nterraform.TerraformProperty(name: "connection_id", @out: false, min: 1, max: 1)]
        public string @ConnectionId { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "vlan", @out: false, min: 1, max: 1)]
        public int @Vlan { get; }

        [nterraform.TerraformProperty(name: "amazon_address", @out: true, min: 0, max: 1)]
        public string @AmazonAddress { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "bgp_auth_key", @out: true, min: 0, max: 1)]
        public string @BgpAuthKey { get; }

        [nterraform.TerraformProperty(name: "customer_address", @out: true, min: 0, max: 1)]
        public string @CustomerAddress { get; }

        [nterraform.TerraformProperty(name: "dx_gateway_id", @out: false, min: 0, max: 1)]
        public string @DxGatewayId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 0, max: 1)]
        public string @VpnGatewayId { get; }
    }

}
