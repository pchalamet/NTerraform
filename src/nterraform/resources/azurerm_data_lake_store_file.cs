using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_data_lake_store_file")]
    public sealed class azurerm_data_lake_store_file : nterraform.Core.resource
    {
        public azurerm_data_lake_store_file(string @accountName,
                                            string @localFilePath,
                                            string @remoteFilePath)
        {
            @AccountName = @accountName;
            @LocalFilePath = @localFilePath;
            @RemoteFilePath = @remoteFilePath;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "account_name", @out: false, min: 1, max: 1)]
        public string @AccountName { get; }

        [nterraform.Core.TerraformProperty(name: "local_file_path", @out: false, min: 1, max: 1)]
        public string @LocalFilePath { get; }

        [nterraform.Core.TerraformProperty(name: "remote_file_path", @out: false, min: 1, max: 1)]
        public string @RemoteFilePath { get; }
    }

}
