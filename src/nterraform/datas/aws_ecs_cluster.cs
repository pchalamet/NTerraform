using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_ecs_cluster")]
    public sealed class aws_ecs_cluster : nterraform.data
    {
        public aws_ecs_cluster(string @clusterName)
        {
            @ClusterName = @clusterName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "cluster_name", @out: false, min: 1, max: 1)]
        public string @ClusterName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "pending_tasks_count", @out: true, min: 0, max: 1)]
        public int? @PendingTasksCount { get; }

        [nterraform.TerraformProperty(name: "registered_container_instances_count", @out: true, min: 0, max: 1)]
        public int? @RegisteredContainerInstancesCount { get; }

        [nterraform.TerraformProperty(name: "running_tasks_count", @out: true, min: 0, max: 1)]
        public int? @RunningTasksCount { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
