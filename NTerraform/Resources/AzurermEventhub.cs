using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_eventhub")]
    public sealed class azurerm_eventhub : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "capture_description")]
        public sealed class capture_description: NTerraform.structure
        {
            [TerraformStructure(category: "", typeName: "destination")]
            public sealed class destination: NTerraform.structure
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
                    base._validate_();
                }

                [TerraformProperty(name: "archive_name_format", @out: false, min: 1, max: 1)]
                public string @ArchiveNameFormat { get; }

                [TerraformProperty(name: "blob_container_name", @out: false, min: 1, max: 1)]
                public string @BlobContainerName { get; }

                [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [TerraformProperty(name: "storage_account_id", @out: false, min: 1, max: 1)]
                public string @StorageAccountId { get; }
            }

            public capture_description(destination[] @destination,
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
                base._validate_();
            }

            [TerraformProperty(name: "destination", @out: false, min: 1, max: 1)]
            public destination[] @Destination { get; }

            [TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [TerraformProperty(name: "encoding", @out: false, min: 1, max: 1)]
            public string @Encoding { get; }

            [TerraformProperty(name: "interval_in_seconds", @out: false, min: 0, max: 1)]
            public int? @IntervalInSeconds { get; }

            [TerraformProperty(name: "size_limit_in_bytes", @out: false, min: 0, max: 1)]
            public int? @SizeLimitInBytes { get; }
        }

        public azurerm_eventhub(int @messageRetention,
                                string @name,
                                string @namespaceName,
                                int @partitionCount,
                                string @resourceGroupName,
                                capture_description[] @captureDescription = null,
                                string @location = null)
        {
            @MessageRetention = @messageRetention;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @PartitionCount = @partitionCount;
            @ResourceGroupName = @resourceGroupName;
            @CaptureDescription = @captureDescription;
            @Location = @location;
            base._validate_();
        }

        [TerraformProperty(name: "message_retention", @out: false, min: 1, max: 1)]
        public int @MessageRetention { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "partition_count", @out: false, min: 1, max: 1)]
        public int @PartitionCount { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "capture_description", @out: false, min: 0, max: 1)]
        public capture_description[] @CaptureDescription { get; }

        [TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "partition_ids", @out: true, min: 0, max: 1)]
        public string[] @PartitionIds { get; }
    }

}
