using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_key_vault")]
    public sealed class azurerm_key_vault : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku: NTerraform.structure
        {
            public sku(string @name)
            {
                @Name = @name;
                base._validate_();
            }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }
        }

        [TerraformStructure(category: "", typeName: "access_policy")]
        public sealed class access_policy: NTerraform.structure
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

            [TerraformProperty(name: "key_permissions", @out: false, min: 1, max: 1)]
            public string[] @KeyPermissions { get; }

            [TerraformProperty(name: "object_id", @out: false, min: 1, max: 1)]
            public string @ObjectId { get; }

            [TerraformProperty(name: "secret_permissions", @out: false, min: 1, max: 1)]
            public string[] @SecretPermissions { get; }

            [TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
            public string @TenantId { get; }

            [TerraformProperty(name: "application_id", @out: false, min: 0, max: 1)]
            public string @ApplicationId { get; }

            [TerraformProperty(name: "certificate_permissions", @out: false, min: 0, max: 1)]
            public string[] @CertificatePermissions { get; }
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

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, min: 1, max: 0)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
        public string @TenantId { get; }

        [TerraformProperty(name: "access_policy", @out: false, min: 0, max: 16)]
        public access_policy[] @AccessPolicy { get; }

        [TerraformProperty(name: "enabled_for_deployment", @out: false, min: 0, max: 1)]
        public bool? @EnabledForDeployment { get; }

        [TerraformProperty(name: "enabled_for_disk_encryption", @out: false, min: 0, max: 1)]
        public bool? @EnabledForDiskEncryption { get; }

        [TerraformProperty(name: "enabled_for_template_deployment", @out: false, min: 0, max: 1)]
        public bool? @EnabledForTemplateDeployment { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "vault_uri", @out: true, min: 0, max: 1)]
        public string @VaultUri { get; }
    }

}
