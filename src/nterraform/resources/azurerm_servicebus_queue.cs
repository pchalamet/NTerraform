using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_queue")]
    public sealed class azurerm_servicebus_queue : nterraform.resource
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "auto_delete_on_idle", @out: true, min: 0, max: 1)]
        public string @AutoDeleteOnIdle { get; }

        [nterraform.TerraformProperty(name: "dead_lettering_on_message_expiration", @out: false, min: 0, max: 1)]
        public bool? @DeadLetteringOnMessageExpiration { get; }

        [nterraform.TerraformProperty(name: "default_message_ttl", @out: true, min: 0, max: 1)]
        public string @DefaultMessageTtl { get; }

        [nterraform.TerraformProperty(name: "duplicate_detection_history_time_window", @out: true, min: 0, max: 1)]
        public string @DuplicateDetectionHistoryTimeWindow { get; }

        [nterraform.TerraformProperty(name: "enable_batched_operations", @out: false, min: 0, max: 1)]
        public bool? @EnableBatchedOperations { get; }

        [nterraform.TerraformProperty(name: "enable_express", @out: false, min: 0, max: 1)]
        public bool? @EnableExpress { get; }

        [nterraform.TerraformProperty(name: "enable_partitioning", @out: false, min: 0, max: 1)]
        public bool? @EnablePartitioning { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "lock_duration", @out: true, min: 0, max: 1)]
        public string @LockDuration { get; }

        [nterraform.TerraformProperty(name: "max_size_in_megabytes", @out: true, min: 0, max: 1)]
        public int? @MaxSizeInMegabytes { get; }

        [nterraform.TerraformProperty(name: "requires_duplicate_detection", @out: false, min: 0, max: 1)]
        public bool? @RequiresDuplicateDetection { get; }

        [nterraform.TerraformProperty(name: "requires_session", @out: false, min: 0, max: 1)]
        public bool? @RequiresSession { get; }

        [nterraform.TerraformProperty(name: "support_ordering", @out: false, min: 0, max: 1)]
        public bool? @SupportOrdering { get; }
    }

}
