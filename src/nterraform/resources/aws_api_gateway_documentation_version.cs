using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_documentation_version")]
    public sealed class aws_api_gateway_documentation_version : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 1, max: 1)]
        public string @Version { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}
