using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_key_vault_secret")]
    public sealed class azurerm_key_vault_secret : nterraform.data
    {
        public azurerm_key_vault_secret(string @name,
                                        string @vaultUri)
        {
            @Name = @name;
            @VaultUri = @vaultUri;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [nterraform.TerraformProperty(name: "content_type", @out: true, min: 0, max: 1)]
        public string @ContentType { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
        public string @Value { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
