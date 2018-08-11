using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_key_vault_access_policy")]
    public sealed class azurerm_key_vault_access_policy : NTerraform.data
    {
        public azurerm_key_vault_access_policy(string @name)
        {
            @Name = @name;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "certificate_permissions", @out: true, min: 0, max: 1)]
        public string[] @CertificatePermissions { get; }

        [TerraformProperty(name: "key_permissions", @out: true, min: 0, max: 1)]
        public string[] @KeyPermissions { get; }

        [TerraformProperty(name: "secret_permissions", @out: true, min: 0, max: 1)]
        public string[] @SecretPermissions { get; }
    }

}
