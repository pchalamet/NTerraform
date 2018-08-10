using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_key_vault_access_policy : NTerraform.resource
    {
        public azurerm_key_vault_access_policy(List<string> @keyPermissions,
                                               string @objectId,
                                               string @resourceGroupName,
                                               List<string> @secretPermissions,
                                               string @tenantId,
                                               string @vaultName,
                                               string @applicationId = null,
                                               List<string> @certificatePermissions = null)
        {
            @KeyPermissions = @keyPermissions;
            @ObjectId = @objectId;
            @ResourceGroupName = @resourceGroupName;
            @SecretPermissions = @secretPermissions;
            @TenantId = @tenantId;
            @VaultName = @vaultName;
            @ApplicationId = @applicationId;
            @CertificatePermissions = @certificatePermissions;
        }

        public List<string> @KeyPermissions { get; }
        public string @ObjectId { get; }
        public string @ResourceGroupName { get; }
        public List<string> @SecretPermissions { get; }
        public string @TenantId { get; }
        public string @VaultName { get; }
        public string @ApplicationId { get; }
        public List<string> @CertificatePermissions { get; }
    }

}
