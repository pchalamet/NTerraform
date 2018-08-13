using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_waf_rate_based_rule")]
    public sealed class aws_waf_rate_based_rule : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "predicates")]
        public sealed class predicates : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "data_id", @out: false, min: 1, max: 1)]
            public string @DataId { get; }

            [nterraform.Core.TerraformProperty(name: "negated", @out: false, min: 1, max: 1)]
            public bool @Negated { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        public aws_waf_rate_based_rule(string @metricName,
                                       string @name,
                                       string @rateKey,
                                       int @rateLimit,
                                       predicates[] @predicates = null)
        {
            @MetricName = @metricName;
            @Name = @name;
            @RateKey = @rateKey;
            @RateLimit = @rateLimit;
            @Predicates = @predicates;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "rate_key", @out: false, min: 1, max: 1)]
        public string @RateKey { get; }

        [nterraform.Core.TerraformProperty(name: "rate_limit", @out: false, min: 1, max: 1)]
        public int @RateLimit { get; }

        [nterraform.Core.TerraformProperty(name: "predicates", @out: false, min: 0, max: 0)]
        public predicates[] @Predicates { get; }
    }

}
