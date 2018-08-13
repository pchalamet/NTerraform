using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ses_identity_notification_topic")]
    public sealed class aws_ses_identity_notification_topic : nterraform.Core.resource
    {
        public aws_ses_identity_notification_topic(string @identity,
                                                   string @notificationType,
                                                   string @topicArn = null)
        {
            @Identity = @identity;
            @NotificationType = @notificationType;
            @TopicArn = @topicArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "identity", @out: false, min: 1, max: 1)]
        public string @Identity { get; }

        [nterraform.Core.TerraformProperty(name: "notification_type", @out: false, min: 1, max: 1)]
        public string @NotificationType { get; }

        [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 0, max: 1)]
        public string @TopicArn { get; }
    }

}
