using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_event_target")]
    public sealed class aws_cloudwatch_event_target : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "run_command_targets")]
        public sealed class run_command_targets : nterraform.Core.structure
        {
            public run_command_targets(string @key,
                                       string[] @values)
            {
                @Key = @key;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "kinesis_target")]
        public sealed class kinesis_target : nterraform.Core.structure
        {
            public kinesis_target(string @partitionKeyPath = null)
            {
                @PartitionKeyPath = @partitionKeyPath;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "partition_key_path", @out: false, min: 0, max: 1)]
            public string @PartitionKeyPath { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sqs_target")]
        public sealed class sqs_target : nterraform.Core.structure
        {
            public sqs_target(string @messageGroupId = null)
            {
                @MessageGroupId = @messageGroupId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "message_group_id", @out: false, min: 0, max: 1)]
            public string @MessageGroupId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ecs_target")]
        public sealed class ecs_target : nterraform.Core.structure
        {
            public ecs_target(string @taskDefinitionArn,
                              int? @taskCount = null)
            {
                @TaskDefinitionArn = @taskDefinitionArn;
                @TaskCount = @taskCount;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "task_definition_arn", @out: false, min: 1, max: 1)]
            public string @TaskDefinitionArn { get; }

            [nterraform.Core.TerraformProperty(name: "task_count", @out: false, min: 0, max: 1)]
            public int? @TaskCount { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "batch_target")]
        public sealed class batch_target : nterraform.Core.structure
        {
            public batch_target(string @jobDefinition,
                                string @jobName,
                                int? @arraySize = null,
                                int? @jobAttempts = null)
            {
                @JobDefinition = @jobDefinition;
                @JobName = @jobName;
                @ArraySize = @arraySize;
                @JobAttempts = @jobAttempts;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "job_definition", @out: false, min: 1, max: 1)]
            public string @JobDefinition { get; }

            [nterraform.Core.TerraformProperty(name: "job_name", @out: false, min: 1, max: 1)]
            public string @JobName { get; }

            [nterraform.Core.TerraformProperty(name: "array_size", @out: false, min: 0, max: 1)]
            public int? @ArraySize { get; }

            [nterraform.Core.TerraformProperty(name: "job_attempts", @out: false, min: 0, max: 1)]
            public int? @JobAttempts { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "input_transformer")]
        public sealed class input_transformer : nterraform.Core.structure
        {
            public input_transformer(string @inputTemplate,
                                     Dictionary<string,string> @inputPaths = null)
            {
                @InputTemplate = @inputTemplate;
                @InputPaths = @inputPaths;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "input_template", @out: false, min: 1, max: 1)]
            public string @InputTemplate { get; }

            [nterraform.Core.TerraformProperty(name: "input_paths", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @InputPaths { get; }
        }

        public aws_cloudwatch_event_target(string @arn,
                                           string @rule,
                                           batch_target[] @batchTarget = null,
                                           ecs_target[] @ecsTarget = null,
                                           string @input = null,
                                           string @inputPath = null,
                                           input_transformer[] @inputTransformer = null,
                                           kinesis_target[] @kinesisTarget = null,
                                           string @roleArn = null,
                                           run_command_targets[] @runCommandTargets = null,
                                           sqs_target[] @sqsTarget = null)
        {
            @Arn = @arn;
            @Rule = @rule;
            @BatchTarget = @batchTarget;
            @EcsTarget = @ecsTarget;
            @Input = @input;
            @InputPath = @inputPath;
            @InputTransformer = @inputTransformer;
            @KinesisTarget = @kinesisTarget;
            @RoleArn = @roleArn;
            @RunCommandTargets = @runCommandTargets;
            @SqsTarget = @sqsTarget;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: false, min: 1, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "rule", @out: false, min: 1, max: 1)]
        public string @Rule { get; }

        [nterraform.Core.TerraformProperty(name: "batch_target", @out: false, min: 0, max: 1)]
        public batch_target[] @BatchTarget { get; }

        [nterraform.Core.TerraformProperty(name: "ecs_target", @out: false, min: 0, max: 1)]
        public ecs_target[] @EcsTarget { get; }

        [nterraform.Core.TerraformProperty(name: "input", @out: false, min: 0, max: 1)]
        public string @Input { get; }

        [nterraform.Core.TerraformProperty(name: "input_path", @out: false, min: 0, max: 1)]
        public string @InputPath { get; }

        [nterraform.Core.TerraformProperty(name: "input_transformer", @out: false, min: 0, max: 1)]
        public input_transformer[] @InputTransformer { get; }

        [nterraform.Core.TerraformProperty(name: "kinesis_target", @out: false, min: 0, max: 1)]
        public kinesis_target[] @KinesisTarget { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 0, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "run_command_targets", @out: false, min: 0, max: 5)]
        public run_command_targets[] @RunCommandTargets { get; }

        [nterraform.Core.TerraformProperty(name: "sqs_target", @out: false, min: 0, max: 1)]
        public sqs_target[] @SqsTarget { get; }

        [nterraform.Core.TerraformProperty(name: "target_id", @out: true, min: 0, max: 1)]
        public string @TargetId { get; }
    }

}
