using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_key_vault_access_policy : NTerraform.data
    {
        public azurerm_key_vault_access_policy(string @name)
        {
            @Name = @name;
        }

        public string @Name { get; }
        public string[] @CertificatePermissions { get; }
        public string[] @KeyPermissions { get; }
        public string[] @SecretPermissions { get; }
    }

}
