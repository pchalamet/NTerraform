using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpn_connection_route")]
    public sealed class aws_vpn_connection_route : nterraform.Core.resource
    {
        public aws_vpn_connection_route(string @destinationCidrBlock,
                                        string @vpnConnectionId)
        {
            @DestinationCidrBlock = @destinationCidrBlock;
            @VpnConnectionId = @vpnConnectionId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "destination_cidr_block", @out: false, min: 1, max: 1)]
        public string @DestinationCidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_connection_id", @out: false, min: 1, max: 1)]
        public string @VpnConnectionId { get; }
    }

}
