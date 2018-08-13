using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_event_rule")]
    public sealed class aws_cloudwatch_event_rule : nterraform.resource
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

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "event_pattern", @out: false, min: 0, max: 1)]
        public string @EventPattern { get; }

        [nterraform.TerraformProperty(name: "is_enabled", @out: false, min: 0, max: 1)]
        public bool? @IsEnabled { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
        public string @RoleArn { get; }

        [nterraform.TerraformProperty(name: "schedule_expression", @out: false, min: 0, max: 1)]
        public string @ScheduleExpression { get; }
    }

}
