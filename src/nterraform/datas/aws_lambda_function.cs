using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_lambda_function")]
    public sealed class aws_lambda_function : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "dead_letter_config")]
        public sealed class dead_letter_config : nterraform.Core.structure
        {
            public dead_letter_config()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "target_arn", @out: true, min: 0, max: 1)]
            public string @TargetArn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "vpc_config")]
        public sealed class vpc_config : nterraform.Core.structure
        {
            public vpc_config()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "environment")]
        public sealed class environment : nterraform.Core.structure
        {
            public environment()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "variables", @out: true, min: 0, max: 1)]
            public Dictionary<string,string> @Variables { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "tracing_config")]
        public sealed class tracing_config : nterraform.Core.structure
        {
            public tracing_config()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "mode", @out: true, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "function_name", @out: false, min: 1, max: 1)]
        public string @FunctionName { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "dead_letter_config", @out: false, min: 0, max: 1)]
        public dead_letter_config[] @DeadLetterConfig { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "environment", @out: false, min: 0, max: 1)]
        public environment[] @Environment { get; }

        [nterraform.Core.TerraformProperty(name: "handler", @out: true, min: 0, max: 1)]
        public string @Handler { get; }

        [nterraform.Core.TerraformProperty(name: "invoke_arn", @out: true, min: 0, max: 1)]
        public string @InvokeArn { get; }

        [nterraform.Core.TerraformProperty(name: "kms_key_arn", @out: true, min: 0, max: 1)]
        public string @KmsKeyArn { get; }

        [nterraform.Core.TerraformProperty(name: "last_modified", @out: true, min: 0, max: 1)]
        public string @LastModified { get; }

        [nterraform.Core.TerraformProperty(name: "memory_size", @out: true, min: 0, max: 1)]
        public int? @MemorySize { get; }

        [nterraform.Core.TerraformProperty(name: "qualified_arn", @out: true, min: 0, max: 1)]
        public string @QualifiedArn { get; }

        [nterraform.Core.TerraformProperty(name: "qualifier", @out: false, min: 0, max: 1)]
        public string @Qualifier { get; }

        [nterraform.Core.TerraformProperty(name: "reserved_concurrent_executions", @out: true, min: 0, max: 1)]
        public int? @ReservedConcurrentExecutions { get; }

        [nterraform.Core.TerraformProperty(name: "role", @out: true, min: 0, max: 1)]
        public string @Role { get; }

        [nterraform.Core.TerraformProperty(name: "runtime", @out: true, min: 0, max: 1)]
        public string @Runtime { get; }

        [nterraform.Core.TerraformProperty(name: "source_code_hash", @out: true, min: 0, max: 1)]
        public string @SourceCodeHash { get; }

        [nterraform.Core.TerraformProperty(name: "source_code_size", @out: true, min: 0, max: 1)]
        public int? @SourceCodeSize { get; }

        [nterraform.Core.TerraformProperty(name: "timeout", @out: true, min: 0, max: 1)]
        public int? @Timeout { get; }

        [nterraform.Core.TerraformProperty(name: "tracing_config", @out: false, min: 0, max: 1)]
        public tracing_config[] @TracingConfig { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_config", @out: false, min: 0, max: 1)]
        public vpc_config[] @VpcConfig { get; }
    }

}
