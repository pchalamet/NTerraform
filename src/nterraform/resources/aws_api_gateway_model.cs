using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_model")]
    public sealed class aws_api_gateway_model : nterraform.Core.resource
    {
        public aws_api_gateway_model(string @contentType,
                                     string @name,
                                     string @restApiId,
                                     string @description = null,
                                     string @schema = null)
        {
            @ContentType = @contentType;
            @Name = @name;
            @RestApiId = @restApiId;
            @Description = @description;
            @Schema = @schema;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "content_type", @out: false, min: 1, max: 1)]
        public string @ContentType { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "schema", @out: false, min: 0, max: 1)]
        public string @Schema { get; }
    }

}