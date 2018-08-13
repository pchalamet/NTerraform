using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_dx_connection_association")]
    public sealed class aws_dx_connection_association : nterraform.resource
    {
        public aws_dx_connection_association(string @connectionId,
                                             string @lagId)
        {
            @ConnectionId = @connectionId;
            @LagId = @lagId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "connection_id", @out: false, min: 1, max: 1)]
        public string @ConnectionId { get; }

        [nterraform.TerraformProperty(name: "lag_id", @out: false, min: 1, max: 1)]
        public string @LagId { get; }
    }

}
