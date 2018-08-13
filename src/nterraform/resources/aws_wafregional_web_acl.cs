using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_wafregional_web_acl")]
    public sealed class aws_wafregional_web_acl : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "default_action")]
        public sealed class default_action : nterraform.structure
        {
            public default_action(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "rule")]
        public sealed class rule : nterraform.structure
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

            [nterraform.TerraformStructure(category: "resource", typeName: "override_action")]
            public sealed class override_action : nterraform.structure
            {
                public override_action(string @type)
                {
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            public rule(int @priority,
                        string @ruleId,
                        action[] @action = null,
                        override_action[] @overrideAction = null,
                        string @type = null)
            {
                @Priority = @priority;
                @RuleId = @ruleId;
                @Action = @action;
                @OverrideAction = @overrideAction;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.TerraformProperty(name: "rule_id", @out: false, min: 1, max: 1)]
            public string @RuleId { get; }

            [nterraform.TerraformProperty(name: "action", @out: false, min: 0, max: 1)]
            public action[] @Action { get; }

            [nterraform.TerraformProperty(name: "override_action", @out: false, min: 0, max: 1)]
            public override_action[] @OverrideAction { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
            public string @Type { get; }
        }

        public aws_wafregional_web_acl(default_action[] @defaultAction,
                                       string @metricName,
                                       string @name,
                                       rule[] @rule = null)
        {
            @DefaultAction = @defaultAction;
            @MetricName = @metricName;
            @Name = @name;
            @Rule = @rule;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "default_action", @out: false, min: 1, max: 1)]
        public default_action[] @DefaultAction { get; }

        [nterraform.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "rule", @out: false, min: 0, max: 0)]
        public rule[] @Rule { get; }
    }

}
