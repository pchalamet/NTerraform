using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_key_vault_secret")]
    public sealed class azurerm_key_vault_secret : nterraform.resource
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }

        [nterraform.TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [nterraform.TerraformProperty(name: "content_type", @out: false, min: 0, max: 1)]
        public string @ContentType { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
