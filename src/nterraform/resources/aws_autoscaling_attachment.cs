using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_autoscaling_attachment")]
    public sealed class aws_autoscaling_attachment : nterraform.Core.resource
    {
        public aws_autoscaling_attachment(string @autoscalingGroupName,
                                          string @albTargetGroupArn = null,
                                          string @elb = null)
        {
            @AutoscalingGroupName = @autoscalingGroupName;
            @AlbTargetGroupArn = @albTargetGroupArn;
            @Elb = @elb;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "autoscaling_group_name", @out: false, min: 1, max: 1)]
        public string @AutoscalingGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "alb_target_group_arn", @out: false, min: 0, max: 1)]
        public string @AlbTargetGroupArn { get; }

        [nterraform.Core.TerraformProperty(name: "elb", @out: false, min: 0, max: 1)]
        public string @Elb { get; }
    }

}
