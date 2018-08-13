using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_base_path_mapping")]
    public sealed class aws_api_gateway_base_path_mapping : nterraform.resource
    {
        public aws_api_gateway_base_path_mapping(string @apiId,
                                                 string @domainName,
                                                 string @basePath = null,
                                                 string @stageName = null)
        {
            @ApiId = @apiId;
            @DomainName = @domainName;
            @BasePath = @basePath;
            @StageName = @stageName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "api_id", @out: false, min: 1, max: 1)]
        public string @ApiId { get; }

        [nterraform.TerraformProperty(name: "domain_name", @out: false, min: 1, max: 1)]
        public string @DomainName { get; }

        [nterraform.TerraformProperty(name: "base_path", @out: false, min: 0, max: 1)]
        public string @BasePath { get; }

        [nterraform.TerraformProperty(name: "stage_name", @out: false, min: 0, max: 1)]
        public string @StageName { get; }
    }

}
