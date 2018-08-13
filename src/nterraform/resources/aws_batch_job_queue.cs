using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_batch_job_queue")]
    public sealed class aws_batch_job_queue : nterraform.resource
    {
        public aws_batch_job_queue(string[] @computeEnvironments,
                                   string @name,
                                   int @priority,
                                   string @state)
        {
            @ComputeEnvironments = @computeEnvironments;
            @Name = @name;
            @Priority = @priority;
            @State = @state;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "compute_environments", @out: false, min: 1, max: 1)]
        public string[] @ComputeEnvironments { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
        public int @Priority { get; }

        [nterraform.TerraformProperty(name: "state", @out: false, min: 1, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }
    }

}
