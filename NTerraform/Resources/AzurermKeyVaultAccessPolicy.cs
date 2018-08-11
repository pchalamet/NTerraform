using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_key_vault_access_policy : NTerraform.resource
    {
        public azurerm_key_vault_access_policy(string[] @keyPermissions,
                                               string @objectId,
                                               string @resourceGroupName,
                                               string[] @secretPermissions,
                                               string @tenantId,
                                               string @vaultName,
                                               string @applicationId = null,
                                               string[] @certificatePermissions = null)
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

        public string[] @KeyPermissions { get; }
        public string @ObjectId { get; }
        public string @ResourceGroupName { get; }
        public string[] @SecretPermissions { get; }
        public string @TenantId { get; }
        public string @VaultName { get; }
        public string @ApplicationId { get; }
        public string[] @CertificatePermissions { get; }
    }

}
