using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_storage_blob")]
    public sealed class azurerm_storage_blob : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
        public string @StorageAccountName { get; }

        [nterraform.TerraformProperty(name: "storage_container_name", @out: false, min: 1, max: 1)]
        public string @StorageContainerName { get; }

        [nterraform.TerraformProperty(name: "attempts", @out: false, min: 0, max: 1)]
        public int? @Attempts { get; }

        [nterraform.TerraformProperty(name: "content_type", @out: false, min: 0, max: 1)]
        public string @ContentType { get; }

        [nterraform.TerraformProperty(name: "parallelism", @out: false, min: 0, max: 1)]
        public int? @Parallelism { get; }

        [nterraform.TerraformProperty(name: "size", @out: false, min: 0, max: 1)]
        public int? @Size { get; }

        [nterraform.TerraformProperty(name: "source", @out: false, min: 0, max: 1)]
        public string @Source { get; }

        [nterraform.TerraformProperty(name: "source_uri", @out: false, min: 0, max: 1)]
        public string @SourceUri { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "url", @out: true, min: 0, max: 1)]
        public string @Url { get; }
    }

}
