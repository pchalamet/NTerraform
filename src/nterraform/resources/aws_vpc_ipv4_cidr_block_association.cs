using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpc_ipv4_cidr_block_association")]
    public sealed class aws_vpc_ipv4_cidr_block_association : nterraform.Core.resource
    {
        public aws_vpc_ipv4_cidr_block_association(string @cidrBlock,
                                                   string @vpcId)
        {
            @CidrBlock = @cidrBlock;
            @VpcId = @vpcId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cidr_block", @out: false, min: 1, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }
    }

}
