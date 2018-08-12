using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_key_vault_access_policy")]
    public sealed class azurerm_key_vault_access_policy : nterraform.Core.resource
    {
        public azurerm_key_vault_access_policy(FSharpList<string> @keyPermissions,
                                               string @objectId,
                                               string @resourceGroupName,
                                               FSharpList<string> @secretPermissions,
                                               string @tenantId,
                                               string @vaultName,
                                               string @applicationId = null,
                                               FSharpList<string> @certificatePermissions = null)
        {
            @KeyPermissions = @keyPermissions;
            @ObjectId = @objectId;
            @ResourceGroupName = @resourceGroupName;
            @SecretPermissions = @secretPermissions;
            @TenantId = @tenantId;
            @VaultName = @vaultName;
            @ApplicationId = @applicationId;
            @CertificatePermissions = @certificatePermissions ?? FSharpList<string>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "key_permissions", @out: false, min: 1, max: 1)]
        public FSharpList<string> @KeyPermissions { get; }

        [nterraform.Core.TerraformProperty(name: "object_id", @out: false, min: 1, max: 1)]
        public string @ObjectId { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "secret_permissions", @out: false, min: 1, max: 1)]
        public FSharpList<string> @SecretPermissions { get; }

        [nterraform.Core.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
        public string @TenantId { get; }

        [nterraform.Core.TerraformProperty(name: "vault_name", @out: false, min: 1, max: 1)]
        public string @VaultName { get; }

        [nterraform.Core.TerraformProperty(name: "application_id", @out: false, min: 0, max: 1)]
        public string @ApplicationId { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_permissions", @out: false, min: 0, max: 1)]
        public FSharpList<string> @CertificatePermissions { get; }
    }

}
