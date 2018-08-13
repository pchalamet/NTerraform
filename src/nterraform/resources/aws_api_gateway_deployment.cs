using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_api_gateway_deployment")]
    public sealed class aws_api_gateway_deployment : nterraform.resource
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

        [nterraform.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
        public string @RestApiId { get; }

        [nterraform.TerraformProperty(name: "stage_name", @out: false, min: 1, max: 1)]
        public string @StageName { get; }

        [nterraform.TerraformProperty(name: "created_date", @out: true, min: 0, max: 1)]
        public string @CreatedDate { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "execution_arn", @out: true, min: 0, max: 1)]
        public string @ExecutionArn { get; }

        [nterraform.TerraformProperty(name: "invoke_url", @out: true, min: 0, max: 1)]
        public string @InvokeUrl { get; }

        [nterraform.TerraformProperty(name: "stage_description", @out: false, min: 0, max: 1)]
        public string @StageDescription { get; }

        [nterraform.TerraformProperty(name: "variables", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Variables { get; }
    }

}
