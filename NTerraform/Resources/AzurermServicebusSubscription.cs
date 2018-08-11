using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_servicebus_subscription : NTerraform.resource
    {
        public azurerm_servicebus_subscription(int @maxDeliveryCount,
                                               string @name,
                                               string @namespaceName,
                                               string @resourceGroupName,
                                               string @topicName,
                                               bool? @deadLetteringOnFilterEvaluationExceptions = null,
                                               bool? @deadLetteringOnMessageExpiration = null,
                                               bool? @enableBatchedOperations = null,
                                               string @forwardTo = null,
                                               string @location = null,
                                               bool? @requiresSession = null)
        {
            @MaxDeliveryCount = @maxDeliveryCount;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @TopicName = @topicName;
            @DeadLetteringOnFilterEvaluationExceptions = @deadLetteringOnFilterEvaluationExceptions;
            @DeadLetteringOnMessageExpiration = @deadLetteringOnMessageExpiration;
            @EnableBatchedOperations = @enableBatchedOperations;
            @ForwardTo = @forwardTo;
            @Location = @location;
            @RequiresSession = @requiresSession;
        }

        public int @MaxDeliveryCount { get; }
        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public string @TopicName { get; }
        public string @AutoDeleteOnIdle { get; }
        public bool? @DeadLetteringOnFilterEvaluationExceptions { get; }
        public bool? @DeadLetteringOnMessageExpiration { get; }
        public string @DefaultMessageTtl { get; }
        public bool? @EnableBatchedOperations { get; }
        public string @ForwardTo { get; }
        public string @Location { get; }
        public string @LockDuration { get; }
        public bool? @RequiresSession { get; }
    }

}
