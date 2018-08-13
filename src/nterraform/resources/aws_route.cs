using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_route")]
    public sealed class aws_route : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "destination_cidr_block", @out: false, min: 0, max: 1)]
        public string @DestinationCidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "destination_ipv6_cidr_block", @out: false, min: 0, max: 1)]
        public string @DestinationIpv6CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "destination_prefix_list_id", @out: true, min: 0, max: 1)]
        public string @DestinationPrefixListId { get; }

        [nterraform.Core.TerraformProperty(name: "egress_only_gateway_id", @out: true, min: 0, max: 1)]
        public string @EgressOnlyGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "gateway_id", @out: true, min: 0, max: 1)]
        public string @GatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "instance_id", @out: true, min: 0, max: 1)]
        public string @InstanceId { get; }

        [nterraform.Core.TerraformProperty(name: "instance_owner_id", @out: true, min: 0, max: 1)]
        public string @InstanceOwnerId { get; }

        [nterraform.Core.TerraformProperty(name: "nat_gateway_id", @out: true, min: 0, max: 1)]
        public string @NatGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "origin", @out: true, min: 0, max: 1)]
        public string @Origin { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_peering_connection_id", @out: false, min: 0, max: 1)]
        public string @VpcPeeringConnectionId { get; }
    }

}
