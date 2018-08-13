using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_notification_hub")]
    public sealed class azurerm_notification_hub : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "apns_credential")]
        public sealed class apns_credential : nterraform.structure
        {
            public apns_credential()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "application_mode", @out: true, min: 0, max: 1)]
            public string @ApplicationMode { get; }

            [nterraform.TerraformProperty(name: "bundle_id", @out: true, min: 0, max: 1)]
            public string @BundleId { get; }

            [nterraform.TerraformProperty(name: "key_id", @out: true, min: 0, max: 1)]
            public string @KeyId { get; }

            [nterraform.TerraformProperty(name: "team_id", @out: true, min: 0, max: 1)]
            public string @TeamId { get; }

            [nterraform.TerraformProperty(name: "token", @out: true, min: 0, max: 1)]
            public string @Token { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "gcm_credential")]
        public sealed class gcm_credential : nterraform.structure
        {
            public gcm_credential()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "api_key", @out: true, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "apns_credential", @out: false, min: 0, max: 0)]
        public apns_credential[] @ApnsCredential { get; }

        [nterraform.TerraformProperty(name: "gcm_credential", @out: false, min: 0, max: 0)]
        public gcm_credential[] @GcmCredential { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }
    }

}
