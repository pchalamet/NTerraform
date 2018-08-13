using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_default_route_table")]
    public sealed class aws_default_route_table : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "route")]
        public sealed class route : nterraform.structure
        {
            public route(string @cidrBlock = null,
                         string @egressOnlyGatewayId = null,
                         string @gatewayId = null,
                         string @instanceId = null,
                         string @ipv6CidrBlock = null,
                         string @natGatewayId = null,
                         string @networkInterfaceId = null,
                         string @vpcPeeringConnectionId = null)
            {
                @CidrBlock = @cidrBlock;
                @EgressOnlyGatewayId = @egressOnlyGatewayId;
                @GatewayId = @gatewayId;
                @InstanceId = @instanceId;
                @Ipv6CidrBlock = @ipv6CidrBlock;
                @NatGatewayId = @natGatewayId;
                @NetworkInterfaceId = @networkInterfaceId;
                @VpcPeeringConnectionId = @vpcPeeringConnectionId;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cidr_block", @out: false, min: 0, max: 1)]
            public string @CidrBlock { get; }

            [nterraform.TerraformProperty(name: "egress_only_gateway_id", @out: false, min: 0, max: 1)]
            public string @EgressOnlyGatewayId { get; }

            [nterraform.TerraformProperty(name: "gateway_id", @out: false, min: 0, max: 1)]
            public string @GatewayId { get; }

            [nterraform.TerraformProperty(name: "instance_id", @out: false, min: 0, max: 1)]
            public string @InstanceId { get; }

            [nterraform.TerraformProperty(name: "ipv6_cidr_block", @out: false, min: 0, max: 1)]
            public string @Ipv6CidrBlock { get; }

            [nterraform.TerraformProperty(name: "nat_gateway_id", @out: false, min: 0, max: 1)]
            public string @NatGatewayId { get; }

            [nterraform.TerraformProperty(name: "network_interface_id", @out: false, min: 0, max: 1)]
            public string @NetworkInterfaceId { get; }

            [nterraform.TerraformProperty(name: "vpc_peering_connection_id", @out: false, min: 0, max: 1)]
            public string @VpcPeeringConnectionId { get; }
        }

        public aws_default_route_table(string @defaultRouteTableId,
                                       string[] @propagatingVgws = null,
                                       route[] @route = null,
                                       Dictionary<string,string> @tags = null)
        {
            @DefaultRouteTableId = @defaultRouteTableId;
            @PropagatingVgws = @propagatingVgws;
            @Route = @route;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "default_route_table_id", @out: false, min: 1, max: 1)]
        public string @DefaultRouteTableId { get; }

        [nterraform.TerraformProperty(name: "propagating_vgws", @out: false, min: 0, max: 1)]
        public string[] @PropagatingVgws { get; }

        [nterraform.TerraformProperty(name: "route", @out: false, min: 0, max: 0)]
        public route[] @Route { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
