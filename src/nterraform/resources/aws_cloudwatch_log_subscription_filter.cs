using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_subscription_filter")]
    public sealed class aws_cloudwatch_log_subscription_filter : nterraform.resource
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

        [nterraform.TerraformProperty(name: "destination_arn", @out: false, min: 1, max: 1)]
        public string @DestinationArn { get; }

        [nterraform.TerraformProperty(name: "filter_pattern", @out: false, min: 1, max: 1)]
        public string @FilterPattern { get; }

        [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 1, max: 1)]
        public string @LogGroupName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "distribution", @out: false, min: 0, max: 1)]
        public string @Distribution { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: true, min: 0, max: 1)]
        public string @RoleArn { get; }
    }

}
