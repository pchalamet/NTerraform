using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_api_gateway_api_key")]
    public sealed class aws_api_gateway_api_key : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "stage_key")]
        public sealed class stage_key : nterraform.Core.structure
        {
            public stage_key(string @restApiId,
                             string @stageName)
            {
                @RestApiId = @restApiId;
                @StageName = @stageName;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "rest_api_id", @out: false, min: 1, max: 1)]
            public string @RestApiId { get; }

            [nterraform.Core.TerraformProperty(name: "stage_name", @out: false, min: 1, max: 1)]
            public string @StageName { get; }
        }

        public aws_api_gateway_api_key(string @name,
                                       string @description = null,
                                       bool? @enabled = null,
                                       stage_key[] @stageKey = null)
        {
            @Name = @name;
            @Description = @description;
            @Enabled = @enabled;
            @StageKey = @stageKey;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "created_date", @out: true, min: 0, max: 1)]
        public string @CreatedDate { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "last_updated_date", @out: true, min: 0, max: 1)]
        public string @LastUpdatedDate { get; }

        [nterraform.Core.TerraformProperty(name: "stage_key", @out: false, min: 0, max: 0)]
        public stage_key[] @StageKey { get; }

        [nterraform.Core.TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
        public string @Value { get; }
    }

}
