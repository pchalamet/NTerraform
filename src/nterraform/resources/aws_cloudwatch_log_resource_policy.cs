using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_resource_policy")]
    public sealed class aws_cloudwatch_log_resource_policy : nterraform.resource
    {
        public aws_cloudwatch_log_resource_policy(string @policyDocument,
                                                  string @policyName)
        {
            @PolicyDocument = @policyDocument;
            @PolicyName = @policyName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "policy_document", @out: false, min: 1, max: 1)]
        public string @PolicyDocument { get; }

        [nterraform.TerraformProperty(name: "policy_name", @out: false, min: 1, max: 1)]
        public string @PolicyName { get; }
    }

}
