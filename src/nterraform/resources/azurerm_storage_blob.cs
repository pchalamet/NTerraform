using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_storage_blob")]
    public sealed class azurerm_storage_blob : nterraform.Core.resource
    {
        public azurerm_storage_blob(string @name,
                                    string @resourceGroupName,
                                    string @storageAccountName,
                                    string @storageContainerName,
                                    FSharpOption<int> @attempts = null,
                                    FSharpOption<string> @contentType = null,
                                    FSharpOption<int> @parallelism = null,
                                    FSharpOption<int> @size = null,
                                    FSharpOption<string> @source = null,
                                    FSharpOption<string> @sourceUri = null,
                                    FSharpOption<string> @type = null)
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "storage_account_name", @out: false, min: 1, max: 1)]
        public string @StorageAccountName { get; }

        [nterraform.Core.TerraformProperty(name: "storage_container_name", @out: false, min: 1, max: 1)]
        public string @StorageContainerName { get; }

        [nterraform.Core.TerraformProperty(name: "attempts", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @Attempts { get; }

        [nterraform.Core.TerraformProperty(name: "content_type", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @ContentType { get; }

        [nterraform.Core.TerraformProperty(name: "parallelism", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @Parallelism { get; }

        [nterraform.Core.TerraformProperty(name: "size", @out: false, min: 0, max: 1)]
        public FSharpOption<int> @Size { get; }

        [nterraform.Core.TerraformProperty(name: "source", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Source { get; }

        [nterraform.Core.TerraformProperty(name: "source_uri", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @SourceUri { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Type { get; }

        [nterraform.Core.TerraformProperty(name: "url", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Url { get; }
    }

}
