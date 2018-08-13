using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_glue_job")]
    public sealed class aws_glue_job : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "command")]
        public sealed class command : nterraform.structure
        {
            public command(string @scriptLocation,
                           string @name = null)
            {
                @ScriptLocation = @scriptLocation;
                @Name = @name;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "script_location", @out: false, min: 1, max: 1)]
            public string @ScriptLocation { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "execution_property")]
        public sealed class execution_property : nterraform.structure
        {
            public execution_property(int? @maxConcurrentRuns = null)
            {
                @MaxConcurrentRuns = @maxConcurrentRuns;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "max_concurrent_runs", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "command", @out: false, min: 1, max: 1)]
        public command[] @Command { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.TerraformProperty(name: "allocated_capacity", @out: false, min: 0, max: 1)]
        public int? @AllocatedCapacity { get; }

        [nterraform.TerraformProperty(name: "connections", @out: false, min: 0, max: 1)]
        public string[] @Connections { get; }

        [nterraform.TerraformProperty(name: "default_arguments", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @DefaultArguments { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "execution_property", @out: false, min: 0, max: 1)]
        public execution_property[] @ExecutionProperty { get; }

        [nterraform.TerraformProperty(name: "max_retries", @out: false, min: 0, max: 1)]
        public int? @MaxRetries { get; }

        [nterraform.TerraformProperty(name: "timeout", @out: false, min: 0, max: 1)]
        public int? @Timeout { get; }
    }

}
