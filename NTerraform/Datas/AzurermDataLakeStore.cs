using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_data_lake_store : NTerraform.data
    {
        public azurerm_data_lake_store(string @name,
                                       string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @EncryptionState { get; }
        public string @EncryptionType { get; }
        public string @FirewallAllowAzureIps { get; }
        public string @FirewallState { get; }
        public string @Location { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Tier { get; }
    }

}
