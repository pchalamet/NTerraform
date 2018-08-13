using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_route_table_association")]
    public sealed class aws_route_table_association : nterraform.Core.resource
    {
        public aws_route_table_association(string @routeTableId,
                                           string @subnetId)
        {
            @RouteTableId = @routeTableId;
            @SubnetId = @subnetId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "route_table_id", @out: false, min: 1, max: 1)]
        public string @RouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
        public string @SubnetId { get; }
    }

}
