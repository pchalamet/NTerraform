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
        }

        [TerraformProperty(name: "key_opts", @out: false, nested: true, min: 1, max: 1)]
        public string[] @KeyOpts { get; }

        [TerraformProperty(name: "key_size", @out: false, nested: true, min: 1, max: 1)]
        public int @KeySize { get; }

        [TerraformProperty(name: "key_type", @out: false, nested: true, min: 1, max: 1)]
        public string @KeyType { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "vault_uri", @out: false, nested: true, min: 1, max: 1)]
        public string @VaultUri { get; }

        [TerraformProperty(name: "e", @out: true, nested: true, min: 0, max: 1)]
        public string @E { get; }

        [TerraformProperty(name: "n", @out: true, nested: true, min: 0, max: 1)]
        public string @N { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "version", @out: true, nested: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
