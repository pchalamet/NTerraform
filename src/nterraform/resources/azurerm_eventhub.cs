using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_eventhub")]
    public sealed class azurerm_eventhub : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "capture_description")]
        public sealed class capture_description : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "destination")]
            public sealed class destination : nterraform.Core.structure
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

                [nterraform.Core.TerraformProperty(name: "archive_name_format", @out: false, min: 1, max: 1)]
                public string @ArchiveNameFormat { get; }

                [nterraform.Core.TerraformProperty(name: "blob_container_name", @out: false, min: 1, max: 1)]
                public string @BlobContainerName { get; }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "storage_account_id", @out: false, min: 1, max: 1)]
                public string @StorageAccountId { get; }
            }

            public capture_description(FSharpList<destination> @destination,
                                       bool @enabled,
                                       string @encoding,
                                       FSharpOption<int> @intervalInSeconds = null,
                                       FSharpOption<int> @sizeLimitInBytes = null)
            {
                @Destination = @destination;
                @Enabled = @enabled;
                @Encoding = @encoding;
                @IntervalInSeconds = @intervalInSeconds;
                @SizeLimitInBytes = @sizeLimitInBytes;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "destination", @out: false, min: 1, max: 1)]
            public FSharpList<destination> @Destination { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "encoding", @out: false, min: 1, max: 1)]
            public string @Encoding { get; }

            [nterraform.Core.TerraformProperty(name: "interval_in_seconds", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @IntervalInSeconds { get; }

            [nterraform.Core.TerraformProperty(name: "size_limit_in_bytes", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @SizeLimitInBytes { get; }
        }

        public azurerm_eventhub(int @messageRetention,
                                string @name,
                                string @namespaceName,
                                int @partitionCount,
                                string @resourceGroupName,
                                FSharpOption<FSharpList<capture_description>> @captureDescription = null,
                                FSharpOption<string> @location = null)
        {
            @MessageRetention = @messageRetention;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @PartitionCount = @partitionCount;
            @ResourceGroupName = @resourceGroupName;
            @CaptureDescription = @captureDescription ?? FSharpList<capture_description>.Empty;
            @Location = @location;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "message_retention", @out: false, min: 1, max: 1)]
        public int @MessageRetention { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "partition_count", @out: false, min: 1, max: 1)]
        public int @PartitionCount { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "capture_description", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<capture_description>> @CaptureDescription { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "partition_ids", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @PartitionIds { get; }
    }

}
