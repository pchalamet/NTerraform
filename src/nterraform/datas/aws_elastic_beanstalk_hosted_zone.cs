using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_elastic_beanstalk_hosted_zone")]
    public sealed class aws_elastic_beanstalk_hosted_zone : nterraform.data
    {
        public aws_elastic_beanstalk_hosted_zone(string @region = null)
        {
            @Region = @region;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "region", @out: false, min: 0, max: 1)]
        public string @Region { get; }
    }

}
