using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_integration")]
    public sealed class aws_api_gateway_integration : nterraform.Core.resource
    {
        public aws_api_gateway_integration(string @httpMethod,
                                           string @resourceId,
                                           string @restApiId,
                                           string @type,
                                           string[] @cacheKeyParameters = null,
                                           string @connectionId = null,
                                           string @connectionType = null,
                                           string @contentHandling = null,
                                           string @credentials = null,
                                           string @integrationHttpMethod = null,
                                           Dictionary<string,string> @requestParameters = null,
                                           string @requestParametersInJson = null,
                                           Dictionary<string,string> @requestTemplates = null,
                                           int? @timeoutMilliseconds = null,
                                           string @uri = null)
        {
            @HttpMethod = @httpMethod;
            @ResourceId = @resourceId;
            @RestApiId = @restApiId;
            @Type = @type;
            @CacheKeyParameters = @cacheKeyParameters;
            @ConnectionId = @connectionId;
            @ConnectionType = @connectionType;
            @ContentHandling = @contentHandling;
            @Credentials = @credentials;
            @IntegrationHttpMethod = @integrationHttpMethod;
            @RequestParameters = @requestParameters;
            @RequestParametersInJson = @requestParametersInJson;
            @RequestTemplates = @requestTemplates;
            @TimeoutMilliseconds = @timeoutMilliseconds;
            @Uri = @uri;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "http_method", @out: false, min: 1, max: 1)]
        public string @HttpMethod { get; }

        [nterraform.Core.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "cache_key_parameters", @out: false, min: 0, max: 1)]
        public string[] @CacheKeyParameters { get; }

        [nterraform.Core.TerraformProperty(name: "cache_namespace", @out: true, min: 0, max: 1)]
        public string @CacheNamespace { get; }

        [nterraform.Core.TerraformProperty(name: "connection_id", @out: false, min: 0, max: 1)]
        public string @ConnectionId { get; }

        [nterraform.Core.TerraformProperty(name: "connection_type", @out: false, min: 0, max: 1)]
        public string @ConnectionType { get; }

        [nterraform.Core.TerraformProperty(name: "content_handling", @out: false, min: 0, max: 1)]
        public string @ContentHandling { get; }

        [nterraform.Core.TerraformProperty(name: "credentials", @out: false, min: 0, max: 1)]
        public string @Credentials { get; }

        [nterraform.Core.TerraformProperty(name: "integration_http_method", @out: false, min: 0, max: 1)]
        public string @IntegrationHttpMethod { get; }

        [nterraform.Core.TerraformProperty(name: "passthrough_behavior", @out: true, min: 0, max: 1)]
        public string @PassthroughBehavior { get; }

        [nterraform.Core.TerraformProperty(name: "request_parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @RequestParameters { get; }

        [nterraform.Core.TerraformProperty(name: "request_parameters_in_json", @out: false, min: 0, max: 1)]
        public string @RequestParametersInJson { get; }

        [nterraform.Core.TerraformProperty(name: "request_templates", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @RequestTemplates { get; }

        [nterraform.Core.TerraformProperty(name: "timeout_milliseconds", @out: false, min: 0, max: 1)]
        public int? @TimeoutMilliseconds { get; }

        [nterraform.Core.TerraformProperty(name: "uri", @out: false, min: 0, max: 1)]
        public string @Uri { get; }
    }

}
