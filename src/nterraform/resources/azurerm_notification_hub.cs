using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_notification_hub")]
    public sealed class azurerm_notification_hub : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "apns_credential")]
        public sealed class apns_credential : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "application_mode", @out: false, min: 1, max: 1)]
            public string @ApplicationMode { get; }

            [nterraform.Core.TerraformProperty(name: "bundle_id", @out: false, min: 1, max: 1)]
            public string @BundleId { get; }

            [nterraform.Core.TerraformProperty(name: "key_id", @out: false, min: 1, max: 1)]
            public string @KeyId { get; }

            [nterraform.Core.TerraformProperty(name: "team_id", @out: false, min: 1, max: 1)]
            public string @TeamId { get; }

            [nterraform.Core.TerraformProperty(name: "token", @out: false, min: 1, max: 1)]
            public string @Token { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "gcm_credential")]
        public sealed class gcm_credential : nterraform.Core.structure
        {
            public gcm_credential(string @apiKey)
            {
                @ApiKey = @apiKey;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "api_key", @out: false, min: 1, max: 1)]
            public string @ApiKey { get; }
        }

        public azurerm_notification_hub(string @location,
                                        string @name,
                                        string @namespaceName,
                                        string @resourceGroupName,
                                        FSharpOption<FSharpList<apns_credential>> @apnsCredential = null,
                                        FSharpOption<FSharpList<gcm_credential>> @gcmCredential = null)
        {
            @Location = @location;
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @ApnsCredential = @apnsCredential ?? FSharpList<apns_credential>.Empty;
            @GcmCredential = @gcmCredential ?? FSharpList<gcm_credential>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "apns_credential", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<apns_credential>> @ApnsCredential { get; }

        [nterraform.Core.TerraformProperty(name: "gcm_credential", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<gcm_credential>> @GcmCredential { get; }
    }

}
