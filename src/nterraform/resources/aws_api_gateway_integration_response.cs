using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_integration_response")]
    public sealed class aws_api_gateway_integration_response : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "http_method", @out: false, min: 1, max: 1)]
        public string @HttpMethod { get; }

        [nterraform.Core.TerraformProperty(name: "resource_id", @out: false, min: 1, max: 1)]
        public string @ResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "status_code", @out: false, min: 1, max: 1)]
        public string @StatusCode { get; }

        [nterraform.Core.TerraformProperty(name: "content_handling", @out: false, min: 0, max: 1)]
        public string @ContentHandling { get; }

        [nterraform.Core.TerraformProperty(name: "response_parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @ResponseParameters { get; }

        [nterraform.Core.TerraformProperty(name: "response_parameters_in_json", @out: false, min: 0, max: 1)]
        public string @ResponseParametersInJson { get; }

        [nterraform.Core.TerraformProperty(name: "response_templates", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @ResponseTemplates { get; }

        [nterraform.Core.TerraformProperty(name: "selection_pattern", @out: false, min: 0, max: 1)]
        public string @SelectionPattern { get; }
    }

}