using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_key_vault_access_policy")]
    public sealed class azurerm_key_vault_access_policy : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "key_permissions", @out: false, min: 1, max: 1)]
        public string[] @KeyPermissions { get; }

        [nterraform.TerraformProperty(name: "object_id", @out: false, min: 1, max: 1)]
        public string @ObjectId { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "secret_permissions", @out: false, min: 1, max: 1)]
        public string[] @SecretPermissions { get; }

        [nterraform.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
        public string @TenantId { get; }

        [nterraform.TerraformProperty(name: "vault_name", @out: false, min: 1, max: 1)]
        public string @VaultName { get; }

        [nterraform.TerraformProperty(name: "application_id", @out: false, min: 0, max: 1)]
        public string @ApplicationId { get; }

        [nterraform.TerraformProperty(name: "certificate_permissions", @out: false, min: 0, max: 1)]
        public string[] @CertificatePermissions { get; }
    }

}
