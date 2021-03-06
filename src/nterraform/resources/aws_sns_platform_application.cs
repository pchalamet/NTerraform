using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_sns_platform_application")]
    public sealed class aws_sns_platform_application : nterraform.resource
    {
        public aws_sns_platform_application(string @name,
                                            string @platform,
                                            string @platformCredential,
                                            string @eventDeliveryFailureTopicArn = null,
                                            string @eventEndpointCreatedTopicArn = null,
                                            string @eventEndpointDeletedTopicArn = null,
                                            string @eventEndpointUpdatedTopicArn = null,
                                            string @failureFeedbackRoleArn = null,
                                            string @platformPrincipal = null,
                                            string @successFeedbackRoleArn = null,
                                            string @successFeedbackSampleRate = null)
        {
            @Name = @name;
            @Platform = @platform;
            @PlatformCredential = @platformCredential;
            @EventDeliveryFailureTopicArn = @eventDeliveryFailureTopicArn;
            @EventEndpointCreatedTopicArn = @eventEndpointCreatedTopicArn;
            @EventEndpointDeletedTopicArn = @eventEndpointDeletedTopicArn;
            @EventEndpointUpdatedTopicArn = @eventEndpointUpdatedTopicArn;
            @FailureFeedbackRoleArn = @failureFeedbackRoleArn;
            @PlatformPrincipal = @platformPrincipal;
            @SuccessFeedbackRoleArn = @successFeedbackRoleArn;
            @SuccessFeedbackSampleRate = @successFeedbackSampleRate;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "platform", @out: false, min: 1, max: 1)]
        public string @Platform { get; }

        [nterraform.TerraformProperty(name: "platform_credential", @out: false, min: 1, max: 1)]
        public string @PlatformCredential { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "event_delivery_failure_topic_arn", @out: false, min: 0, max: 1)]
        public string @EventDeliveryFailureTopicArn { get; }

        [nterraform.TerraformProperty(name: "event_endpoint_created_topic_arn", @out: false, min: 0, max: 1)]
        public string @EventEndpointCreatedTopicArn { get; }

        [nterraform.TerraformProperty(name: "event_endpoint_deleted_topic_arn", @out: false, min: 0, max: 1)]
        public string @EventEndpointDeletedTopicArn { get; }

        [nterraform.TerraformProperty(name: "event_endpoint_updated_topic_arn", @out: false, min: 0, max: 1)]
        public string @EventEndpointUpdatedTopicArn { get; }

        [nterraform.TerraformProperty(name: "failure_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @FailureFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "platform_principal", @out: false, min: 0, max: 1)]
        public string @PlatformPrincipal { get; }

        [nterraform.TerraformProperty(name: "success_feedback_role_arn", @out: false, min: 0, max: 1)]
        public string @SuccessFeedbackRoleArn { get; }

        [nterraform.TerraformProperty(name: "success_feedback_sample_rate", @out: false, min: 0, max: 1)]
        public string @SuccessFeedbackSampleRate { get; }
    }

}
