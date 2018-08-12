using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_queue")]
    public sealed class azurerm_servicebus_queue : nterraform.Core.resource
    {
        public azurerm_servicebus_queue(string @name,
                                        string @namespaceName,
                                        string @resourceGroupName,
                                        bool? @deadLetteringOnMessageExpiration = null,
                                        bool? @enableBatchedOperations = null,
                                        bool? @enableExpress = null,
                                        bool? @enablePartitioning = null,
                                        string @location = null,
                                        bool? @requiresDuplicateDetection = null,
                                        bool? @requiresSession = null,
                                        bool? @supportOrdering = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @DeadLetteringOnMessageExpiration = @deadLetteringOnMessageExpiration;
            @EnableBatchedOperations = @enableBatchedOperations;
            @EnableExpress = @enableExpress;
            @EnablePartitioning = @enablePartitioning;
            @Location = @location;
            @RequiresDuplicateDetection = @requiresDuplicateDetection;
            @RequiresSession = @requiresSession;
            @SupportOrdering = @supportOrdering;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "auto_delete_on_idle", @out: true, min: 0, max: 1)]
        public string @AutoDeleteOnIdle { get; }

        [nterraform.Core.TerraformProperty(name: "dead_lettering_on_message_expiration", @out: false, min: 0, max: 1)]
        public bool? @DeadLetteringOnMessageExpiration { get; }

        [nterraform.Core.TerraformProperty(name: "default_message_ttl", @out: true, min: 0, max: 1)]
        public string @DefaultMessageTtl { get; }

        [nterraform.Core.TerraformProperty(name: "duplicate_detection_history_time_window", @out: true, min: 0, max: 1)]
        public string @DuplicateDetectionHistoryTimeWindow { get; }

        [nterraform.Core.TerraformProperty(name: "enable_batched_operations", @out: false, min: 0, max: 1)]
        public bool? @EnableBatchedOperations { get; }

        [nterraform.Core.TerraformProperty(name: "enable_express", @out: false, min: 0, max: 1)]
        public bool? @EnableExpress { get; }

        [nterraform.Core.TerraformProperty(name: "enable_partitioning", @out: false, min: 0, max: 1)]
        public bool? @EnablePartitioning { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "lock_duration", @out: true, min: 0, max: 1)]
        public string @LockDuration { get; }

        [nterraform.Core.TerraformProperty(name: "max_size_in_megabytes", @out: true, min: 0, max: 1)]
        public int? @MaxSizeInMegabytes { get; }

        [nterraform.Core.TerraformProperty(name: "requires_duplicate_detection", @out: false, min: 0, max: 1)]
        public bool? @RequiresDuplicateDetection { get; }

        [nterraform.Core.TerraformProperty(name: "requires_session", @out: false, min: 0, max: 1)]
        public bool? @RequiresSession { get; }

        [nterraform.Core.TerraformProperty(name: "support_ordering", @out: false, min: 0, max: 1)]
        public bool? @SupportOrdering { get; }
    }

}
