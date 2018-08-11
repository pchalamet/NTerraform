using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_key_vault_secret : NTerraform.data
    {
        public azurerm_key_vault_secret(string @name,
                                        string @vaultUri)
        {
            @Name = @name;
            @VaultUri = @vaultUri;
        }

        public string @Name { get; }
        public string @VaultUri { get; }
        public string @ContentType { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Value { get; }
        public string @Version { get; }
    }

}
