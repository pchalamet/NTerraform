using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_default_route_table")]
    public sealed class aws_default_route_table : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "route")]
        public sealed class route : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "cidr_block", @out: false, min: 0, max: 1)]
            public string @CidrBlock { get; }

            [nterraform.Core.TerraformProperty(name: "egress_only_gateway_id", @out: false, min: 0, max: 1)]
            public string @EgressOnlyGatewayId { get; }

            [nterraform.Core.TerraformProperty(name: "gateway_id", @out: false, min: 0, max: 1)]
            public string @GatewayId { get; }

            [nterraform.Core.TerraformProperty(name: "instance_id", @out: false, min: 0, max: 1)]
            public string @InstanceId { get; }

            [nterraform.Core.TerraformProperty(name: "ipv6_cidr_block", @out: false, min: 0, max: 1)]
            public string @Ipv6CidrBlock { get; }

            [nterraform.Core.TerraformProperty(name: "nat_gateway_id", @out: false, min: 0, max: 1)]
            public string @NatGatewayId { get; }

            [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: false, min: 0, max: 1)]
            public string @NetworkInterfaceId { get; }

            [nterraform.Core.TerraformProperty(name: "vpc_peering_connection_id", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "default_route_table_id", @out: false, min: 1, max: 1)]
        public string @DefaultRouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "propagating_vgws", @out: false, min: 0, max: 1)]
        public string[] @PropagatingVgws { get; }

        [nterraform.Core.TerraformProperty(name: "route", @out: false, min: 0, max: 0)]
        public route[] @Route { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
