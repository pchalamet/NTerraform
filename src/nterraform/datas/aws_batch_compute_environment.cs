using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_batch_compute_environment")]
    public sealed class aws_batch_compute_environment : nterraform.data
    {
        public aws_batch_compute_environment(string @computeEnvironmentName)
        {
            @ComputeEnvironmentName = @computeEnvironmentName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "compute_environment_name", @out: false, min: 1, max: 1)]
        public string @ComputeEnvironmentName { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "ecs_cluster_arn", @out: true, min: 0, max: 1)]
        public string @EcsClusterArn { get; }

        [nterraform.TerraformProperty(name: "service_role", @out: true, min: 0, max: 1)]
        public string @ServiceRole { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "status_reason", @out: true, min: 0, max: 1)]
        public string @StatusReason { get; }

        [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
