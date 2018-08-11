using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_key_vault_secret")]
    public sealed class azurerm_key_vault_secret : NTerraform.resource
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
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }

        [TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [TerraformProperty(name: "content_type", @out: false, min: 0, max: 1)]
        public string @ContentType { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
