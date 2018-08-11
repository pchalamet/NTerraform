using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_key_vault : NTerraform.data
    {
        public class sku
        {
            public sku()
            {
            }

            public string @Name { get; }
        }

        public class access_policy
        {
            public access_policy()
            {
            }

            public string @ApplicationId { get; }
            public string[] @CertificatePermissions { get; }
            public string[] @KeyPermissions { get; }
            public string @ObjectId { get; }
            public string[] @SecretPermissions { get; }
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

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public access_policy[] @AccessPolicy { get; }
        public bool? @EnabledForDeployment { get; }
        public bool? @EnabledForDiskEncryption { get; }
        public bool? @EnabledForTemplateDeployment { get; }
        public string @Location { get; }
        public sku[] @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @TenantId { get; }
        public string @VaultUri { get; }
    }

}
