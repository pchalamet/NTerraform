using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_key_vault_access_policy")]
    public sealed class azurerm_key_vault_access_policy : nterraform.data
    {
        public azurerm_key_vault_access_policy(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "certificate_permissions", @out: true, min: 0, max: 1)]
        public string[] @CertificatePermissions { get; }

        [nterraform.TerraformProperty(name: "key_permissions", @out: true, min: 0, max: 1)]
        public string[] @KeyPermissions { get; }

        [nterraform.TerraformProperty(name: "secret_permissions", @out: true, min: 0, max: 1)]
        public string[] @SecretPermissions { get; }
    }

}
