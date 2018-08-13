using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_glue_job")]
    public sealed class aws_glue_job : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "command")]
        public sealed class command : nterraform.Core.structure
        {
            public command(string @scriptLocation,
                           string @name = null)
            {
                @ScriptLocation = @scriptLocation;
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "script_location", @out: false, min: 1, max: 1)]
            public string @ScriptLocation { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "execution_property")]
        public sealed class execution_property : nterraform.Core.structure
        {
            public execution_property(int? @maxConcurrentRuns = null)
            {
                @MaxConcurrentRuns = @maxConcurrentRuns;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "max_concurrent_runs", @out: false, min: 0, max: 1)]
            public int? @MaxConcurrentRuns { get; }
        }

        public aws_glue_job(command[] @command,
                            string @name,
                            string @roleArn,
                            int? @allocatedCapacity = null,
                            string[] @connections = null,
                            Dictionary<string,string> @defaultArguments = null,
                            string @description = null,
                            execution_property[] @executionProperty = null,
                            int? @maxRetries = null,
                            int? @timeout = null)
        {
            @Command = @command;
            @Name = @name;
            @RoleArn = @roleArn;
            @AllocatedCapacity = @allocatedCapacity;
            @Connections = @connections;
            @DefaultArguments = @defaultArguments;
            @Description = @description;
            @ExecutionProperty = @executionProperty;
            @MaxRetries = @maxRetries;
            @Timeout = @timeout;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "command", @out: false, min: 1, max: 1)]
        public command[] @Command { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "allocated_capacity", @out: false, min: 0, max: 1)]
        public int? @AllocatedCapacity { get; }

        [nterraform.Core.TerraformProperty(name: "connections", @out: false, min: 0, max: 1)]
        public string[] @Connections { get; }

        [nterraform.Core.TerraformProperty(name: "default_arguments", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @DefaultArguments { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "execution_property", @out: false, min: 0, max: 1)]
        public execution_property[] @ExecutionProperty { get; }

        [nterraform.Core.TerraformProperty(name: "max_retries", @out: false, min: 0, max: 1)]
        public int? @MaxRetries { get; }

        [nterraform.Core.TerraformProperty(name: "timeout", @out: false, min: 0, max: 1)]
        public int? @Timeout { get; }
    }

}
