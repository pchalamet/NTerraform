using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_integration_response")]
    public sealed class aws_api_gateway_integration_response : nterraform.resource
    {
        public aws_api_gateway_integration_response(string @httpMethod,
                                                    string @resourceId,
                                                    string @restApiId,
                                                    string @statusCode,
                                                    string @contentHandling = null,
                                                    Dictionary<string,string> @responseParameters = null,
                                                    string @responseParametersInJson = null,
                                                    Dictionary<string,string> @responseTemplates = null,
                                                    string @selectionPattern = null)
        {
            @HttpMethod = @httpMethod;
            @ResourceId = @resourceId;
            @RestApiId = @restApiId;
            @StatusCode = @statusCode;
            @ContentHandling = @contentHandling;
            @ResponseParameters = @responseParameters;
            @ResponseParametersInJson = @responseParametersInJson;
            @ResponseTemplates = @responseTemplates;
            @SelectionPattern = @selectionPattern;
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

        [nterraform.TerraformProperty(name: "content_handling", @out: false, min: 0, max: 1)]
        public string @ContentHandling { get; }

        [nterraform.TerraformProperty(name: "response_parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @ResponseParameters { get; }

        [nterraform.TerraformProperty(name: "response_parameters_in_json", @out: false, min: 0, max: 1)]
        public string @ResponseParametersInJson { get; }

        [nterraform.TerraformProperty(name: "response_templates", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @ResponseTemplates { get; }

        [nterraform.TerraformProperty(name: "selection_pattern", @out: false, min: 0, max: 1)]
        public string @SelectionPattern { get; }
    }

}
