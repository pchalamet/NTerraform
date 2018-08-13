using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_method_response")]
    public sealed class aws_api_gateway_method_response : nterraform.resource
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

        [nterraform.TerraformProperty(name: "http_method", @out: false, min: 1, max: 1)]
        public string @HttpMethod { get; }

        [nterraform.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.TerraformProperty(name: "status_code", @out: false, min: 1, max: 1)]
        public string @StatusCode { get; }

        [nterraform.TerraformProperty(name: "response_models", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @ResponseModels { get; }

        [nterraform.TerraformProperty(name: "response_parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,bool> @ResponseParameters { get; }

        [nterraform.TerraformProperty(name: "response_parameters_in_json", @out: false, min: 0, max: 1)]
        public string @ResponseParametersInJson { get; }
    }

}
