using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_sns_topic_policy")]
    public sealed class aws_sns_topic_policy : nterraform.Core.resource
    {
        public aws_sns_topic_policy(string @arn,
                                    string @policy)
        {
            @Arn = @arn;
            @Policy = @policy;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: false, min: 1, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: false, min: 1, max: 1)]
        public string @Policy { get; }
    }

}
