using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_autoscaling_lifecycle_hook")]
    public sealed class aws_autoscaling_lifecycle_hook : nterraform.Core.resource
    {
        public aws_autoscaling_lifecycle_hook(string @autoscalingGroupName,
                                              string @lifecycleTransition,
                                              string @name,
                                              int? @heartbeatTimeout = null,
                                              string @notificationMetadata = null,
                                              string @notificationTargetArn = null,
                                              string @roleArn = null)
        {
            @AutoscalingGroupName = @autoscalingGroupName;
            @LifecycleTransition = @lifecycleTransition;
            @Name = @name;
            @HeartbeatTimeout = @heartbeatTimeout;
            @NotificationMetadata = @notificationMetadata;
            @NotificationTargetArn = @notificationTargetArn;
            @RoleArn = @roleArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "autoscaling_group_name", @out: false, min: 1, max: 1)]
        public string @AutoscalingGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "lifecycle_transition", @out: false, min: 1, max: 1)]
        public string @LifecycleTransition { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "default_result", @out: true, min: 0, max: 1)]
        public string @DefaultResult { get; }

        [nterraform.Core.TerraformProperty(name: "heartbeat_timeout", @out: false, min: 0, max: 1)]
        public int? @HeartbeatTimeout { get; }

        [nterraform.Core.TerraformProperty(name: "notification_metadata", @out: false, min: 0, max: 1)]
        public string @NotificationMetadata { get; }

        [nterraform.Core.TerraformProperty(name: "notification_target_arn", @out: false, min: 0, max: 1)]
        public string @NotificationTargetArn { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
        public string @RoleArn { get; }
    }

}
