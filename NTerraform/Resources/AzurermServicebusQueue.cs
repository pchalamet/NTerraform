using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public string @AutoDeleteOnIdle { get; }
        public bool? @DeadLetteringOnMessageExpiration { get; }
        public string @DefaultMessageTtl { get; }
        public string @DuplicateDetectionHistoryTimeWindow { get; }
        public bool? @EnableBatchedOperations { get; }
        public bool? @EnableExpress { get; }
        public bool? @EnablePartitioning { get; }
        public string @Location { get; }
        public string @LockDuration { get; }
        public int? @MaxSizeInMegabytes { get; }
        public bool? @RequiresDuplicateDetection { get; }
        public bool? @RequiresSession { get; }
        public bool? @SupportOrdering { get; }
    }

}
