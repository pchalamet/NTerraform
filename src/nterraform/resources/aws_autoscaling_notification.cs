using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_autoscaling_notification")]
    public sealed class aws_autoscaling_notification : nterraform.Core.resource
    {
        public aws_autoscaling_notification(string[] @groupNames,
                                            string[] @notifications,
                                            string @topicArn)
        {
            @GroupNames = @groupNames;
            @Notifications = @notifications;
            @TopicArn = @topicArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "group_names", @out: false, min: 1, max: 1)]
        public string[] @GroupNames { get; }

        [nterraform.Core.TerraformProperty(name: "notifications", @out: false, min: 1, max: 1)]
        public string[] @Notifications { get; }

        [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 1, max: 1)]
        public string @TopicArn { get; }
    }

}
