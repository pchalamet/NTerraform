using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_route53_zone_association")]
    public sealed class aws_route53_zone_association : nterraform.Core.resource
    {
        public aws_route53_zone_association(string @vpcId,
                                            string @zoneId)
        {
            @VpcId = @vpcId;
            @ZoneId = @zoneId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.Core.TerraformProperty(name: "zone_id", @out: false, min: 1, max: 1)]
        public string @ZoneId { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_region", @out: true, min: 0, max: 1)]
        public string @VpcRegion { get; }
    }

}