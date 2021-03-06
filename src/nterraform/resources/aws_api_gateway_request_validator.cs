using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_request_validator")]
    public sealed class aws_api_gateway_request_validator : nterraform.resource
    {
        public aws_api_gateway_request_validator(string @name,
                                                 string @restApiId,
                                                 bool? @validateRequestBody = null,
                                                 bool? @validateRequestParameters = null)
        {
            @Name = @name;
            @RestApiId = @restApiId;
            @ValidateRequestBody = @validateRequestBody;
            @ValidateRequestParameters = @validateRequestParameters;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.TerraformProperty(name: "validate_request_body", @out: false, min: 0, max: 1)]
        public bool? @ValidateRequestBody { get; }

        [nterraform.TerraformProperty(name: "validate_request_parameters", @out: false, min: 0, max: 1)]
        public bool? @ValidateRequestParameters { get; }
    }

}
