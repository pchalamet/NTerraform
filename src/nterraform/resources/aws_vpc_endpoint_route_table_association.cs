using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc_endpoint_route_table_association")]
    public sealed class aws_vpc_endpoint_route_table_association : nterraform.resource
    {
        public aws_vpc_endpoint_route_table_association(string @routeTableId,
                                                        string @vpcEndpointId)
        {
            @RouteTableId = @routeTableId;
            @VpcEndpointId = @vpcEndpointId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.TerraformProperty(name: "vpc_endpoint_id", @out: false, min: 1, max: 1)]
        public string @VpcEndpointId { get; }
    }

}
