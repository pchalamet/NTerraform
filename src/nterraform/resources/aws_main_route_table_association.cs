using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_main_route_table_association")]
    public sealed class aws_main_route_table_association : nterraform.Core.resource
    {
        public aws_main_route_table_association(string @routeTableId,
                                                string @vpcId)
        {
            @RouteTableId = @routeTableId;
            @VpcId = @vpcId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.Core.TerraformProperty(name: "original_route_table_id", @out: true, min: 0, max: 1)]
        public string @OriginalRouteTableId { get; }
    }

}