using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_servicebus_subscription_rule : NTerraform.resource
    {
        public class correlation_filter
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
            }

            public string @ContentType { get; }
            public string @CorrelationId { get; }
            public string @Label { get; }
            public string @MessageId { get; }
            public string @ReplyTo { get; }
            public string @ReplyToSessionId { get; }
            public string @SessionId { get; }
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
        }

        public string @FilterType { get; }
        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public string @SubscriptionName { get; }
        public string @TopicName { get; }
        public string @Action { get; }
        public correlation_filter[] @CorrelationFilter { get; }
        public string @SqlFilter { get; }
    }

}
