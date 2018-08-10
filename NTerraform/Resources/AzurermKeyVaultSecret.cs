using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_key_vault_secret : NTerraform.resource
    {
        public azurerm_key_vault_secret(string @name,
                                        string @value,
                                        string @vaultUri,
                                        string @contentType = null)
        {
            @Name = @name;
            @Value = @value;
            @VaultUri = @vaultUri;
            @ContentType = @contentType;
        }

        public string @Name { get; }
        public string @Value { get; }
        public string @VaultUri { get; }
        public string @ContentType { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Version { get; }
    }

}
