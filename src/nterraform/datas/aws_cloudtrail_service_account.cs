using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_cloudtrail_service_account")]
    public sealed class aws_cloudtrail_service_account : nterraform.Core.data
    {
        public aws_cloudtrail_service_account(string @region = null)
        {
            @Region = @region;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "region", @out: false, min: 0, max: 1)]
        public string @Region { get; }
    }

}
