using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_authorizer")]
    public sealed class aws_api_gateway_authorizer : nterraform.Core.resource
    {
        public aws_api_gateway_authorizer(string @name,
                                          string @restApiId,
                                          string @authorizerCredentials = null,
                                          int? @authorizerResultTtlInSeconds = null,
                                          string @authorizerUri = null,
                                          string @identitySource = null,
                                          string @identityValidationExpression = null,
                                          string[] @providerArns = null,
                                          string @type = null)
        {
            @Name = @name;
            @RestApiId = @restApiId;
            @AuthorizerCredentials = @authorizerCredentials;
            @AuthorizerResultTtlInSeconds = @authorizerResultTtlInSeconds;
            @AuthorizerUri = @authorizerUri;
            @IdentitySource = @identitySource;
            @IdentityValidationExpression = @identityValidationExpression;
            @ProviderArns = @providerArns;
            @Type = @type;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "authorizer_credentials", @out: false, min: 0, max: 1)]
        public string @AuthorizerCredentials { get; }

        [nterraform.Core.TerraformProperty(name: "authorizer_result_ttl_in_seconds", @out: false, min: 0, max: 1)]
        public int? @AuthorizerResultTtlInSeconds { get; }

        [nterraform.Core.TerraformProperty(name: "authorizer_uri", @out: false, min: 0, max: 1)]
        public string @AuthorizerUri { get; }

        [nterraform.Core.TerraformProperty(name: "identity_source", @out: false, min: 0, max: 1)]
        public string @IdentitySource { get; }

        [nterraform.Core.TerraformProperty(name: "identity_validation_expression", @out: false, min: 0, max: 1)]
        public string @IdentityValidationExpression { get; }

        [nterraform.Core.TerraformProperty(name: "provider_arns", @out: false, min: 0, max: 1)]
        public string[] @ProviderArns { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
        public string @Type { get; }
    }

}
