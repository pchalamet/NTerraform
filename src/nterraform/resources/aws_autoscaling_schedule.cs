using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_autoscaling_schedule")]
    public sealed class aws_autoscaling_schedule : nterraform.resource
    {
        public aws_autoscaling_schedule(string @autoscalingGroupName,
                                        string @scheduledActionName)
        {
            @AutoscalingGroupName = @autoscalingGroupName;
            @ScheduledActionName = @scheduledActionName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "autoscaling_group_name", @out: false, min: 1, max: 1)]
        public string @AutoscalingGroupName { get; }

        [nterraform.TerraformProperty(name: "scheduled_action_name", @out: false, min: 1, max: 1)]
        public string @ScheduledActionName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "desired_capacity", @out: true, min: 0, max: 1)]
        public int? @DesiredCapacity { get; }

        [nterraform.TerraformProperty(name: "end_time", @out: true, min: 0, max: 1)]
        public string @EndTime { get; }

        [nterraform.TerraformProperty(name: "max_size", @out: true, min: 0, max: 1)]
        public int? @MaxSize { get; }

        [nterraform.TerraformProperty(name: "min_size", @out: true, min: 0, max: 1)]
        public int? @MinSize { get; }

        [nterraform.TerraformProperty(name: "recurrence", @out: true, min: 0, max: 1)]
        public string @Recurrence { get; }

        [nterraform.TerraformProperty(name: "start_time", @out: true, min: 0, max: 1)]
        public string @StartTime { get; }
    }

}
