using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_servicebus_topic")]
    public sealed class azurerm_servicebus_topic : NTerraform.resource
    {
        public azurerm_servicebus_topic(string @name,
                                        string @namespaceName,
                                        string @resourceGroupName,
                                        bool? @enableBatchedOperations = null,
                                        bool? @enableExpress = null,
                                        bool? @enableFilteringMessagesBeforePublishing = null,
                                        bool? @enablePartitioning = null,
                                        string @location = null,
                                        bool? @requiresDuplicateDetection = null,
                                        string @status = null,
                                        bool? @supportOrdering = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @EnableBatchedOperations = @enableBatchedOperations;
            @EnableExpress = @enableExpress;
            @EnableFilteringMessagesBeforePublishing = @enableFilteringMessagesBeforePublishing;
            @EnablePartitioning = @enablePartitioning;
            @Location = @location;
            @RequiresDuplicateDetection = @requiresDuplicateDetection;
            @Status = @status;
            @SupportOrdering = @supportOrdering;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, nested: true, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "auto_delete_on_idle", @out: true, nested: true, min: 0, max: 1)]
        public string @AutoDeleteOnIdle { get; }

        [TerraformProperty(name: "default_message_ttl", @out: true, nested: true, min: 0, max: 1)]
        public string @DefaultMessageTtl { get; }

        [TerraformProperty(name: "duplicate_detection_history_time_window", @out: true, nested: true, min: 0, max: 1)]
        public string @DuplicateDetectionHistoryTimeWindow { get; }

        [TerraformProperty(name: "enable_batched_operations", @out: false, nested: true, min: 0, max: 1)]
        public bool? @EnableBatchedOperations { get; }

        [TerraformProperty(name: "enable_express", @out: false, nested: true, min: 0, max: 1)]
        public bool? @EnableExpress { get; }

        [TerraformProperty(name: "enable_filtering_messages_before_publishing", @out: false, nested: true, min: 0, max: 1)]
        public bool? @EnableFilteringMessagesBeforePublishing { get; }

        [TerraformProperty(name: "enable_partitioning", @out: false, nested: true, min: 0, max: 1)]
        public bool? @EnablePartitioning { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "max_size_in_megabytes", @out: true, nested: true, min: 0, max: 1)]
        public int? @MaxSizeInMegabytes { get; }

        [TerraformProperty(name: "requires_duplicate_detection", @out: false, nested: true, min: 0, max: 1)]
        public bool? @RequiresDuplicateDetection { get; }

        [TerraformProperty(name: "status", @out: false, nested: true, min: 0, max: 1)]
        public string @Status { get; }

        [TerraformProperty(name: "support_ordering", @out: false, nested: true, min: 0, max: 1)]
        public bool? @SupportOrdering { get; }
    }

}
