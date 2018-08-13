using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_batch_job_queue")]
    public sealed class aws_batch_job_queue : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "compute_environment_order")]
        public sealed class compute_environment_order : nterraform.Core.structure
        {
            public compute_environment_order()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "compute_environment", @out: true, min: 0, max: 1)]
            public string @ComputeEnvironment { get; }

            [nterraform.Core.TerraformProperty(name: "order", @out: true, min: 0, max: 1)]
            public int? @Order { get; }
        }

        public aws_batch_job_queue(string @name,
                                   compute_environment_order[] @computeEnvironmentOrder = null)
        {
            @Name = @name;
            @ComputeEnvironmentOrder = @computeEnvironmentOrder;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "compute_environment_order", @out: false, min: 0, max: 0)]
        public compute_environment_order[] @ComputeEnvironmentOrder { get; }

        [nterraform.Core.TerraformProperty(name: "priority", @out: true, min: 0, max: 1)]
        public int? @Priority { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "status_reason", @out: true, min: 0, max: 1)]
        public string @StatusReason { get; }
    }

}
