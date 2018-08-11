using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_key_vault_access_policy")]
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

        [TerraformProperty(name: "key_permissions", @out: false, nested: true, min: 1, max: 1)]
        public string[] @KeyPermissions { get; }

        [TerraformProperty(name: "object_id", @out: false, nested: true, min: 1, max: 1)]
        public string @ObjectId { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "secret_permissions", @out: false, nested: true, min: 1, max: 1)]
        public string[] @SecretPermissions { get; }

        [TerraformProperty(name: "tenant_id", @out: false, nested: true, min: 1, max: 1)]
        public string @TenantId { get; }

        [TerraformProperty(name: "vault_name", @out: false, nested: true, min: 1, max: 1)]
        public string @VaultName { get; }

        [TerraformProperty(name: "application_id", @out: false, nested: true, min: 0, max: 1)]
        public string @ApplicationId { get; }

        [TerraformProperty(name: "certificate_permissions", @out: false, nested: true, min: 0, max: 1)]
        public string[] @CertificatePermissions { get; }
    }

}
