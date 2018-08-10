using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_storage_blob : NTerraform.resource
    {
        public azurerm_storage_blob(string @name,
                                    string @resourceGroupName,
                                    string @storageAccountName,
                                    string @storageContainerName,
                                    int? @attempts = null,
                                    string @contentType = null,
                                    int? @parallelism = null,
                                    int? @size = null,
                                    string @source = null,
                                    string @sourceUri = null,
                                    string @type = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageAccountName = @storageAccountName;
            @StorageContainerName = @storageContainerName;
            @Attempts = @attempts;
            @ContentType = @contentType;
            @Parallelism = @parallelism;
            @Size = @size;
            @Source = @source;
            @SourceUri = @sourceUri;
            @Type = @type;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @StorageAccountName { get; }
        public string @StorageContainerName { get; }
        public int? @Attempts { get; }
        public string @ContentType { get; }
        public int? @Parallelism { get; }
        public int? @Size { get; }
        public string @Source { get; }
        public string @SourceUri { get; }
        public string @Type { get; }
        public string @Url { get; }
    }

}
