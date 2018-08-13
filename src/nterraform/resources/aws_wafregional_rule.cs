using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_wafregional_rule")]
    public sealed class aws_wafregional_rule : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "predicate")]
        public sealed class predicate : nterraform.Core.structure
        {
            public predicate(string @dataId,
                             bool @negated,
                             string @type)
            {
                @DataId = @dataId;
                @Negated = @negated;
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "data_id", @out: false, min: 1, max: 1)]
            public string @DataId { get; }

            [nterraform.Core.TerraformProperty(name: "negated", @out: false, min: 1, max: 1)]
            public bool @Negated { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        public aws_wafregional_rule(string @metricName,
                                    string @name,
                                    predicate[] @predicate = null)
        {
            @MetricName = @metricName;
            @Name = @name;
            @Predicate = @predicate;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "predicate", @out: false, min: 0, max: 0)]
        public predicate[] @Predicate { get; }
    }

}
