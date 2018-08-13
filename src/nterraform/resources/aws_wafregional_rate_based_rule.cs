using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_wafregional_rate_based_rule")]
    public sealed class aws_wafregional_rate_based_rule : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "predicate")]
        public sealed class predicate : nterraform.structure
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

            [nterraform.TerraformProperty(name: "data_id", @out: false, min: 1, max: 1)]
            public string @DataId { get; }

            [nterraform.TerraformProperty(name: "negated", @out: false, min: 1, max: 1)]
            public bool @Negated { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        public aws_wafregional_rate_based_rule(string @metricName,
                                               string @name,
                                               string @rateKey,
                                               int @rateLimit,
                                               predicate[] @predicate = null)
        {
            @MetricName = @metricName;
            @Name = @name;
            @RateKey = @rateKey;
            @RateLimit = @rateLimit;
            @Predicate = @predicate;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "rate_key", @out: false, min: 1, max: 1)]
        public string @RateKey { get; }

        [nterraform.TerraformProperty(name: "rate_limit", @out: false, min: 1, max: 1)]
        public int @RateLimit { get; }

        [nterraform.TerraformProperty(name: "predicate", @out: false, min: 0, max: 0)]
        public predicate[] @Predicate { get; }
    }

}
