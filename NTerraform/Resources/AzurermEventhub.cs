using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_eventhub : NTerraform.resource
    {
        public class capture_description
        {
            public class destination
            {
                public destination(string @archiveNameFormat,
                                   string @blobContainerName,
                                   string @name,
                                   string @storageAccountId)
                {
                    @ArchiveNameFormat = @archiveNameFormat;
                    @BlobContainerName = @blobContainerName;
                    @Name = @name;
                    @StorageAccountId = @storageAccountId;
                }

                public string @ArchiveNameFormat { get; }
                public string @BlobContainerName { get; }
                public string @Name { get; }
                public string @StorageAccountId { get; }
            }

            public capture_description(List<destination> @destination,
                                       bool @enabled,
                                       string @encoding,
                                       int? @intervalInSeconds = null,
                                       int? @sizeLimitInBytes = null)
            {
                @Destination = @destination;
                @Enabled = @enabled;
                @Encoding = @encoding;
                @IntervalInSeconds = @intervalInSeconds;
                @SizeLimitInBytes = @sizeLimitInBytes;
            }

            public List<destination> @Destination { get; }
            public bool @Enabled { get; }
            public string @Encoding { get; }
            public int? @IntervalInSeconds { get; }
            public int? @SizeLimitInBytes { get; }
        }

        public azurerm_eventhub(int @messageRetention,
                                string @name,
                                string @namespaceName,
                                int @partitionCount,
                                string @resourceGroupName,
                                List<capture_description> @captureDescription = null,
                                string @location = null)
        {
            @MessageRetention = @messageRetention;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @PartitionCount = @partitionCount;
            @ResourceGroupName = @resourceGroupName;
            @CaptureDescription = @captureDescription;
            @Location = @location;
        }

        public int @MessageRetention { get; }
        public string @Name { get; }
        public string @NamespaceName { get; }
        public int @PartitionCount { get; }
        public string @ResourceGroupName { get; }
        public List<capture_description> @CaptureDescription { get; }
        public string @Location { get; }
        public HashSet<string> @PartitionIds { get; }
    }

}
