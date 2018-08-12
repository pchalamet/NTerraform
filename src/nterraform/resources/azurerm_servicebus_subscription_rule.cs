using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_subscription_rule")]
    public sealed class azurerm_servicebus_subscription_rule : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "correlation_filter")]
        public sealed class correlation_filter : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "content_type", @out: false, min: 0, max: 1)]
            public string @ContentType { get; }

            [nterraform.Core.TerraformProperty(name: "correlation_id", @out: false, min: 0, max: 1)]
            public string @CorrelationId { get; }

            [nterraform.Core.TerraformProperty(name: "label", @out: false, min: 0, max: 1)]
            public string @Label { get; }

            [nterraform.Core.TerraformProperty(name: "message_id", @out: false, min: 0, max: 1)]
            public string @MessageId { get; }

            [nterraform.Core.TerraformProperty(name: "reply_to", @out: false, min: 0, max: 1)]
            public string @ReplyTo { get; }

            [nterraform.Core.TerraformProperty(name: "reply_to_session_id", @out: false, min: 0, max: 1)]
            public string @ReplyToSessionId { get; }

            [nterraform.Core.TerraformProperty(name: "session_id", @out: false, min: 0, max: 1)]
            public string @SessionId { get; }

            [nterraform.Core.TerraformProperty(name: "to", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "filter_type", @out: false, min: 1, max: 1)]
        public string @FilterType { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "subscription_name", @out: false, min: 1, max: 1)]
        public string @SubscriptionName { get; }

        [nterraform.Core.TerraformProperty(name: "topic_name", @out: false, min: 1, max: 1)]
        public string @TopicName { get; }

        [nterraform.Core.TerraformProperty(name: "action", @out: false, min: 0, max: 1)]
        public string @Action { get; }

        [nterraform.Core.TerraformProperty(name: "correlation_filter", @out: false, min: 0, max: 1)]
        public correlation_filter[] @CorrelationFilter { get; }

        [nterraform.Core.TerraformProperty(name: "sql_filter", @out: false, min: 0, max: 1)]
        public string @SqlFilter { get; }
    }

}
