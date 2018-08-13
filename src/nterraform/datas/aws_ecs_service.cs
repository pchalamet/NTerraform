using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_ecs_service")]
    public sealed class aws_ecs_service : nterraform.data
    {
        public aws_ecs_service(string @clusterArn,
                               string @serviceName)
        {
            @ClusterArn = @clusterArn;
            @ServiceName = @serviceName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "cluster_arn", @out: false, min: 1, max: 1)]
        public string @ClusterArn { get; }

        [nterraform.TerraformProperty(name: "service_name", @out: false, min: 1, max: 1)]
        public string @ServiceName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "desired_count", @out: true, min: 0, max: 1)]
        public int? @DesiredCount { get; }

        [nterraform.TerraformProperty(name: "launch_type", @out: true, min: 0, max: 1)]
        public string @LaunchType { get; }

        [nterraform.TerraformProperty(name: "scheduling_strategy", @out: true, min: 0, max: 1)]
        public string @SchedulingStrategy { get; }

        [nterraform.TerraformProperty(name: "task_definition", @out: true, min: 0, max: 1)]
        public string @TaskDefinition { get; }
    }

}
