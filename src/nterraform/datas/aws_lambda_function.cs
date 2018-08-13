using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_lambda_function")]
    public sealed class aws_lambda_function : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "vpc_config")]
        public sealed class vpc_config : nterraform.structure
        {
            public vpc_config()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "dead_letter_config")]
        public sealed class dead_letter_config : nterraform.structure
        {
            public dead_letter_config()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "target_arn", @out: true, min: 0, max: 1)]
            public string @TargetArn { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "environment")]
        public sealed class environment : nterraform.structure
        {
            public environment()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "variables", @out: true, min: 0, max: 1)]
            public Dictionary<string,string> @Variables { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "tracing_config")]
        public sealed class tracing_config : nterraform.structure
        {
            public tracing_config()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "mode", @out: true, min: 0, max: 1)]
            public string @Mode { get; }
        }

        public aws_lambda_function(string @functionName,
                                   dead_letter_config[] @deadLetterConfig = null,
                                   environment[] @environment = null,
                                   string @qualifier = null,
                                   tracing_config[] @tracingConfig = null,
                                   vpc_config[] @vpcConfig = null)
        {
            @FunctionName = @functionName;
            @DeadLetterConfig = @deadLetterConfig;
            @Environment = @environment;
            @Qualifier = @qualifier;
            @TracingConfig = @tracingConfig;
            @VpcConfig = @vpcConfig;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "function_name", @out: false, min: 1, max: 1)]
        public string @FunctionName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "dead_letter_config", @out: false, min: 0, max: 1)]
        public dead_letter_config[] @DeadLetterConfig { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "environment", @out: false, min: 0, max: 1)]
        public environment[] @Environment { get; }

        [nterraform.TerraformProperty(name: "handler", @out: true, min: 0, max: 1)]
        public string @Handler { get; }

        [nterraform.TerraformProperty(name: "invoke_arn", @out: true, min: 0, max: 1)]
        public string @InvokeArn { get; }

        [nterraform.TerraformProperty(name: "kms_key_arn", @out: true, min: 0, max: 1)]
        public string @KmsKeyArn { get; }

        [nterraform.TerraformProperty(name: "last_modified", @out: true, min: 0, max: 1)]
        public string @LastModified { get; }

        [nterraform.TerraformProperty(name: "memory_size", @out: true, min: 0, max: 1)]
        public int? @MemorySize { get; }

        [nterraform.TerraformProperty(name: "qualified_arn", @out: true, min: 0, max: 1)]
        public string @QualifiedArn { get; }

        [nterraform.TerraformProperty(name: "qualifier", @out: false, min: 0, max: 1)]
        public string @Qualifier { get; }

        [nterraform.TerraformProperty(name: "reserved_concurrent_executions", @out: true, min: 0, max: 1)]
        public int? @ReservedConcurrentExecutions { get; }

        [nterraform.TerraformProperty(name: "role", @out: true, min: 0, max: 1)]
        public string @Role { get; }

        [nterraform.TerraformProperty(name: "runtime", @out: true, min: 0, max: 1)]
        public string @Runtime { get; }

        [nterraform.TerraformProperty(name: "source_code_hash", @out: true, min: 0, max: 1)]
        public string @SourceCodeHash { get; }

        [nterraform.TerraformProperty(name: "source_code_size", @out: true, min: 0, max: 1)]
        public int? @SourceCodeSize { get; }

        [nterraform.TerraformProperty(name: "timeout", @out: true, min: 0, max: 1)]
        public int? @Timeout { get; }

        [nterraform.TerraformProperty(name: "tracing_config", @out: false, min: 0, max: 1)]
        public tracing_config[] @TracingConfig { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }

        [nterraform.TerraformProperty(name: "vpc_config", @out: false, min: 0, max: 1)]
        public vpc_config[] @VpcConfig { get; }
    }

}
