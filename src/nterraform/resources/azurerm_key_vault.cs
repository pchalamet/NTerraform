using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_key_vault")]
    public sealed class azurerm_key_vault : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "access_policy")]
        public sealed class access_policy : nterraform.Core.structure
        {
            public access_policy(string[] @keyPermissions,
                                 string @objectId,
                                 string[] @secretPermissions,
                                 string @tenantId,
                                 string @applicationId = null,
                                 string[] @certificatePermissions = null)
            {
                @KeyPermissions = @keyPermissions;
                @ObjectId = @objectId;
                @SecretPermissions = @secretPermissions;
                @TenantId = @tenantId;
                @ApplicationId = @applicationId;
                @CertificatePermissions = @certificatePermissions;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "key_permissions", @out: false, min: 1, max: 1)]
            public string[] @KeyPermissions { get; }

            [nterraform.Core.TerraformProperty(name: "object_id", @out: false, min: 1, max: 1)]
            public string @ObjectId { get; }

            [nterraform.Core.TerraformProperty(name: "secret_permissions", @out: false, min: 1, max: 1)]
            public string[] @SecretPermissions { get; }

            [nterraform.Core.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
            public string @TenantId { get; }

            [nterraform.Core.TerraformProperty(name: "application_id", @out: false, min: 0, max: 1)]
            public string @ApplicationId { get; }

            [nterraform.Core.TerraformProperty(name: "certificate_permissions", @out: false, min: 0, max: 1)]
            public string[] @CertificatePermissions { get; }
        }

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

        public azurerm_key_vault(string @location,
                                 string @name,
                                 string @resourceGroupName,
                                 sku[] @sku,
                                 string @tenantId,
                                 access_policy[] @accessPolicy = null,
                                 bool? @enabledForDeployment = null,
                                 bool? @enabledForDiskEncryption = null,
                                 bool? @enabledForTemplateDeployment = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @TenantId = @tenantId;
            @AccessPolicy = @accessPolicy;
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
        public sku[] @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
        public string @TenantId { get; }

        [nterraform.Core.TerraformProperty(name: "access_policy", @out: false, min: 0, max: 16)]
        public access_policy[] @AccessPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_deployment", @out: false, min: 0, max: 1)]
        public bool? @EnabledForDeployment { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_disk_encryption", @out: false, min: 0, max: 1)]
        public bool? @EnabledForDiskEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_template_deployment", @out: false, min: 0, max: 1)]
        public bool? @EnabledForTemplateDeployment { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vault_uri", @out: true, min: 0, max: 1)]
        public string @VaultUri { get; }
    }

}
