using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_batch_job_definition")]
    public sealed class aws_batch_job_definition : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "retry_strategy")]
        public sealed class retry_strategy : nterraform.structure
        {
            public retry_strategy(int? @attempts = null)
            {
                @Attempts = @attempts;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "attempts", @out: false, min: 0, max: 1)]
            public int? @Attempts { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "timeout")]
        public sealed class timeout : nterraform.structure
        {
            public timeout(int? @attemptDurationSeconds = null)
            {
                @AttemptDurationSeconds = @attemptDurationSeconds;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "attempt_duration_seconds", @out: false, min: 0, max: 1)]
            public int? @AttemptDurationSeconds { get; }
        }

        public aws_batch_job_definition(string @name,
                                        string @type,
                                        string @containerProperties = null,
                                        Dictionary<string,string> @parameters = null,
                                        retry_strategy[] @retryStrategy = null,
                                        timeout[] @timeout = null)
        {
            @Name = @name;
            @Type = @type;
            @ContainerProperties = @containerProperties;
            @Parameters = @parameters;
            @RetryStrategy = @retryStrategy;
            @Timeout = @timeout;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "container_properties", @out: false, min: 0, max: 1)]
        public string @ContainerProperties { get; }

        [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.TerraformProperty(name: "retry_strategy", @out: false, min: 0, max: 1)]
        public retry_strategy[] @RetryStrategy { get; }

        [nterraform.TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
        public int? @Revision { get; }

        [nterraform.TerraformProperty(name: "timeout", @out: false, min: 0, max: 1)]
        public timeout[] @Timeout { get; }
    }

}
