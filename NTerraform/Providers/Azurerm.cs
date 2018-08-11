using System.Collections.Generic;

namespace NTerraform.Providers
{
    [TerraformStructure(category: "provider", typeName: "azurerm")]
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

        [TerraformProperty(name: "environment", @out: false, nested: true, min: 1, max: 1)]
        public string @Environment { get; }

        [TerraformProperty(name: "client_id", @out: false, nested: true, min: 0, max: 1)]
        public string @ClientId { get; }

        [TerraformProperty(name: "client_secret", @out: false, nested: true, min: 0, max: 1)]
        public string @ClientSecret { get; }

        [TerraformProperty(name: "msi_endpoint", @out: false, nested: true, min: 0, max: 1)]
        public string @MsiEndpoint { get; }

        [TerraformProperty(name: "skip_credentials_validation", @out: false, nested: true, min: 0, max: 1)]
        public bool? @SkipCredentialsValidation { get; }

        [TerraformProperty(name: "skip_provider_registration", @out: false, nested: true, min: 0, max: 1)]
        public bool? @SkipProviderRegistration { get; }

        [TerraformProperty(name: "subscription_id", @out: false, nested: true, min: 0, max: 1)]
        public string @SubscriptionId { get; }

        [TerraformProperty(name: "tenant_id", @out: false, nested: true, min: 0, max: 1)]
        public string @TenantId { get; }

        [TerraformProperty(name: "use_msi", @out: false, nested: true, min: 0, max: 1)]
        public bool? @UseMsi { get; }
    }

}
