using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_usage_plan_key")]
    public sealed class aws_api_gateway_usage_plan_key : nterraform.Core.resource
    {
        public aws_api_gateway_usage_plan_key(string @keyId,
                                              string @keyType,
                                              string @usagePlanId)
        {
            @KeyId = @keyId;
            @KeyType = @keyType;
            @UsagePlanId = @usagePlanId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
        public string @KeyId { get; }

        [nterraform.Core.TerraformProperty(name: "key_type", @out: false, min: 1, max: 1)]
        public string @KeyType { get; }

        [nterraform.Core.TerraformProperty(name: "usage_plan_id", @out: false, min: 1, max: 1)]
        public string @UsagePlanId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
        public string @Value { get; }
    }

}
