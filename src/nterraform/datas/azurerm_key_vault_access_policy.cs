using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_key_vault_access_policy")]
    public sealed class azurerm_key_vault_access_policy : nterraform.Core.data
    {
        public azurerm_key_vault_access_policy(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_permissions", @out: true, min: 0, max: 1)]
        public string[] @CertificatePermissions { get; }

        [nterraform.Core.TerraformProperty(name: "key_permissions", @out: true, min: 0, max: 1)]
        public string[] @KeyPermissions { get; }

        [nterraform.Core.TerraformProperty(name: "secret_permissions", @out: true, min: 0, max: 1)]
        public string[] @SecretPermissions { get; }
    }

}
