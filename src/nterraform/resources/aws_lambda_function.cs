using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lambda_function")]
    public sealed class aws_lambda_function : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "environment")]
        public sealed class environment : nterraform.structure
        {
            public environment(Dictionary<string,string> @variables = null)
            {
                @Variables = @variables;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "variables", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Variables { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "tracing_config")]
        public sealed class tracing_config : nterraform.structure
        {
            public tracing_config(string @mode)
            {
                @Mode = @mode;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "mode", @out: false, min: 1, max: 1)]
            public string @Mode { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "vpc_config")]
        public sealed class vpc_config : nterraform.structure
        {
            public vpc_config(string[] @securityGroupIds,
                              string[] @subnetIds)
            {
                @SecurityGroupIds = @securityGroupIds;
                @SubnetIds = @subnetIds;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "security_group_ids", @out: false, min: 1, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.TerraformProperty(name: "subnet_ids", @out: false, min: 1, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "dead_letter_config")]
        public sealed class dead_letter_config : nterraform.structure
        {
            public dead_letter_config(string @targetArn)
            {
                @TargetArn = @targetArn;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "target_arn", @out: false, min: 1, max: 1)]
            public string @TargetArn { get; }
        }

        public aws_lambda_function(string @functionName,
                                   string @handler,
                                   string @role,
                                   string @runtime,
                                   dead_letter_config[] @deadLetterConfig = null,
                                   string @description = null,
                                   environment[] @environment = null,
                                   string @filename = null,
                                   string @kmsKeyArn = null,
                                   int? @memorySize = null,
                                   bool? @publish = null,
                                   int? @reservedConcurrentExecutions = null,
                                   string @s3Bucket = null,
                                   string @s3Key = null,
                                   string @s3ObjectVersion = null,
                                   Dictionary<string,string> @tags = null,
                                   int? @timeout = null,
                                   tracing_config[] @tracingConfig = null,
                                   vpc_config[] @vpcConfig = null)
        {
            @FunctionName = @functionName;
            @Handler = @handler;
            @Role = @role;
            @Runtime = @runtime;
            @DeadLetterConfig = @deadLetterConfig;
            @Description = @description;
            @Environment = @environment;
            @Filename = @filename;
            @KmsKeyArn = @kmsKeyArn;
            @MemorySize = @memorySize;
            @Publish = @publish;
            @ReservedConcurrentExecutions = @reservedConcurrentExecutions;
            @S3Bucket = @s3Bucket;
            @S3Key = @s3Key;
            @S3ObjectVersion = @s3ObjectVersion;
            @Tags = @tags;
            @Timeout = @timeout;
            @TracingConfig = @tracingConfig;
            @VpcConfig = @vpcConfig;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "function_name", @out: false, min: 1, max: 1)]
        public string @FunctionName { get; }

        [nterraform.TerraformProperty(name: "handler", @out: false, min: 1, max: 1)]
        public string @Handler { get; }

        [nterraform.TerraformProperty(name: "role", @out: false, min: 1, max: 1)]
        public string @Role { get; }

        [nterraform.TerraformProperty(name: "runtime", @out: false, min: 1, max: 1)]
        public string @Runtime { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "dead_letter_config", @out: false, min: 0, max: 1)]
        public dead_letter_config[] @DeadLetterConfig { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "environment", @out: false, min: 0, max: 1)]
        public environment[] @Environment { get; }

        [nterraform.TerraformProperty(name: "filename", @out: false, min: 0, max: 1)]
        public string @Filename { get; }

        [nterraform.TerraformProperty(name: "invoke_arn", @out: true, min: 0, max: 1)]
        public string @InvokeArn { get; }

        [nterraform.TerraformProperty(name: "kms_key_arn", @out: false, min: 0, max: 1)]
        public string @KmsKeyArn { get; }

        [nterraform.TerraformProperty(name: "last_modified", @out: true, min: 0, max: 1)]
        public string @LastModified { get; }

        [nterraform.TerraformProperty(name: "memory_size", @out: false, min: 0, max: 1)]
        public int? @MemorySize { get; }

        [nterraform.TerraformProperty(name: "publish", @out: false, min: 0, max: 1)]
        public bool? @Publish { get; }

        [nterraform.TerraformProperty(name: "qualified_arn", @out: true, min: 0, max: 1)]
        public string @QualifiedArn { get; }

        [nterraform.TerraformProperty(name: "reserved_concurrent_executions", @out: false, min: 0, max: 1)]
        public int? @ReservedConcurrentExecutions { get; }

        [nterraform.TerraformProperty(name: "s3_bucket", @out: false, min: 0, max: 1)]
        public string @S3Bucket { get; }

        [nterraform.TerraformProperty(name: "s3_key", @out: false, min: 0, max: 1)]
        public string @S3Key { get; }

        [nterraform.TerraformProperty(name: "s3_object_version", @out: false, min: 0, max: 1)]
        public string @S3ObjectVersion { get; }

        [nterraform.TerraformProperty(name: "source_code_hash", @out: true, min: 0, max: 1)]
        public string @SourceCodeHash { get; }

        [nterraform.TerraformProperty(name: "source_code_size", @out: true, min: 0, max: 1)]
        public int? @SourceCodeSize { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "timeout", @out: false, min: 0, max: 1)]
        public int? @Timeout { get; }

        [nterraform.TerraformProperty(name: "tracing_config", @out: false, min: 0, max: 1)]
        public tracing_config[] @TracingConfig { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }

        [nterraform.TerraformProperty(name: "vpc_config", @out: false, min: 0, max: 1)]
        public vpc_config[] @VpcConfig { get; }
    }

}
