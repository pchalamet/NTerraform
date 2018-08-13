using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_documentation_version")]
    public sealed class aws_api_gateway_documentation_version : nterraform.resource
    {
        public aws_api_gateway_documentation_version(string @restApiId,
                                                     string @version,
                                                     string @description = null)
        {
            @RestApiId = @restApiId;
            @Version = @version;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.TerraformProperty(name: "version", @out: false, min: 1, max: 1)]
        public string @Version { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}
