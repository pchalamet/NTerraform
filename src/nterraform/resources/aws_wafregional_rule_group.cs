using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_wafregional_rule_group")]
    public sealed class aws_wafregional_rule_group : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "activated_rule")]
        public sealed class activated_rule : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "action")]
            public sealed class action : nterraform.structure
            {
                public action(string @type)
                {
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            public activated_rule(action[] @action,
                                  int @priority,
                                  string @ruleId,
                                  string @type = null)
            {
                @Action = @action;
                @Priority = @priority;
                @RuleId = @ruleId;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "action", @out: false, min: 1, max: 1)]
            public action[] @Action { get; }

            [nterraform.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.TerraformProperty(name: "rule_id", @out: false, min: 1, max: 1)]
            public string @RuleId { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }
        }

        public aws_wafregional_rule_group(string @metricName,
                                          string @name,
                                          activated_rule[] @activatedRule = null)
        {
            @MetricName = @metricName;
            @Name = @name;
            @ActivatedRule = @activatedRule;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "activated_rule", @out: false, min: 0, max: 0)]
        public activated_rule[] @ActivatedRule { get; }
    }

}
