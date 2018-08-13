using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_resource_policy")]
    public sealed class aws_cloudwatch_log_resource_policy : nterraform.Core.resource
    {
        public aws_cloudwatch_log_resource_policy(string @policyDocument,
                                                  string @policyName)
        {
            @PolicyDocument = @policyDocument;
            @PolicyName = @policyName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "policy_document", @out: false, min: 1, max: 1)]
        public string @PolicyDocument { get; }

        [nterraform.Core.TerraformProperty(name: "policy_name", @out: false, min: 1, max: 1)]
        public string @PolicyName { get; }
    }

}
