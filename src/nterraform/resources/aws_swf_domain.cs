using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_swf_domain")]
    public sealed class aws_swf_domain : nterraform.resource
    {
        public aws_swf_domain(string @workflowExecutionRetentionPeriodInDays,
                              string @description = null,
                              string @namePrefix = null)
        {
            @WorkflowExecutionRetentionPeriodInDays = @workflowExecutionRetentionPeriodInDays;
            @Description = @description;
            @NamePrefix = @namePrefix;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "workflow_execution_retention_period_in_days", @out: false, min: 1, max: 1)]
        public string @WorkflowExecutionRetentionPeriodInDays { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }
    }

}
