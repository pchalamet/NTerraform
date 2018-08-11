using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_notification_hub")]
    public sealed class azurerm_notification_hub : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "apns_credential")]
        public sealed class apns_credential
        {
            public apns_credential()
            {
            }

            [TerraformProperty(name: "application_mode", @out: true, nested: false, min: 0, max: 1)]
            public string @ApplicationMode { get; }

            [TerraformProperty(name: "bundle_id", @out: true, nested: false, min: 0, max: 1)]
            public string @BundleId { get; }

            [TerraformProperty(name: "key_id", @out: true, nested: false, min: 0, max: 1)]
            public string @KeyId { get; }

            [TerraformProperty(name: "team_id", @out: true, nested: false, min: 0, max: 1)]
            public string @TeamId { get; }

            [TerraformProperty(name: "token", @out: true, nested: false, min: 0, max: 1)]
            public string @Token { get; }
        }

        [TerraformStructure(category: "", typeName: "gcm_credential")]
        public sealed class gcm_credential
        {
            public gcm_credential()
            {
            }

            [TerraformProperty(name: "api_key", @out: true, nested: false, min: 0, max: 1)]
            public string @ApiKey { get; }
        }

        public azurerm_notification_hub(string @name,
                                        string @namespaceName,
                                        string @resourceGroupName,
                                        apns_credential[] @apnsCredential = null,
                                        gcm_credential[] @gcmCredential = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @ApnsCredential = @apnsCredential;
            @GcmCredential = @gcmCredential;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, nested: true, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "apns_credential", @out: false, nested: true, min: 0, max: 0)]
        public apns_credential[] @ApnsCredential { get; }

        [TerraformProperty(name: "gcm_credential", @out: false, nested: true, min: 0, max: 0)]
        public gcm_credential[] @GcmCredential { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }
    }

}
