using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_elb_hosted_zone_id")]
    public sealed class aws_elb_hosted_zone_id : nterraform.Core.data
    {
        public aws_elb_hosted_zone_id(string @region = null)
        {
            @Region = @region;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "region", @out: false, min: 0, max: 1)]
        public string @Region { get; }
    }

}
