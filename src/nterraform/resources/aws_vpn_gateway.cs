using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpn_gateway")]
    public sealed class aws_vpn_gateway : nterraform.Core.resource
    {
        public aws_vpn_gateway(string @availabilityZone = null,
                               Dictionary<string,string> @tags = null)
        {
            @AvailabilityZone = @availabilityZone;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "amazon_side_asn", @out: true, min: 0, max: 1)]
        public string @AmazonSideAsn { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: false, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
