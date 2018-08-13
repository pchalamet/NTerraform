using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_method_response")]
    public sealed class aws_api_gateway_method_response : nterraform.Core.resource
    {
        public aws_api_gateway_method_response(string @httpMethod,
                                               string @resourceId,
                                               string @restApiId,
                                               string @statusCode,
                                               Dictionary<string,string> @responseModels = null,
                                               Dictionary<string,bool> @responseParameters = null,
                                               string @responseParametersInJson = null)
        {
            @HttpMethod = @httpMethod;
            @ResourceId = @resourceId;
            @RestApiId = @restApiId;
            @StatusCode = @statusCode;
            @ResponseModels = @responseModels;
            @ResponseParameters = @responseParameters;
            @ResponseParametersInJson = @responseParametersInJson;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "http_method", @out: false, min: 1, max: 1)]
        public string @HttpMethod { get; }

        [nterraform.Core.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "status_code", @out: false, min: 1, max: 1)]
        public string @StatusCode { get; }

        [nterraform.Core.TerraformProperty(name: "response_models", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @ResponseModels { get; }

        [nterraform.Core.TerraformProperty(name: "response_parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,bool> @ResponseParameters { get; }

        [nterraform.Core.TerraformProperty(name: "response_parameters_in_json", @out: false, min: 0, max: 1)]
        public string @ResponseParametersInJson { get; }
    }

}
