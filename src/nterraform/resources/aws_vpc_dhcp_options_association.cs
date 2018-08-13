using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpc_dhcp_options_association")]
    public sealed class aws_vpc_dhcp_options_association : nterraform.Core.resource
    {
        public aws_vpc_dhcp_options_association(string @dhcpOptionsId,
                                                string @vpcId)
        {
            @DhcpOptionsId = @dhcpOptionsId;
            @VpcId = @vpcId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "dhcp_options_id", @out: false, min: 1, max: 1)]
        public string @DhcpOptionsId { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }
    }

}
