using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_route")]
    public sealed class aws_route : nterraform.data
    {
        public aws_route(string @routeTableId)
        {
            @RouteTableId = @routeTableId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.TerraformProperty(name: "destination_cidr_block", @out: true, min: 0, max: 1)]
        public string @DestinationCidrBlock { get; }

        [nterraform.TerraformProperty(name: "destination_ipv6_cidr_block", @out: true, min: 0, max: 1)]
        public string @DestinationIpv6CidrBlock { get; }

        [nterraform.TerraformProperty(name: "egress_only_gateway_id", @out: true, min: 0, max: 1)]
        public string @EgressOnlyGatewayId { get; }

        [nterraform.TerraformProperty(name: "gateway_id", @out: true, min: 0, max: 1)]
        public string @GatewayId { get; }

        [nterraform.TerraformProperty(name: "instance_id", @out: true, min: 0, max: 1)]
        public string @InstanceId { get; }

        [nterraform.TerraformProperty(name: "nat_gateway_id", @out: true, min: 0, max: 1)]
        public string @NatGatewayId { get; }

        [nterraform.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "vpc_peering_connection_id", @out: true, min: 0, max: 1)]
        public string @VpcPeeringConnectionId { get; }
    }

}
