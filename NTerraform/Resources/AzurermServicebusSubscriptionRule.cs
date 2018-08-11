using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_servicebus_subscription_rule")]
    public sealed class azurerm_servicebus_subscription_rule : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "correlation_filter")]
        public sealed class correlation_filter: NTerraform.structure
        {
            public correlation_filter(string @contentType = null,
                                      string @correlationId = null,
                                      string @label = null,
                                      string @messageId = null,
                                      string @replyTo = null,
                                      string @replyToSessionId = null,
                                      string @sessionId = null,
                                      string @to = null)
            {
                @ContentType = @contentType;
                @CorrelationId = @correlationId;
                @Label = @label;
                @MessageId = @messageId;
                @ReplyTo = @replyTo;
                @ReplyToSessionId = @replyToSessionId;
                @SessionId = @sessionId;
                @To = @to;
                base._validate_();
            }

            [TerraformProperty(name: "content_type", @out: false, min: 0, max: 1)]
            public string @ContentType { get; }

            [TerraformProperty(name: "correlation_id", @out: false, min: 0, max: 1)]
            public string @CorrelationId { get; }

            [TerraformProperty(name: "label", @out: false, min: 0, max: 1)]
            public string @Label { get; }

            [TerraformProperty(name: "message_id", @out: false, min: 0, max: 1)]
            public string @MessageId { get; }

            [TerraformProperty(name: "reply_to", @out: false, min: 0, max: 1)]
            public string @ReplyTo { get; }

            [TerraformProperty(name: "reply_to_session_id", @out: false, min: 0, max: 1)]
            public string @ReplyToSessionId { get; }

            [TerraformProperty(name: "session_id", @out: false, min: 0, max: 1)]
            public string @SessionId { get; }

            [TerraformProperty(name: "to", @out: false, min: 0, max: 1)]
            public string @To { get; }
        }

        public azurerm_servicebus_subscription_rule(string @filterType,
                                                    string @name,
                                                    string @namespaceName,
                                                    string @resourceGroupName,
                                                    string @subscriptionName,
                                                    string @topicName,
                                                    string @action = null,
                                                    correlation_filter[] @correlationFilter = null,
                                                    string @sqlFilter = null)
        {
            @FilterType = @filterType;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @SubscriptionName = @subscriptionName;
            @TopicName = @topicName;
            @Action = @action;
            @CorrelationFilter = @correlationFilter;
            @SqlFilter = @sqlFilter;
            base._validate_();
        }

        [TerraformProperty(name: "filter_type", @out: false, min: 1, max: 1)]
        public string @FilterType { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "subscription_name", @out: false, min: 1, max: 1)]
        public string @SubscriptionName { get; }

        [TerraformProperty(name: "topic_name", @out: false, min: 1, max: 1)]
        public string @TopicName { get; }

        [TerraformProperty(name: "action", @out: false, min: 0, max: 1)]
        public string @Action { get; }

        [TerraformProperty(name: "correlation_filter", @out: false, min: 0, max: 1)]
        public correlation_filter[] @CorrelationFilter { get; }

        [TerraformProperty(name: "sql_filter", @out: false, min: 0, max: 1)]
        public string @SqlFilter { get; }
    }

}
