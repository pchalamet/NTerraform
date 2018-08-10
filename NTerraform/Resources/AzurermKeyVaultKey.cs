using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_key_vault_key : NTerraform.resource
    {
        public azurerm_key_vault_key(List<string> @keyOpts,
                                     int @keySize,
                                     string @keyType,
                                     string @name,
                                     string @vaultUri)
        {
            @KeyOpts = @keyOpts;
            @KeySize = @keySize;
            @KeyType = @keyType;
            @Name = @name;
            @VaultUri = @vaultUri;
        }

        public List<string> @KeyOpts { get; }
        public int @KeySize { get; }
        public string @KeyType { get; }
        public string @Name { get; }
        public string @VaultUri { get; }
        public string @E { get; }
        public string @N { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Version { get; }
    }

}
