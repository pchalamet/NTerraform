using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_ecs_task_definition")]
    public sealed class aws_ecs_task_definition : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "volume")]
        public sealed class volume : nterraform.Core.structure
        {
            public volume(string @name,
                          string @hostPath = null)
            {
                @Name = @name;
                @HostPath = @hostPath;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "host_path", @out: false, min: 0, max: 1)]
            public string @HostPath { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "placement_constraints")]
        public sealed class placement_constraints : nterraform.Core.structure
        {
            public placement_constraints(string @type,
                                         string @expression = null)
            {
                @Type = @type;
                @Expression = @expression;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "expression", @out: false, min: 0, max: 1)]
            public string @Expression { get; }
        }

        public aws_ecs_task_definition(string @containerDefinitions,
                                       string @family,
                                       string @cpu = null,
                                       string @executionRoleArn = null,
                                       string @memory = null,
                                       placement_constraints[] @placementConstraints = null,
                                       string[] @requiresCompatibilities = null,
                                       string @taskRoleArn = null,
                                       volume[] @volume = null)
        {
            @ContainerDefinitions = @containerDefinitions;
            @Family = @family;
            @Cpu = @cpu;
            @ExecutionRoleArn = @executionRoleArn;
            @Memory = @memory;
            @PlacementConstraints = @placementConstraints;
            @RequiresCompatibilities = @requiresCompatibilities;
            @TaskRoleArn = @taskRoleArn;
            @Volume = @volume;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "container_definitions", @out: false, min: 1, max: 1)]
        public string @ContainerDefinitions { get; }

        [nterraform.Core.TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
        public string @Family { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "cpu", @out: false, min: 0, max: 1)]
        public string @Cpu { get; }

        [nterraform.Core.TerraformProperty(name: "execution_role_arn", @out: false, min: 0, max: 1)]
        public string @ExecutionRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "memory", @out: false, min: 0, max: 1)]
        public string @Memory { get; }

        [nterraform.Core.TerraformProperty(name: "network_mode", @out: true, min: 0, max: 1)]
        public string @NetworkMode { get; }

        [nterraform.Core.TerraformProperty(name: "placement_constraints", @out: false, min: 0, max: 10)]
        public placement_constraints[] @PlacementConstraints { get; }

        [nterraform.Core.TerraformProperty(name: "requires_compatibilities", @out: false, min: 0, max: 1)]
        public string[] @RequiresCompatibilities { get; }

        [nterraform.Core.TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
        public int? @Revision { get; }

        [nterraform.Core.TerraformProperty(name: "task_role_arn", @out: false, min: 0, max: 1)]
        public string @TaskRoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "volume", @out: false, min: 0, max: 0)]
        public volume[] @Volume { get; }
    }

}
