using System.Collections.Generic;

namespace nterraform.providers
{
    [nterraform.Core.TerraformStructure(category: "provider", typeName: "azurerm")]
    public sealed class azurerm : nterraform.Core.provider
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "environment", @out: false, min: 1, max: 1)]
        public string @Environment { get; }

        [nterraform.Core.TerraformProperty(name: "client_id", @out: false, min: 0, max: 1)]
        public string @ClientId { get; }

        [nterraform.Core.TerraformProperty(name: "client_secret", @out: false, min: 0, max: 1)]
        public string @ClientSecret { get; }

        [nterraform.Core.TerraformProperty(name: "msi_endpoint", @out: false, min: 0, max: 1)]
        public string @MsiEndpoint { get; }

        [nterraform.Core.TerraformProperty(name: "skip_credentials_validation", @out: false, min: 0, max: 1)]
        public bool? @SkipCredentialsValidation { get; }

        [nterraform.Core.TerraformProperty(name: "skip_provider_registration", @out: false, min: 0, max: 1)]
        public bool? @SkipProviderRegistration { get; }

        [nterraform.Core.TerraformProperty(name: "subscription_id", @out: false, min: 0, max: 1)]
        public string @SubscriptionId { get; }

        [nterraform.Core.TerraformProperty(name: "tenant_id", @out: false, min: 0, max: 1)]
        public string @TenantId { get; }

        [nterraform.Core.TerraformProperty(name: "use_msi", @out: false, min: 0, max: 1)]
        public bool? @UseMsi { get; }
    }

}
