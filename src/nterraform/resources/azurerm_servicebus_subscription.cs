using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_subscription")]
    public sealed class azurerm_servicebus_subscription : nterraform.Core.resource
    {
        public azurerm_servicebus_subscription(int @maxDeliveryCount,
                                               string @name,
                                               string @namespaceName,
                                               string @resourceGroupName,
                                               string @topicName,
                                               FSharpOption<bool> @deadLetteringOnFilterEvaluationExceptions = null,
                                               FSharpOption<bool> @deadLetteringOnMessageExpiration = null,
                                               FSharpOption<bool> @enableBatchedOperations = null,
                                               FSharpOption<string> @forwardTo = null,
                                               FSharpOption<string> @location = null,
                                               FSharpOption<bool> @requiresSession = null)
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

        [nterraform.Core.TerraformProperty(name: "max_delivery_count", @out: false, min: 1, max: 1)]
        public int @MaxDeliveryCount { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "topic_name", @out: false, min: 1, max: 1)]
        public string @TopicName { get; }

        [nterraform.Core.TerraformProperty(name: "auto_delete_on_idle", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AutoDeleteOnIdle { get; }

        [nterraform.Core.TerraformProperty(name: "dead_lettering_on_filter_evaluation_exceptions", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @DeadLetteringOnFilterEvaluationExceptions { get; }

        [nterraform.Core.TerraformProperty(name: "dead_lettering_on_message_expiration", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @DeadLetteringOnMessageExpiration { get; }

        [nterraform.Core.TerraformProperty(name: "default_message_ttl", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultMessageTtl { get; }

        [nterraform.Core.TerraformProperty(name: "enable_batched_operations", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableBatchedOperations { get; }

        [nterraform.Core.TerraformProperty(name: "forward_to", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @ForwardTo { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "lock_duration", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @LockDuration { get; }

        [nterraform.Core.TerraformProperty(name: "requires_session", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @RequiresSession { get; }
    }

}
