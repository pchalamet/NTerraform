using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_glue_trigger")]
    public sealed class aws_glue_trigger : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "predicate")]
        public sealed class predicate : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "conditions")]
            public sealed class conditions : nterraform.Core.structure
            {
                public conditions(string @jobName,
                                  string @state,
                                  string @logicalOperator = null)
                {
                    @JobName = @jobName;
                    @State = @state;
                    @LogicalOperator = @logicalOperator;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "job_name", @out: false, min: 1, max: 1)]
                public string @JobName { get; }

                [nterraform.Core.TerraformProperty(name: "state", @out: false, min: 1, max: 1)]
                public string @State { get; }

                [nterraform.Core.TerraformProperty(name: "logical_operator", @out: false, min: 0, max: 1)]
                public string @LogicalOperator { get; }
            }

            public predicate(conditions[] @conditions,
                             string @logical = null)
            {
                @Conditions = @conditions;
                @Logical = @logical;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "conditions", @out: false, min: 1, max: 0)]
            public conditions[] @Conditions { get; }

            [nterraform.Core.TerraformProperty(name: "logical", @out: false, min: 0, max: 1)]
            public string @Logical { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "actions")]
        public sealed class actions : nterraform.Core.structure
        {
            public actions(string @jobName,
                           Dictionary<string,string> @arguments = null,
                           int? @timeout = null)
            {
                @JobName = @jobName;
                @Arguments = @arguments;
                @Timeout = @timeout;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "job_name", @out: false, min: 1, max: 1)]
            public string @JobName { get; }

            [nterraform.Core.TerraformProperty(name: "arguments", @out: false, min: 0, max: 1)]
            public Dictionary<string,string> @Arguments { get; }

            [nterraform.Core.TerraformProperty(name: "timeout", @out: false, min: 0, max: 1)]
            public int? @Timeout { get; }
        }

        public aws_glue_trigger(actions[] @actions,
                                string @name,
                                string @type,
                                string @description = null,
                                bool? @enabled = null,
                                predicate[] @predicate = null,
                                string @schedule = null)
        {
            @Actions = @actions;
            @Name = @name;
            @Type = @type;
            @Description = @description;
            @Enabled = @enabled;
            @Predicate = @predicate;
            @Schedule = @schedule;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "actions", @out: false, min: 1, max: 0)]
        public actions[] @Actions { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "predicate", @out: false, min: 0, max: 1)]
        public predicate[] @Predicate { get; }

        [nterraform.Core.TerraformProperty(name: "schedule", @out: false, min: 0, max: 1)]
        public string @Schedule { get; }
    }

}
