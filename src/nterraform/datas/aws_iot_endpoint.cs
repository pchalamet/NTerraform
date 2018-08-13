using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_iot_endpoint")]
    public sealed class aws_iot_endpoint : nterraform.Core.data
    {
        public aws_iot_endpoint()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "endpoint_address", @out: true, min: 0, max: 1)]
        public string @EndpointAddress { get; }
    }

}
