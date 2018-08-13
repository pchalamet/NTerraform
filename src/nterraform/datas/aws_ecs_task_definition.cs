using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_ecs_task_definition")]
    public sealed class aws_ecs_task_definition : nterraform.Core.data
    {
        public aws_ecs_task_definition(string @taskDefinition)
        {
            @TaskDefinition = @taskDefinition;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "task_definition", @out: false, min: 1, max: 1)]
        public string @TaskDefinition { get; }

        [nterraform.Core.TerraformProperty(name: "family", @out: true, min: 0, max: 1)]
        public string @Family { get; }

        [nterraform.Core.TerraformProperty(name: "network_mode", @out: true, min: 0, max: 1)]
        public string @NetworkMode { get; }

        [nterraform.Core.TerraformProperty(name: "revision", @out: true, min: 0, max: 1)]
        public int? @Revision { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "task_role_arn", @out: true, min: 0, max: 1)]
        public string @TaskRoleArn { get; }
    }

}
