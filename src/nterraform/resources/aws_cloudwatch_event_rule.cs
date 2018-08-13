using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_event_rule")]
    public sealed class aws_cloudwatch_event_rule : nterraform.Core.resource
    {
        public aws_cloudwatch_event_rule(string @description = null,
                                         string @eventPattern = null,
                                         bool? @isEnabled = null,
                                         string @namePrefix = null,
                                         string @roleArn = null,
                                         string @scheduleExpression = null)
        {
            @Description = @description;
            @EventPattern = @eventPattern;
            @IsEnabled = @isEnabled;
            @NamePrefix = @namePrefix;
            @RoleArn = @roleArn;
            @ScheduleExpression = @scheduleExpression;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "event_pattern", @out: false, min: 0, max: 1)]
        public string @EventPattern { get; }

        [nterraform.Core.TerraformProperty(name: "is_enabled", @out: false, min: 0, max: 1)]
        public bool? @IsEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "schedule_expression", @out: false, min: 0, max: 1)]
        public string @ScheduleExpression { get; }
    }

}
