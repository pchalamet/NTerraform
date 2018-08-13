using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ssm_maintenance_window_task")]
    public sealed class aws_ssm_maintenance_window_task : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "task_parameters")]
        public sealed class task_parameters : nterraform.structure
        {
            public task_parameters(string @name,
                                   string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "targets")]
        public sealed class targets : nterraform.structure
        {
            public targets(string @key,
                           string[] @values)
            {
                @Key = @key;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "key", @out: false, min: 1, max: 1)]
            public string @Key { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "logging_info")]
        public sealed class logging_info : nterraform.structure
        {
            public logging_info(string @s3BucketName,
                                string @s3Region,
                                string @s3BucketPrefix = null)
            {
                @S3BucketName = @s3BucketName;
                @S3Region = @s3Region;
                @S3BucketPrefix = @s3BucketPrefix;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "s3_bucket_name", @out: false, min: 1, max: 1)]
            public string @S3BucketName { get; }

            [nterraform.TerraformProperty(name: "s3_region", @out: false, min: 1, max: 1)]
            public string @S3Region { get; }

            [nterraform.TerraformProperty(name: "s3_bucket_prefix", @out: false, min: 0, max: 1)]
            public string @S3BucketPrefix { get; }
        }

        public aws_ssm_maintenance_window_task(string @maxConcurrency,
                                               string @maxErrors,
                                               string @serviceRoleArn,
                                               targets[] @targets,
                                               string @taskArn,
                                               string @taskType,
                                               string @windowId,
                                               logging_info[] @loggingInfo = null,
                                               int? @priority = null,
                                               task_parameters[] @taskParameters = null)
        {
            @MaxConcurrency = @maxConcurrency;
            @MaxErrors = @maxErrors;
            @ServiceRoleArn = @serviceRoleArn;
            @Targets = @targets;
            @TaskArn = @taskArn;
            @TaskType = @taskType;
            @WindowId = @windowId;
            @LoggingInfo = @loggingInfo;
            @Priority = @priority;
            @TaskParameters = @taskParameters;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "max_concurrency", @out: false, min: 1, max: 1)]
        public string @MaxConcurrency { get; }

        [nterraform.TerraformProperty(name: "max_errors", @out: false, min: 1, max: 1)]
        public string @MaxErrors { get; }

        [nterraform.TerraformProperty(name: "service_role_arn", @out: false, min: 1, max: 1)]
        public string @ServiceRoleArn { get; }

        [nterraform.TerraformProperty(name: "targets", @out: false, min: 1, max: 0)]
        public targets[] @Targets { get; }

        [nterraform.TerraformProperty(name: "task_arn", @out: false, min: 1, max: 1)]
        public string @TaskArn { get; }

        [nterraform.TerraformProperty(name: "task_type", @out: false, min: 1, max: 1)]
        public string @TaskType { get; }

        [nterraform.TerraformProperty(name: "window_id", @out: false, min: 1, max: 1)]
        public string @WindowId { get; }

        [nterraform.TerraformProperty(name: "logging_info", @out: false, min: 0, max: 1)]
        public logging_info[] @LoggingInfo { get; }

        [nterraform.TerraformProperty(name: "priority", @out: false, min: 0, max: 1)]
        public int? @Priority { get; }

        [nterraform.TerraformProperty(name: "task_parameters", @out: false, min: 0, max: 0)]
        public task_parameters[] @TaskParameters { get; }
    }

}
