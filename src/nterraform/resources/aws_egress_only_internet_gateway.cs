using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_egress_only_internet_gateway")]
    public sealed class aws_egress_only_internet_gateway : nterraform.resource
    {
        public aws_egress_only_internet_gateway(string @vpcId)
        {
            @VpcId = @vpcId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }
    }

}
