using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_batch_compute_environment")]
    public sealed class aws_batch_compute_environment : nterraform.Core.data
    {
        public aws_batch_compute_environment(string @computeEnvironmentName)
        {
            @ComputeEnvironmentName = @computeEnvironmentName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "compute_environment_name", @out: false, min: 1, max: 1)]
        public string @ComputeEnvironmentName { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "ecs_cluster_arn", @out: true, min: 0, max: 1)]
        public string @EcsClusterArn { get; }

        [nterraform.Core.TerraformProperty(name: "service_role", @out: true, min: 0, max: 1)]
        public string @ServiceRole { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "status_reason", @out: true, min: 0, max: 1)]
        public string @StatusReason { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
