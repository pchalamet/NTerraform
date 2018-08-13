using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_route_table")]
    public sealed class aws_route_table : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "routes")]
        public sealed class routes : nterraform.structure
        {
            public routes()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cidr_block", @out: true, min: 0, max: 1)]
            public string @CidrBlock { get; }

            [nterraform.TerraformProperty(name: "egress_only_gateway_id", @out: true, min: 0, max: 1)]
            public string @EgressOnlyGatewayId { get; }

            [nterraform.TerraformProperty(name: "gateway_id", @out: true, min: 0, max: 1)]
            public string @GatewayId { get; }

            [nterraform.TerraformProperty(name: "instance_id", @out: true, min: 0, max: 1)]
            public string @InstanceId { get; }

            [nterraform.TerraformProperty(name: "ipv6_cidr_block", @out: true, min: 0, max: 1)]
            public string @Ipv6CidrBlock { get; }

            [nterraform.TerraformProperty(name: "nat_gateway_id", @out: true, min: 0, max: 1)]
            public string @NatGatewayId { get; }

            [nterraform.TerraformProperty(name: "network_interface_id", @out: true, min: 0, max: 1)]
            public string @NetworkInterfaceId { get; }

            [nterraform.TerraformProperty(name: "vpc_peering_connection_id", @out: true, min: 0, max: 1)]
            public string @VpcPeeringConnectionId { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "associations")]
        public sealed class associations : nterraform.structure
        {
            public associations()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "main", @out: true, min: 0, max: 1)]
            public bool? @Main { get; }

            [nterraform.TerraformProperty(name: "route_table_association_id", @out: true, min: 0, max: 1)]
            public string @RouteTableAssociationId { get; }

            [nterraform.TerraformProperty(name: "route_table_id", @out: true, min: 0, max: 1)]
            public string @RouteTableId { get; }

            [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_route_table(associations[] @associations = null,
                               filter[] @filter = null,
                               routes[] @routes = null)
        {
            @Associations = @associations;
            @Filter = @filter;
            @Routes = @routes;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "associations", @out: false, min: 0, max: 0)]
        public associations[] @Associations { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "route_table_id", @out: true, min: 0, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.TerraformProperty(name: "routes", @out: false, min: 0, max: 0)]
        public routes[] @Routes { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
