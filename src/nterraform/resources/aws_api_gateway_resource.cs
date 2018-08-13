using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_resource")]
    public sealed class aws_api_gateway_resource : nterraform.resource
    {
        public aws_api_gateway_resource(string @parentId,
                                        string @pathPart,
                                        string @restApiId)
        {
            @ParentId = @parentId;
            @PathPart = @pathPart;
            @RestApiId = @restApiId;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "parent_id", @out: false, min: 1, max: 1)]
        public string @ParentId { get; }

        [nterraform.TerraformProperty(name: "path_part", @out: false, min: 1, max: 1)]
        public string @PathPart { get; }

        [nterraform.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }
    }

}
