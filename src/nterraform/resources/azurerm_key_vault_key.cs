using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_key_vault_key")]
    public sealed class azurerm_key_vault_key : nterraform.resource
    {
        public azurerm_key_vault_key(string[] @keyOpts,
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "key_opts", @out: false, min: 1, max: 1)]
        public string[] @KeyOpts { get; }

        [nterraform.TerraformProperty(name: "key_size", @out: false, min: 1, max: 1)]
        public int @KeySize { get; }

        [nterraform.TerraformProperty(name: "key_type", @out: false, min: 1, max: 1)]
        public string @KeyType { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [nterraform.TerraformProperty(name: "e", @out: true, min: 0, max: 1)]
        public string @E { get; }

        [nterraform.TerraformProperty(name: "n", @out: true, min: 0, max: 1)]
        public string @N { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
