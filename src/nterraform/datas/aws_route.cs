using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_route")]
    public sealed class aws_route : nterraform.Core.data
    {
        public aws_route(string @routeTableId)
        {
            @RouteTableId = @routeTableId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "destination_cidr_block", @out: true, min: 0, max: 1)]
        public string @DestinationCidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "destination_ipv6_cidr_block", @out: true, min: 0, max: 1)]
        public string @DestinationIpv6CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "egress_only_gateway_id", @out: true, min: 0, max: 1)]
        public string @EgressOnlyGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "gateway_id", @out: true, min: 0, max: 1)]
        public string @GatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "instance_id", @out: true, min: 0, max: 1)]
        public string @InstanceId { get; }

        [nterraform.Core.TerraformProperty(name: "nat_gateway_id", @out: true, min: 0, max: 1)]
        public string @NatGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_peering_connection_id", @out: true, min: 0, max: 1)]
        public string @VpcPeeringConnectionId { get; }
    }

}
