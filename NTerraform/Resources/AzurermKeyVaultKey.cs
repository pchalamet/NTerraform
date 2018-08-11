using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_key_vault_key")]
    public sealed class azurerm_key_vault_key : NTerraform.resource
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

        [TerraformProperty(name: "key_opts", @out: false, min: 1, max: 1)]
        public string[] @KeyOpts { get; }

        [TerraformProperty(name: "key_size", @out: false, min: 1, max: 1)]
        public int @KeySize { get; }

        [TerraformProperty(name: "key_type", @out: false, min: 1, max: 1)]
        public string @KeyType { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [TerraformProperty(name: "e", @out: true, min: 0, max: 1)]
        public string @E { get; }

        [TerraformProperty(name: "n", @out: true, min: 0, max: 1)]
        public string @N { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
