using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_notification_hub")]
    public sealed class azurerm_notification_hub : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "gcm_credential")]
        public sealed class gcm_credential: NTerraform.structure
        {
            public gcm_credential(string @apiKey)
            {
                @ApiKey = @apiKey;
                base._validate_();
            }

            [TerraformProperty(name: "api_key", @out: false, min: 1, max: 1)]
            public string @ApiKey { get; }
        }

        [TerraformStructure(category: "", typeName: "apns_credential")]
        public sealed class apns_credential: NTerraform.structure
        {
            public apns_credential(string @applicationMode,
                                   string @bundleId,
                                   string @keyId,
                                   string @teamId,
                                   string @token)
            {
                @ApplicationMode = @applicationMode;
                @BundleId = @bundleId;
                @KeyId = @keyId;
                @TeamId = @teamId;
                @Token = @token;
                base._validate_();
            }

            [TerraformProperty(name: "application_mode", @out: false, min: 1, max: 1)]
            public string @ApplicationMode { get; }

            [TerraformProperty(name: "bundle_id", @out: false, min: 1, max: 1)]
            public string @BundleId { get; }

            [TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
            public string @KeyId { get; }

            [TerraformProperty(name: "team_id", @out: false, min: 1, max: 1)]
            public string @TeamId { get; }

            [TerraformProperty(name: "token", @out: false, min: 1, max: 1)]
            public string @Token { get; }
        }

        public azurerm_notification_hub(string @location,
                                        string @name,
                                        string @namespaceName,
                                        string @resourceGroupName,
                                        apns_credential[] @apnsCredential = null,
                                        gcm_credential[] @gcmCredential = null)
        {
            @Location = @location;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @ApnsCredential = @apnsCredential;
            @GcmCredential = @gcmCredential;
            base._validate_();
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "apns_credential", @out: false, min: 0, max: 1)]
        public apns_credential[] @ApnsCredential { get; }

        [TerraformProperty(name: "gcm_credential", @out: false, min: 0, max: 1)]
        public gcm_credential[] @GcmCredential { get; }
    }

}
