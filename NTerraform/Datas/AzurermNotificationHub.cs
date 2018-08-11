using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_notification_hub : NTerraform.data
    {
        public sealed class gcm_credential
        {
            public gcm_credential()
            {
            }

            public string @ApiKey { get; }
        }

        public sealed class apns_credential
        {
            public apns_credential()
            {
            }

            public string @ApplicationMode { get; }
            public string @BundleId { get; }
            public string @KeyId { get; }
            public string @TeamId { get; }
            public string @Token { get; }
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

        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public apns_credential[] @ApnsCredential { get; }
        public gcm_credential[] @GcmCredential { get; }
        public string @Location { get; }
    }

}
