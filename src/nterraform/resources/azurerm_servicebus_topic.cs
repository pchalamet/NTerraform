using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_servicebus_topic")]
    public sealed class azurerm_servicebus_topic : nterraform.Core.resource
    {
        public azurerm_servicebus_topic(string @name,
                                        string @namespaceName,
                                        string @resourceGroupName,
                                        FSharpOption<bool> @enableBatchedOperations = null,
                                        FSharpOption<bool> @enableExpress = null,
                                        FSharpOption<bool> @enableFilteringMessagesBeforePublishing = null,
                                        FSharpOption<bool> @enablePartitioning = null,
                                        FSharpOption<string> @location = null,
                                        FSharpOption<bool> @requiresDuplicateDetection = null,
                                        FSharpOption<string> @status = null,
                                        FSharpOption<bool> @supportOrdering = null)
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "auto_delete_on_idle", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AutoDeleteOnIdle { get; }

        [nterraform.Core.TerraformProperty(name: "default_message_ttl", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultMessageTtl { get; }

        [nterraform.Core.TerraformProperty(name: "duplicate_detection_history_time_window", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DuplicateDetectionHistoryTimeWindow { get; }

        [nterraform.Core.TerraformProperty(name: "enable_batched_operations", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableBatchedOperations { get; }

        [nterraform.Core.TerraformProperty(name: "enable_express", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableExpress { get; }

        [nterraform.Core.TerraformProperty(name: "enable_filtering_messages_before_publishing", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnableFilteringMessagesBeforePublishing { get; }

        [nterraform.Core.TerraformProperty(name: "enable_partitioning", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnablePartitioning { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "max_size_in_megabytes", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @MaxSizeInMegabytes { get; }

        [nterraform.Core.TerraformProperty(name: "requires_duplicate_detection", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @RequiresDuplicateDetection { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Status { get; }

        [nterraform.Core.TerraformProperty(name: "support_ordering", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @SupportOrdering { get; }
    }

}
