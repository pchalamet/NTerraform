using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_billing_service_account")]
    public sealed class aws_billing_service_account : nterraform.data
    {
        public aws_billing_service_account()
        {
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
