using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_sns_topic_subscription")]
    public sealed class aws_sns_topic_subscription : nterraform.Core.resource
    {
        public aws_sns_topic_subscription(string @endpoint,
                                          string @protocol,
                                          string @topicArn,
                                          int? @confirmationTimeoutInMinutes = null,
                                          string @deliveryPolicy = null,
                                          bool? @endpointAutoConfirms = null,
                                          string @filterPolicy = null,
                                          bool? @rawMessageDelivery = null)
        {
            @Endpoint = @endpoint;
            @Protocol = @protocol;
            @TopicArn = @topicArn;
            @ConfirmationTimeoutInMinutes = @confirmationTimeoutInMinutes;
            @DeliveryPolicy = @deliveryPolicy;
            @EndpointAutoConfirms = @endpointAutoConfirms;
            @FilterPolicy = @filterPolicy;
            @RawMessageDelivery = @rawMessageDelivery;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: false, min: 1, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
        public string @Protocol { get; }

        [nterraform.Core.TerraformProperty(name: "topic_arn", @out: false, min: 1, max: 1)]
        public string @TopicArn { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "confirmation_timeout_in_minutes", @out: false, min: 0, max: 1)]
        public int? @ConfirmationTimeoutInMinutes { get; }

        [nterraform.Core.TerraformProperty(name: "delivery_policy", @out: false, min: 0, max: 1)]
        public string @DeliveryPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint_auto_confirms", @out: false, min: 0, max: 1)]
        public bool? @EndpointAutoConfirms { get; }

        [nterraform.Core.TerraformProperty(name: "filter_policy", @out: false, min: 0, max: 1)]
        public string @FilterPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "raw_message_delivery", @out: false, min: 0, max: 1)]
        public bool? @RawMessageDelivery { get; }
    }

}