using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_sqs_queue_policy")]
    public sealed class aws_sqs_queue_policy : nterraform.Core.resource
    {
        public aws_sqs_queue_policy(string @policy,
                                    string @queueUrl)
        {
            @Policy = @policy;
            @QueueUrl = @queueUrl;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "queue_url", @out: false, min: 1, max: 1)]
        public string @QueueUrl { get; }
    }

}
