using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_route")]
    public sealed class aws_route : nterraform.resource
    {
        public aws_route(string @routeTableId,
                         string @destinationCidrBlock = null,
                         string @destinationIpv6CidrBlock = null,
                         string @vpcPeeringConnectionId = null)
        {
            @RouteTableId = @routeTableId;
            @DestinationCidrBlock = @destinationCidrBlock;
            @DestinationIpv6CidrBlock = @destinationIpv6CidrBlock;
            @VpcPeeringConnectionId = @vpcPeeringConnectionId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.TerraformProperty(name: "destination_cidr_block", @out: false, min: 0, max: 1)]
        public string @DestinationCidrBlock { get; }

        [nterraform.TerraformProperty(name: "destination_ipv6_cidr_block", @out: false, min: 0, max: 1)]
        public string @DestinationIpv6CidrBlock { get; }

        [nterraform.TerraformProperty(name: "destination_prefix_list_id", @out: true, min: 0, max: 1)]
        public string @DestinationPrefixListId { get; }

        [nterraform.TerraformProperty(name: "egress_only_gateway_id", @out: true, min: 0, max: 1)]
        public string @EgressOnlyGatewayId { get; }

        [nterraform.TerraformProperty(name: "gateway_id", @out: true, min: 0, max: 1)]
        public string @GatewayId { get; }

        [nterraform.TerraformProperty(name: "instance_id", @out: true, min: 0, max: 1)]
        public string @InstanceId { get; }

        [nterraform.TerraformProperty(name: "instance_owner_id", @out: true, min: 0, max: 1)]
        public string @InstanceOwnerId { get; }

        [nterraform.TerraformProperty(name: "nat_gateway_id", @out: true, min: 0, max: 1)]
        public string @NatGatewayId { get; }

        [nterraform.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "origin", @out: true, min: 0, max: 1)]
        public string @Origin { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "vpc_peering_connection_id", @out: false, min: 0, max: 1)]
        public string @VpcPeeringConnectionId { get; }
    }

}
