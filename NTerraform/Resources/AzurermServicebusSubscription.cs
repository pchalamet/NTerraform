using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_servicebus_subscription")]
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

        [TerraformProperty(name: "max_delivery_count", @out: false, nested: true, min: 1, max: 1)]
        public int @MaxDeliveryCount { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, nested: true, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "topic_name", @out: false, nested: true, min: 1, max: 1)]
        public string @TopicName { get; }

        [TerraformProperty(name: "auto_delete_on_idle", @out: true, nested: true, min: 0, max: 1)]
        public string @AutoDeleteOnIdle { get; }

        [TerraformProperty(name: "dead_lettering_on_filter_evaluation_exceptions", @out: false, nested: true, min: 0, max: 1)]
        public bool? @DeadLetteringOnFilterEvaluationExceptions { get; }

        [TerraformProperty(name: "dead_lettering_on_message_expiration", @out: false, nested: true, min: 0, max: 1)]
        public bool? @DeadLetteringOnMessageExpiration { get; }

        [TerraformProperty(name: "default_message_ttl", @out: true, nested: true, min: 0, max: 1)]
        public string @DefaultMessageTtl { get; }

        [TerraformProperty(name: "enable_batched_operations", @out: false, nested: true, min: 0, max: 1)]
        public bool? @EnableBatchedOperations { get; }

        [TerraformProperty(name: "forward_to", @out: false, nested: true, min: 0, max: 1)]
        public string @ForwardTo { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "lock_duration", @out: true, nested: true, min: 0, max: 1)]
        public string @LockDuration { get; }

        [TerraformProperty(name: "requires_session", @out: false, nested: true, min: 0, max: 1)]
        public bool? @RequiresSession { get; }
    }

}
