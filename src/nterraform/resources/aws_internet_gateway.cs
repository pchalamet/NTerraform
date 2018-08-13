using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_internet_gateway")]
    public sealed class aws_internet_gateway : nterraform.resource
    {
        public aws_internet_gateway(Dictionary<string,string> @tags = null,
                                    string @vpcId = null)
        {
            @Tags = @tags;
            @VpcId = @vpcId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
