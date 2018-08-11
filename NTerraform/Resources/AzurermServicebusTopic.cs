using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public string @AutoDeleteOnIdle { get; }
        public string @DefaultMessageTtl { get; }
        public string @DuplicateDetectionHistoryTimeWindow { get; }
        public bool? @EnableBatchedOperations { get; }
        public bool? @EnableExpress { get; }
        public bool? @EnableFilteringMessagesBeforePublishing { get; }
        public bool? @EnablePartitioning { get; }
        public string @Location { get; }
        public int? @MaxSizeInMegabytes { get; }
        public bool? @RequiresDuplicateDetection { get; }
        public string @Status { get; }
        public bool? @SupportOrdering { get; }
    }

}
