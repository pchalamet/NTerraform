using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_ssm_maintenance_window")]
    public sealed class aws_ssm_maintenance_window : nterraform.resource
    {
        public aws_ssm_maintenance_window(int @cutoff,
                                          int @duration,
                                          string @name,
                                          string @schedule,
                                          bool? @allowUnassociatedTargets = null,
                                          bool? @enabled = null)
        {
            @Cutoff = @cutoff;
            @Duration = @duration;
            @Name = @name;
            @Schedule = @schedule;
            @AllowUnassociatedTargets = @allowUnassociatedTargets;
            @Enabled = @enabled;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "cutoff", @out: false, min: 1, max: 1)]
        public int @Cutoff { get; }

        [nterraform.TerraformProperty(name: "duration", @out: false, min: 1, max: 1)]
        public int @Duration { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "schedule", @out: false, min: 1, max: 1)]
        public string @Schedule { get; }

        [nterraform.TerraformProperty(name: "allow_unassociated_targets", @out: false, min: 0, max: 1)]
        public bool? @AllowUnassociatedTargets { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }
    }

}
