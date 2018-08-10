using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_data_lake_store_file : NTerraform.resource
    {
        public azurerm_data_lake_store_file(string @accountName,
                                            string @localFilePath,
                                            string @remoteFilePath)
        {
            @AccountName = @accountName;
            @LocalFilePath = @localFilePath;
            @RemoteFilePath = @remoteFilePath;
        }

        public string @AccountName { get; }
        public string @LocalFilePath { get; }
        public string @RemoteFilePath { get; }
    }

}
