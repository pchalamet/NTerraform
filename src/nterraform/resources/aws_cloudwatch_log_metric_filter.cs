using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_metric_filter")]
    public sealed class aws_cloudwatch_log_metric_filter : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "metric_transformation")]
        public sealed class metric_transformation : nterraform.Core.structure
        {
            public metric_transformation(string @name,
                                         string @namespace,
                                         string @value,
                                         int? @defaultValue = null)
            {
                @Name = @name;
                @Namespace = @namespace;
                @Value = @value;
                @DefaultValue = @defaultValue;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
            public string @Namespace { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }

            [nterraform.Core.TerraformProperty(name: "default_value", @out: false, min: 0, max: 1)]
            public int? @DefaultValue { get; }
        }

        public aws_cloudwatch_log_metric_filter(string @logGroupName,
                                                metric_transformation[] @metricTransformation,
                                                string @name,
                                                string @pattern)
        {
            @LogGroupName = @logGroupName;
            @MetricTransformation = @metricTransformation;
            @Name = @name;
            @Pattern = @pattern;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "log_group_name", @out: false, min: 1, max: 1)]
        public string @LogGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "metric_transformation", @out: false, min: 1, max: 1)]
        public metric_transformation[] @MetricTransformation { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "pattern", @out: false, min: 1, max: 1)]
        public string @Pattern { get; }
    }

}
