using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_topic")]
    public sealed class azurerm_servicebus_topic : nterraform.resource
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

        [nterraform.TerraformProperty(name: "default_message_ttl", @out: true, min: 0, max: 1)]
        public string @DefaultMessageTtl { get; }

        [nterraform.TerraformProperty(name: "duplicate_detection_history_time_window", @out: true, min: 0, max: 1)]
        public string @DuplicateDetectionHistoryTimeWindow { get; }

        [nterraform.TerraformProperty(name: "enable_batched_operations", @out: false, min: 0, max: 1)]
        public bool? @EnableBatchedOperations { get; }

        [nterraform.TerraformProperty(name: "enable_express", @out: false, min: 0, max: 1)]
        public bool? @EnableExpress { get; }

        [nterraform.TerraformProperty(name: "enable_filtering_messages_before_publishing", @out: false, min: 0, max: 1)]
        public bool? @EnableFilteringMessagesBeforePublishing { get; }

        [nterraform.TerraformProperty(name: "enable_partitioning", @out: false, min: 0, max: 1)]
        public bool? @EnablePartitioning { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "max_size_in_megabytes", @out: true, min: 0, max: 1)]
        public int? @MaxSizeInMegabytes { get; }

        [nterraform.TerraformProperty(name: "requires_duplicate_detection", @out: false, min: 0, max: 1)]
        public bool? @RequiresDuplicateDetection { get; }

        [nterraform.TerraformProperty(name: "status", @out: false, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "support_ordering", @out: false, min: 0, max: 1)]
        public bool? @SupportOrdering { get; }
    }

}
