using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_method")]
    public sealed class aws_api_gateway_method : nterraform.Core.resource
    {
        public aws_api_gateway_method(string @authorization,
                                      string @httpMethod,
                                      string @resourceId,
                                      string @restApiId,
                                      bool? @apiKeyRequired = null,
                                      string[] @authorizationScopes = null,
                                      string @authorizerId = null,
                                      Dictionary<string,string> @requestModels = null,
                                      Dictionary<string,bool> @requestParameters = null,
                                      string @requestParametersInJson = null,
                                      string @requestValidatorId = null)
        {
            @Authorization = @authorization;
            @HttpMethod = @httpMethod;
            @ResourceId = @resourceId;
            @RestApiId = @restApiId;
            @ApiKeyRequired = @apiKeyRequired;
            @AuthorizationScopes = @authorizationScopes;
            @AuthorizerId = @authorizerId;
            @RequestModels = @requestModels;
            @RequestParameters = @requestParameters;
            @RequestParametersInJson = @requestParametersInJson;
            @RequestValidatorId = @requestValidatorId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "authorization", @out: false, min: 1, max: 1)]
        public string @Authorization { get; }

        [nterraform.Core.TerraformProperty(name: "http_method", @out: false, min: 1, max: 1)]
        public string @HttpMethod { get; }

        [nterraform.Core.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "api_key_required", @out: false, min: 0, max: 1)]
        public bool? @ApiKeyRequired { get; }

        [nterraform.Core.TerraformProperty(name: "authorization_scopes", @out: false, min: 0, max: 1)]
        public string[] @AuthorizationScopes { get; }

        [nterraform.Core.TerraformProperty(name: "authorizer_id", @out: false, min: 0, max: 1)]
        public string @AuthorizerId { get; }

        [nterraform.Core.TerraformProperty(name: "request_models", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @RequestModels { get; }

        [nterraform.Core.TerraformProperty(name: "request_parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,bool> @RequestParameters { get; }

        [nterraform.Core.TerraformProperty(name: "request_parameters_in_json", @out: false, min: 0, max: 1)]
        public string @RequestParametersInJson { get; }

        [nterraform.Core.TerraformProperty(name: "request_validator_id", @out: false, min: 0, max: 1)]
        public string @RequestValidatorId { get; }
    }

}
