using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_subscription")]
    public sealed class azurerm_servicebus_subscription : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "max_delivery_count", @out: false, min: 1, max: 1)]
        public int @MaxDeliveryCount { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "topic_name", @out: false, min: 1, max: 1)]
        public string @TopicName { get; }

        [nterraform.TerraformProperty(name: "auto_delete_on_idle", @out: true, min: 0, max: 1)]
        public string @AutoDeleteOnIdle { get; }

        [nterraform.TerraformProperty(name: "dead_lettering_on_filter_evaluation_exceptions", @out: false, min: 0, max: 1)]
        public bool? @DeadLetteringOnFilterEvaluationExceptions { get; }

        [nterraform.TerraformProperty(name: "dead_lettering_on_message_expiration", @out: false, min: 0, max: 1)]
        public bool? @DeadLetteringOnMessageExpiration { get; }

        [nterraform.TerraformProperty(name: "default_message_ttl", @out: true, min: 0, max: 1)]
        public string @DefaultMessageTtl { get; }

        [nterraform.TerraformProperty(name: "enable_batched_operations", @out: false, min: 0, max: 1)]
        public bool? @EnableBatchedOperations { get; }

        [nterraform.TerraformProperty(name: "forward_to", @out: false, min: 0, max: 1)]
        public string @ForwardTo { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "lock_duration", @out: true, min: 0, max: 1)]
        public string @LockDuration { get; }

        [nterraform.TerraformProperty(name: "requires_session", @out: false, min: 0, max: 1)]
        public bool? @RequiresSession { get; }
    }

}
