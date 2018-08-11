using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_key_vault")]
    public sealed class azurerm_key_vault : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku()
            {
            }

            [TerraformProperty(name: "name", @out: true, nested: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        [TerraformStructure(category: "", typeName: "access_policy")]
        public sealed class access_policy
        {
            public access_policy()
            {
            }

            [TerraformProperty(name: "application_id", @out: true, nested: false, min: 0, max: 1)]
            public string @ApplicationId { get; }

            [TerraformProperty(name: "certificate_permissions", @out: true, nested: false, min: 0, max: 1)]
            public string[] @CertificatePermissions { get; }

            [TerraformProperty(name: "key_permissions", @out: true, nested: false, min: 0, max: 1)]
            public string[] @KeyPermissions { get; }

            [TerraformProperty(name: "object_id", @out: true, nested: false, min: 0, max: 1)]
            public string @ObjectId { get; }

            [TerraformProperty(name: "secret_permissions", @out: true, nested: false, min: 0, max: 1)]
            public string[] @SecretPermissions { get; }

            [TerraformProperty(name: "tenant_id", @out: true, nested: false, min: 0, max: 1)]
            public string @TenantId { get; }
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
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "access_policy", @out: false, nested: true, min: 0, max: 0)]
        public access_policy[] @AccessPolicy { get; }

        [TerraformProperty(name: "enabled_for_deployment", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnabledForDeployment { get; }

        [TerraformProperty(name: "enabled_for_disk_encryption", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnabledForDiskEncryption { get; }

        [TerraformProperty(name: "enabled_for_template_deployment", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnabledForTemplateDeployment { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 0, max: 0)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "tenant_id", @out: true, nested: true, min: 0, max: 1)]
        public string @TenantId { get; }

        [TerraformProperty(name: "vault_uri", @out: true, nested: true, min: 0, max: 1)]
        public string @VaultUri { get; }
    }

}
