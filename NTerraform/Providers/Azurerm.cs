using System.Collections.Generic;

namespace NTerraform.Providers
{
    public sealed class azurerm : NTerraform.provider
    {
        public azurerm(string @environment,
                       string @clientId = null,
                       string @clientSecret = null,
                       string @msiEndpoint = null,
                       bool? @skipCredentialsValidation = null,
                       bool? @skipProviderRegistration = null,
                       string @subscriptionId = null,
                       string @tenantId = null,
                       bool? @useMsi = null)
        {
            @Environment = @environment;
            @ClientId = @clientId;
            @ClientSecret = @clientSecret;
            @MsiEndpoint = @msiEndpoint;
            @SkipCredentialsValidation = @skipCredentialsValidation;
            @SkipProviderRegistration = @skipProviderRegistration;
            @SubscriptionId = @subscriptionId;
            @TenantId = @tenantId;
            @UseMsi = @useMsi;
        }

        public string @Environment { get; }
        public string @ClientId { get; }
        public string @ClientSecret { get; }
        public string @MsiEndpoint { get; }
        public bool? @SkipCredentialsValidation { get; }
        public bool? @SkipProviderRegistration { get; }
        public string @SubscriptionId { get; }
        public string @TenantId { get; }
        public bool? @UseMsi { get; }
    }

}
