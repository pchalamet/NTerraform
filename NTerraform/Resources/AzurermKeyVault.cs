using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_key_vault : NTerraform.resource
    {
        public sealed class sku
        {
            public sku(string @name)
            {
                @Name = @name;
            }

            public string @Name { get; }
        }

        public sealed class access_policy
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
            }

            public string[] @KeyPermissions { get; }
            public string @ObjectId { get; }
            public string[] @SecretPermissions { get; }
            public string @TenantId { get; }
            public string @ApplicationId { get; }
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
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public sku[] @Sku { get; }
        public string @TenantId { get; }
        public access_policy[] @AccessPolicy { get; }
        public bool? @EnabledForDeployment { get; }
        public bool? @EnabledForDiskEncryption { get; }
        public bool? @EnabledForTemplateDeployment { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @VaultUri { get; }
    }

}
