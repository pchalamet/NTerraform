using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_notification_hub")]
    public sealed class azurerm_notification_hub : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "apns_credential")]
        public sealed class apns_credential : nterraform.Core.structure
        {
            public apns_credential()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "application_mode", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ApplicationMode { get; }

            [nterraform.Core.TerraformProperty(name: "bundle_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @BundleId { get; }

            [nterraform.Core.TerraformProperty(name: "key_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @KeyId { get; }

            [nterraform.Core.TerraformProperty(name: "team_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @TeamId { get; }

            [nterraform.Core.TerraformProperty(name: "token", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Token { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "gcm_credential")]
        public sealed class gcm_credential : nterraform.Core.structure
        {
            public gcm_credential()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "api_key", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ApiKey { get; }
        }

        public azurerm_notification_hub(string @name,
                                        string @namespaceName,
                                        string @resourceGroupName,
                                        FSharpOption<FSharpList<apns_credential>> @apnsCredential = null,
                                        FSharpOption<FSharpList<gcm_credential>> @gcmCredential = null)
        {
            @Name = @name;
            @NamespaceName = @namespaceName;
            @ResourceGroupName = @resourceGroupName;
            @ApnsCredential = @apnsCredential ?? FSharpList<apns_credential>.Empty;
            @GcmCredential = @gcmCredential ?? FSharpList<gcm_credential>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "namespace_name", @out: false, min: 1, max: 1)]
        public string @NamespaceName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "apns_credential", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<apns_credential>> @ApnsCredential { get; }

        [nterraform.Core.TerraformProperty(name: "gcm_credential", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<gcm_credential>> @GcmCredential { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }
    }

}
