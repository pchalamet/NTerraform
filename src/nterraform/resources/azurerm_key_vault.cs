using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_key_vault")]
    public sealed class azurerm_key_vault : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
        {
            public sku(string @name)
            {
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "access_policy")]
        public sealed class access_policy : nterraform.Core.structure
        {
            public access_policy(FSharpList<string> @keyPermissions,
                                 string @objectId,
                                 FSharpList<string> @secretPermissions,
                                 string @tenantId,
                                 FSharpOption<string> @applicationId = null,
                                 FSharpOption<FSharpList<string>> @certificatePermissions = null)
            {
                @KeyPermissions = @keyPermissions;
                @ObjectId = @objectId;
                @SecretPermissions = @secretPermissions;
                @TenantId = @tenantId;
                @ApplicationId = @applicationId;
                @CertificatePermissions = @certificatePermissions ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "key_permissions", @out: false, min: 1, max: 1)]
            public FSharpList<string> @KeyPermissions { get; }

            [nterraform.Core.TerraformProperty(name: "object_id", @out: false, min: 1, max: 1)]
            public string @ObjectId { get; }

            [nterraform.Core.TerraformProperty(name: "secret_permissions", @out: false, min: 1, max: 1)]
            public FSharpList<string> @SecretPermissions { get; }

            [nterraform.Core.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
            public string @TenantId { get; }

            [nterraform.Core.TerraformProperty(name: "application_id", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @ApplicationId { get; }

            [nterraform.Core.TerraformProperty(name: "certificate_permissions", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @CertificatePermissions { get; }
        }

        public azurerm_key_vault(string @location,
                                 string @name,
                                 string @resourceGroupName,
                                 FSharpList<sku> @sku,
                                 string @tenantId,
                                 FSharpOption<FSharpList<access_policy>> @accessPolicy = null,
                                 FSharpOption<bool> @enabledForDeployment = null,
                                 FSharpOption<bool> @enabledForDiskEncryption = null,
                                 FSharpOption<bool> @enabledForTemplateDeployment = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @TenantId = @tenantId;
            @AccessPolicy = @accessPolicy ?? FSharpList<access_policy>.Empty;
            @EnabledForDeployment = @enabledForDeployment;
            @EnabledForDiskEncryption = @enabledForDiskEncryption;
            @EnabledForTemplateDeployment = @enabledForTemplateDeployment;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 0)]
        public FSharpList<sku> @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
        public string @TenantId { get; }

        [nterraform.Core.TerraformProperty(name: "access_policy", @out: false, min: 0, max: 16)]
        public FSharpOption<FSharpList<access_policy>> @AccessPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_deployment", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnabledForDeployment { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_disk_encryption", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnabledForDiskEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_template_deployment", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @EnabledForTemplateDeployment { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vault_uri", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @VaultUri { get; }
    }

}
