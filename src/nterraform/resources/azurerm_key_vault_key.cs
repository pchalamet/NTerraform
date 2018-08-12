using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_key_vault_key")]
    public sealed class azurerm_key_vault_key : nterraform.Core.resource
    {
        public azurerm_key_vault_key(FSharpList<string> @keyOpts,
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

        [nterraform.Core.TerraformProperty(name: "key_opts", @out: false, min: 1, max: 1)]
        public FSharpList<string> @KeyOpts { get; }

        [nterraform.Core.TerraformProperty(name: "key_size", @out: false, min: 1, max: 1)]
        public int @KeySize { get; }

        [nterraform.Core.TerraformProperty(name: "key_type", @out: false, min: 1, max: 1)]
        public string @KeyType { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [nterraform.Core.TerraformProperty(name: "e", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @E { get; }

        [nterraform.Core.TerraformProperty(name: "n", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @N { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Version { get; }
    }

}
