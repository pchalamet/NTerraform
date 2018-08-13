using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_appsync_datasource")]
    public sealed class aws_appsync_datasource : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "lambda_config")]
        public sealed class lambda_config : nterraform.Core.structure
        {
            public lambda_config(string @functionArn)
            {
                @FunctionArn = @functionArn;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "function_arn", @out: false, min: 1, max: 1)]
            public string @FunctionArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "elasticsearch_config")]
        public sealed class elasticsearch_config : nterraform.Core.structure
        {
            public elasticsearch_config(string @endpoint,
                                        string @region)
            {
                @Endpoint = @endpoint;
                @Region = @region;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "endpoint", @out: false, min: 1, max: 1)]
            public string @Endpoint { get; }

            [nterraform.Core.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
            public string @Region { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "dynamodb_config")]
        public sealed class dynamodb_config : nterraform.Core.structure
        {
            public dynamodb_config(string @region,
                                   string @tableName,
                                   bool? @useCallerCredentials = null)
            {
                @Region = @region;
                @TableName = @tableName;
                @UseCallerCredentials = @useCallerCredentials;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "region", @out: false, min: 1, max: 1)]
            public string @Region { get; }

            [nterraform.Core.TerraformProperty(name: "table_name", @out: false, min: 1, max: 1)]
            public string @TableName { get; }

            [nterraform.Core.TerraformProperty(name: "use_caller_credentials", @out: false, min: 0, max: 1)]
            public bool? @UseCallerCredentials { get; }
        }

        public aws_appsync_datasource(string @apiId,
                                      string @name,
                                      string @type,
                                      string @description = null,
                                      dynamodb_config[] @dynamodbConfig = null,
                                      elasticsearch_config[] @elasticsearchConfig = null,
                                      lambda_config[] @lambdaConfig = null,
                                      string @serviceRoleArn = null)
        {
            @ApiId = @apiId;
            @Name = @name;
            @Type = @type;
            @Description = @description;
            @DynamodbConfig = @dynamodbConfig;
            @ElasticsearchConfig = @elasticsearchConfig;
            @LambdaConfig = @lambdaConfig;
            @ServiceRoleArn = @serviceRoleArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "api_id", @out: false, min: 1, max: 1)]
        public string @ApiId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "dynamodb_config", @out: false, min: 0, max: 1)]
        public dynamodb_config[] @DynamodbConfig { get; }

        [nterraform.Core.TerraformProperty(name: "elasticsearch_config", @out: false, min: 0, max: 1)]
        public elasticsearch_config[] @ElasticsearchConfig { get; }

        [nterraform.Core.TerraformProperty(name: "lambda_config", @out: false, min: 0, max: 1)]
        public lambda_config[] @LambdaConfig { get; }

        [nterraform.Core.TerraformProperty(name: "service_role_arn", @out: false, min: 0, max: 1)]
        public string @ServiceRoleArn { get; }
    }

}
