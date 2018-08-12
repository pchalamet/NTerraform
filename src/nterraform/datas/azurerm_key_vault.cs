using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_key_vault")]
    public sealed class azurerm_key_vault : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "access_policy")]
        public sealed class access_policy : nterraform.Core.structure
        {
            public access_policy()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "application_id", @out: true, min: 0, max: 1)]
            public string @ApplicationId { get; }

            [nterraform.Core.TerraformProperty(name: "certificate_permissions", @out: true, min: 0, max: 1)]
            public string[] @CertificatePermissions { get; }

            [nterraform.Core.TerraformProperty(name: "key_permissions", @out: true, min: 0, max: 1)]
            public string[] @KeyPermissions { get; }

            [nterraform.Core.TerraformProperty(name: "object_id", @out: true, min: 0, max: 1)]
            public string @ObjectId { get; }

            [nterraform.Core.TerraformProperty(name: "secret_permissions", @out: true, min: 0, max: 1)]
            public string[] @SecretPermissions { get; }

            [nterraform.Core.TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
            public string @TenantId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
        {
            public sku()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }
        }

        public azurerm_key_vault(string @name,
                                 string @resourceGroupName,
                                 access_policy[] @accessPolicy = null,
                                 sku[] @sku = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @AccessPolicy = @accessPolicy;
            @Sku = @sku;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "access_policy", @out: false, min: 0, max: 0)]
        public access_policy[] @AccessPolicy { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_deployment", @out: true, min: 0, max: 1)]
        public bool? @EnabledForDeployment { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_disk_encryption", @out: true, min: 0, max: 1)]
        public bool? @EnabledForDiskEncryption { get; }

        [nterraform.Core.TerraformProperty(name: "enabled_for_template_deployment", @out: true, min: 0, max: 1)]
        public bool? @EnabledForTemplateDeployment { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 0, max: 0)]
        public sku[] @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
        public string @TenantId { get; }

        [nterraform.Core.TerraformProperty(name: "vault_uri", @out: true, min: 0, max: 1)]
        public string @VaultUri { get; }
    }

}
