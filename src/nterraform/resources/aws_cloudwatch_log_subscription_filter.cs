using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_subscription_filter")]
    public sealed class aws_cloudwatch_log_subscription_filter : nterraform.Core.resource
    {
        public aws_cloudwatch_log_subscription_filter(string @destinationArn,
                                                      string @filterPattern,
                                                      string @logGroupName,
                                                      string @name,
                                                      string @distribution = null)
        {
            @DestinationArn = @destinationArn;
            @FilterPattern = @filterPattern;
            @LogGroupName = @logGroupName;
            @Name = @name;
            @Distribution = @distribution;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "destination_arn", @out: false, min: 1, max: 1)]
        public string @DestinationArn { get; }

        [nterraform.Core.TerraformProperty(name: "filter_pattern", @out: false, min: 1, max: 1)]
        public string @FilterPattern { get; }

        [nterraform.Core.TerraformProperty(name: "log_group_name", @out: false, min: 1, max: 1)]
        public string @LogGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "distribution", @out: false, min: 0, max: 1)]
        public string @Distribution { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: true, min: 0, max: 1)]
        public string @RoleArn { get; }
    }

}
