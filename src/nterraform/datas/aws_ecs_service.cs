using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_ecs_service")]
    public sealed class aws_ecs_service : nterraform.Core.data
    {
        public aws_ecs_service(string @clusterArn,
                               string @serviceName)
        {
            @ClusterArn = @clusterArn;
            @ServiceName = @serviceName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cluster_arn", @out: false, min: 1, max: 1)]
        public string @ClusterArn { get; }

        [nterraform.Core.TerraformProperty(name: "service_name", @out: false, min: 1, max: 1)]
        public string @ServiceName { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "desired_count", @out: true, min: 0, max: 1)]
        public int? @DesiredCount { get; }

        [nterraform.Core.TerraformProperty(name: "launch_type", @out: true, min: 0, max: 1)]
        public string @LaunchType { get; }

        [nterraform.Core.TerraformProperty(name: "scheduling_strategy", @out: true, min: 0, max: 1)]
        public string @SchedulingStrategy { get; }

        [nterraform.Core.TerraformProperty(name: "task_definition", @out: true, min: 0, max: 1)]
        public string @TaskDefinition { get; }
    }

}
