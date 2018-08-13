using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_gateway_response")]
    public sealed class aws_api_gateway_gateway_response : nterraform.Core.resource
    {
        public aws_api_gateway_gateway_response(string @responseType,
                                                string @restApiId,
                                                Dictionary<string,string> @responseParameters = null,
                                                Dictionary<string,string> @responseTemplates = null,
                                                string @statusCode = null)
        {
            @ResponseType = @responseType;
            @RestApiId = @restApiId;
            @ResponseParameters = @responseParameters;
            @ResponseTemplates = @responseTemplates;
            @StatusCode = @statusCode;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "response_type", @out: false, min: 1, max: 1)]
        public string @ResponseType { get; }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "response_parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @ResponseParameters { get; }

        [nterraform.Core.TerraformProperty(name: "response_templates", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @ResponseTemplates { get; }

        [nterraform.Core.TerraformProperty(name: "status_code", @out: false, min: 0, max: 1)]
        public string @StatusCode { get; }
    }

}
