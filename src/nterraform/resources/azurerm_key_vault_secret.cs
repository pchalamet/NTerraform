using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_key_vault_secret")]
    public sealed class azurerm_key_vault_secret : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }

        [nterraform.Core.TerraformProperty(name: "vault_uri", @out: false, min: 1, max: 1)]
        public string @VaultUri { get; }

        [nterraform.Core.TerraformProperty(name: "content_type", @out: false, min: 0, max: 1)]
        public string @ContentType { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
