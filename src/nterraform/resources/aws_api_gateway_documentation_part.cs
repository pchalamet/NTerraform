using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_documentation_part")]
    public sealed class aws_api_gateway_documentation_part : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "location")]
        public sealed class location : nterraform.structure
        {
            public location(string @type,
                            string @method = null,
                            string @name = null,
                            string @path = null,
                            string @statusCode = null)
            {
                @Type = @type;
                @Method = @method;
                @Name = @name;
                @Path = @path;
                @StatusCode = @statusCode;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "method", @out: false, min: 0, max: 1)]
            public string @Method { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
            public string @Path { get; }

            [nterraform.TerraformProperty(name: "status_code", @out: false, min: 0, max: 1)]
            public string @StatusCode { get; }
        }

        public aws_api_gateway_documentation_part(location[] @location,
                                                  string @properties,
                                                  string @restApiId)
        {
            @Location = @location;
            @Properties = @properties;
            @RestApiId = @restApiId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public location[] @Location { get; }

        [nterraform.TerraformProperty(name: "properties", @out: false, min: 1, max: 1)]
        public string @Properties { get; }

        [nterraform.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }
    }

}
