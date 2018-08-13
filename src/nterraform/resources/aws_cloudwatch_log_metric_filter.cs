using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cloudwatch_log_metric_filter")]
    public sealed class aws_cloudwatch_log_metric_filter : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "metric_transformation")]
        public sealed class metric_transformation : nterraform.structure
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

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "namespace", @out: false, min: 1, max: 1)]
            public string @Namespace { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }

            [nterraform.TerraformProperty(name: "default_value", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "log_group_name", @out: false, min: 1, max: 1)]
        public string @LogGroupName { get; }

        [nterraform.TerraformProperty(name: "metric_transformation", @out: false, min: 1, max: 1)]
        public metric_transformation[] @MetricTransformation { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "pattern", @out: false, min: 1, max: 1)]
        public string @Pattern { get; }
    }

}
