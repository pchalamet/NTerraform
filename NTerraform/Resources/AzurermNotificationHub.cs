using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_notification_hub : NTerraform.resource
    {
        public class gcm_credential
        {
            public gcm_credential(string @apiKey)
            {
                @ApiKey = @apiKey;
            }

            public string @ApiKey { get; }
        }

        public class apns_credential
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
            }

            public string @ApplicationMode { get; }
            public string @BundleId { get; }
            public string @KeyId { get; }
            public string @TeamId { get; }
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
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @NamespaceName { get; }
        public string @ResourceGroupName { get; }
        public apns_credential[] @ApnsCredential { get; }
        public gcm_credential[] @GcmCredential { get; }
    }

}
