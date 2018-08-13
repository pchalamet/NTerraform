using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_deployment")]
    public sealed class aws_api_gateway_deployment : nterraform.Core.resource
    {
        public aws_api_gateway_deployment(string @restApiId,
                                          string @stageName,
                                          string @description = null,
                                          string @stageDescription = null,
                                          Dictionary<string,string> @variables = null)
        {
            @RestApiId = @restApiId;
            @StageName = @stageName;
            @Description = @description;
            @StageDescription = @stageDescription;
            @Variables = @variables;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.Core.TerraformProperty(name: "stage_name", @out: false, min: 1, max: 1)]
        public string @StageName { get; }

        [nterraform.Core.TerraformProperty(name: "created_date", @out: true, min: 0, max: 1)]
        public string @CreatedDate { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "execution_arn", @out: true, min: 0, max: 1)]
        public string @ExecutionArn { get; }

        [nterraform.Core.TerraformProperty(name: "invoke_url", @out: true, min: 0, max: 1)]
        public string @InvokeUrl { get; }

        [nterraform.Core.TerraformProperty(name: "stage_description", @out: false, min: 0, max: 1)]
        public string @StageDescription { get; }

        [nterraform.Core.TerraformProperty(name: "variables", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Variables { get; }
    }

}
