using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cognito_user_pool_client")]
    public sealed class aws_cognito_user_pool_client : nterraform.Core.resource
    {
        public aws_cognito_user_pool_client(string @name,
                                            string @userPoolId,
                                            string[] @allowedOauthFlows = null,
                                            bool? @allowedOauthFlowsUserPoolClient = null,
                                            string[] @allowedOauthScopes = null,
                                            string[] @callbackUrls = null,
                                            string @defaultRedirectUri = null,
                                            string[] @explicitAuthFlows = null,
                                            bool? @generateSecret = null,
                                            string[] @logoutUrls = null,
                                            string[] @readAttributes = null,
                                            int? @refreshTokenValidity = null,
                                            string[] @supportedIdentityProviders = null,
                                            string[] @writeAttributes = null)
        {
            @Name = @name;
            @UserPoolId = @userPoolId;
            @AllowedOauthFlows = @allowedOauthFlows;
            @AllowedOauthFlowsUserPoolClient = @allowedOauthFlowsUserPoolClient;
            @AllowedOauthScopes = @allowedOauthScopes;
            @CallbackUrls = @callbackUrls;
            @DefaultRedirectUri = @defaultRedirectUri;
            @ExplicitAuthFlows = @explicitAuthFlows;
            @GenerateSecret = @generateSecret;
            @LogoutUrls = @logoutUrls;
            @ReadAttributes = @readAttributes;
            @RefreshTokenValidity = @refreshTokenValidity;
            @SupportedIdentityProviders = @supportedIdentityProviders;
            @WriteAttributes = @writeAttributes;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
        public string @UserPoolId { get; }

        [nterraform.Core.TerraformProperty(name: "allowed_oauth_flows", @out: false, min: 0, max: 1)]
        public string[] @AllowedOauthFlows { get; }

        [nterraform.Core.TerraformProperty(name: "allowed_oauth_flows_user_pool_client", @out: false, min: 0, max: 1)]
        public bool? @AllowedOauthFlowsUserPoolClient { get; }

        [nterraform.Core.TerraformProperty(name: "allowed_oauth_scopes", @out: false, min: 0, max: 1)]
        public string[] @AllowedOauthScopes { get; }

        [nterraform.Core.TerraformProperty(name: "callback_urls", @out: false, min: 0, max: 1)]
        public string[] @CallbackUrls { get; }

        [nterraform.Core.TerraformProperty(name: "client_secret", @out: true, min: 0, max: 1)]
        public string @ClientSecret { get; }

        [nterraform.Core.TerraformProperty(name: "default_redirect_uri", @out: false, min: 0, max: 1)]
        public string @DefaultRedirectUri { get; }

        [nterraform.Core.TerraformProperty(name: "explicit_auth_flows", @out: false, min: 0, max: 1)]
        public string[] @ExplicitAuthFlows { get; }

        [nterraform.Core.TerraformProperty(name: "generate_secret", @out: false, min: 0, max: 1)]
        public bool? @GenerateSecret { get; }

        [nterraform.Core.TerraformProperty(name: "logout_urls", @out: false, min: 0, max: 1)]
        public string[] @LogoutUrls { get; }

        [nterraform.Core.TerraformProperty(name: "read_attributes", @out: false, min: 0, max: 1)]
        public string[] @ReadAttributes { get; }

        [nterraform.Core.TerraformProperty(name: "refresh_token_validity", @out: false, min: 0, max: 1)]
        public int? @RefreshTokenValidity { get; }

        [nterraform.Core.TerraformProperty(name: "supported_identity_providers", @out: false, min: 0, max: 1)]
        public string[] @SupportedIdentityProviders { get; }

        [nterraform.Core.TerraformProperty(name: "write_attributes", @out: false, min: 0, max: 1)]
        public string[] @WriteAttributes { get; }
    }

}
