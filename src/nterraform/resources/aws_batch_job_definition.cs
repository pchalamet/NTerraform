using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_batch_job_definition")]
    public sealed class aws_batch_job_definition : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "retry_strategy")]
        public sealed class retry_strategy : nterraform.Core.structure
        {
            public retry_strategy(int? @attempts = null)
            {
                @Attempts = @attempts;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "attempts", @out: false, min: 0, max: 1)]
            public int? @Attempts { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "timeout")]
        public sealed class timeout : nterraform.Core.structure
        {
            public timeout(int? @attemptDurationSeconds = null)
            {
                @AttemptDurationSeconds = @attemptDurationSeconds;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "attempt_duration_seconds", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "container_properties", @out: false, min: 0, max: 1)]
        public string @ContainerProperties { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "retry_strategy", @out: false, min: 0, max: 1)]
        public retry_strategy[] @RetryStrategy { get; }

        [nterraform.Core.TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
        public int? @Revision { get; }

        [nterraform.Core.TerraformProperty(name: "timeout", @out: false, min: 0, max: 1)]
        public timeout[] @Timeout { get; }
    }

}
