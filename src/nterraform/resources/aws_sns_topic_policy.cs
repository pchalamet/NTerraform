using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_sns_topic_policy")]
    public sealed class aws_sns_topic_policy : nterraform.resource
    {
        public aws_sns_topic_policy(string @arn,
                                    string @policy)
        {
            @Arn = @arn;
            @Policy = @policy;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "arn", @out: false, min: 1, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }
    }

}
