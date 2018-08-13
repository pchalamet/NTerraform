using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cognito_identity_pool")]
    public sealed class aws_cognito_identity_pool : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "cognito_identity_providers")]
        public sealed class cognito_identity_providers : nterraform.structure
        {
            public cognito_identity_providers(string @clientId = null,
                                              string @providerName = null,
                                              bool? @serverSideTokenCheck = null)
            {
                @ClientId = @clientId;
                @ProviderName = @providerName;
                @ServerSideTokenCheck = @serverSideTokenCheck;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "client_id", @out: false, min: 0, max: 1)]
            public string @ClientId { get; }

            [nterraform.TerraformProperty(name: "provider_name", @out: false, min: 0, max: 1)]
            public string @ProviderName { get; }

            [nterraform.TerraformProperty(name: "server_side_token_check", @out: false, min: 0, max: 1)]
            public bool? @ServerSideTokenCheck { get; }
        }

        public aws_cognito_identity_pool(string @identityPoolName,
                                         bool? @allowUnauthenticatedIdentities = null,
                                         cognito_identity_providers[] @cognitoIdentityProviders = null,
                                         string @developerProviderName = null,
                                         string[] @openidConnectProviderArns = null,
                                         string[] @samlProviderArns = null,
                                         Dictionary<string,string> @supportedLoginProviders = null)
        {
            @IdentityPoolName = @identityPoolName;
            @AllowUnauthenticatedIdentities = @allowUnauthenticatedIdentities;
            @CognitoIdentityProviders = @cognitoIdentityProviders;
            @DeveloperProviderName = @developerProviderName;
            @OpenidConnectProviderArns = @openidConnectProviderArns;
            @SamlProviderArns = @samlProviderArns;
            @SupportedLoginProviders = @supportedLoginProviders;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "identity_pool_name", @out: false, min: 1, max: 1)]
        public string @IdentityPoolName { get; }

        [nterraform.TerraformProperty(name: "allow_unauthenticated_identities", @out: false, min: 0, max: 1)]
        public bool? @AllowUnauthenticatedIdentities { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "cognito_identity_providers", @out: false, min: 0, max: 0)]
        public cognito_identity_providers[] @CognitoIdentityProviders { get; }

        [nterraform.TerraformProperty(name: "developer_provider_name", @out: false, min: 0, max: 1)]
        public string @DeveloperProviderName { get; }

        [nterraform.TerraformProperty(name: "openid_connect_provider_arns", @out: false, min: 0, max: 1)]
        public string[] @OpenidConnectProviderArns { get; }

        [nterraform.TerraformProperty(name: "saml_provider_arns", @out: false, min: 0, max: 1)]
        public string[] @SamlProviderArns { get; }

        [nterraform.TerraformProperty(name: "supported_login_providers", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @SupportedLoginProviders { get; }
    }

}
