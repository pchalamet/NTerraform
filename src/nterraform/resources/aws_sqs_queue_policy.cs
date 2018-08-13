using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_sqs_queue_policy")]
    public sealed class aws_sqs_queue_policy : nterraform.resource
    {
        public aws_sqs_queue_policy(string @policy,
                                    string @queueUrl)
        {
            @Policy = @policy;
            @QueueUrl = @queueUrl;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "queue_url", @out: false, min: 1, max: 1)]
        public string @QueueUrl { get; }
    }

}
