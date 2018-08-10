using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_key_vault : NTerraform.resource
    {
        public class access_policy
        {
            public access_policy(List<string> @keyPermissions,
                                 string @objectId,
                                 List<string> @secretPermissions,
                                 string @tenantId,
                                 string @applicationId = null,
                                 List<string> @certificatePermissions = null)
            {
                @KeyPermissions = @keyPermissions;
                @ObjectId = @objectId;
                @SecretPermissions = @secretPermissions;
                @TenantId = @tenantId;
                @ApplicationId = @applicationId;
                @CertificatePermissions = @certificatePermissions;
            }

            public List<string> @KeyPermissions { get; }
            public string @ObjectId { get; }
            public List<string> @SecretPermissions { get; }
            public string @TenantId { get; }
            public string @ApplicationId { get; }
            public List<string> @CertificatePermissions { get; }
        }

        public class sku
        {
            public sku(string @name)
            {
                @Name = @name;
            }

            public string @Name { get; }
        }

        public azurerm_key_vault(string @location,
                                 string @name,
                                 string @resourceGroupName,
                                 List<sku> @sku,
                                 string @tenantId,
                                 List<access_policy> @accessPolicy = null,
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
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public List<sku> @Sku { get; }
        public string @TenantId { get; }
        public List<access_policy> @AccessPolicy { get; }
        public bool? @EnabledForDeployment { get; }
        public bool? @EnabledForDiskEncryption { get; }
        public bool? @EnabledForTemplateDeployment { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @VaultUri { get; }
    }

}
