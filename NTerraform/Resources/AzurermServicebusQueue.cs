using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_servicebus_queue")]
    public sealed class azurerm_servicebus_queue : NTerraform.resource
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
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "auto_delete_on_idle", @out: true, min: 0, max: 1)]
        public string @AutoDeleteOnIdle { get; }

        [TerraformProperty(name: "dead_lettering_on_message_expiration", @out: false, min: 0, max: 1)]
        public bool? @DeadLetteringOnMessageExpiration { get; }

        [TerraformProperty(name: "default_message_ttl", @out: true, min: 0, max: 1)]
        public string @DefaultMessageTtl { get; }

        [TerraformProperty(name: "duplicate_detection_history_time_window", @out: true, min: 0, max: 1)]
        public string @DuplicateDetectionHistoryTimeWindow { get; }

        [TerraformProperty(name: "enable_batched_operations", @out: false, min: 0, max: 1)]
        public bool? @EnableBatchedOperations { get; }

        [TerraformProperty(name: "enable_express", @out: false, min: 0, max: 1)]
        public bool? @EnableExpress { get; }

        [TerraformProperty(name: "enable_partitioning", @out: false, min: 0, max: 1)]
        public bool? @EnablePartitioning { get; }

        [TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "lock_duration", @out: true, min: 0, max: 1)]
        public string @LockDuration { get; }

        [TerraformProperty(name: "max_size_in_megabytes", @out: true, min: 0, max: 1)]
        public int? @MaxSizeInMegabytes { get; }

        [TerraformProperty(name: "requires_duplicate_detection", @out: false, min: 0, max: 1)]
        public bool? @RequiresDuplicateDetection { get; }

        [TerraformProperty(name: "requires_session", @out: false, min: 0, max: 1)]
        public bool? @RequiresSession { get; }

        [TerraformProperty(name: "support_ordering", @out: false, min: 0, max: 1)]
        public bool? @SupportOrdering { get; }
    }

}
