using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_waf_rule")]
    public sealed class aws_waf_rule : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "predicates")]
        public sealed class predicates : nterraform.structure
        {
            public predicates(string @dataId,
                              bool @negated,
                              string @type)
            {
                @DataId = @dataId;
                @Negated = @negated;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "data_id", @out: false, min: 1, max: 1)]
            public string @DataId { get; }

            [nterraform.TerraformProperty(name: "negated", @out: false, min: 1, max: 1)]
            public bool @Negated { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        public aws_waf_rule(string @metricName,
                            string @name,
                            predicates[] @predicates = null)
        {
            @MetricName = @metricName;
            @Name = @name;
            @Predicates = @predicates;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "predicates", @out: false, min: 0, max: 0)]
        public predicates[] @Predicates { get; }
    }

}
