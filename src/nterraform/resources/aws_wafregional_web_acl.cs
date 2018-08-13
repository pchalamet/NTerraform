using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_wafregional_web_acl")]
    public sealed class aws_wafregional_web_acl : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "default_action")]
        public sealed class default_action : nterraform.Core.structure
        {
            public default_action(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "rule")]
        public sealed class rule : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "action")]
            public sealed class action : nterraform.Core.structure
            {
                public action(string @type)
                {
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "override_action")]
            public sealed class override_action : nterraform.Core.structure
            {
                public override_action(string @type)
                {
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
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

            [nterraform.Core.TerraformProperty(name: "priority", @out: false, min: 1, max: 1)]
            public int @Priority { get; }

            [nterraform.Core.TerraformProperty(name: "rule_id", @out: false, min: 1, max: 1)]
            public string @RuleId { get; }

            [nterraform.Core.TerraformProperty(name: "action", @out: false, min: 0, max: 1)]
            public action[] @Action { get; }

            [nterraform.Core.TerraformProperty(name: "override_action", @out: false, min: 0, max: 1)]
            public override_action[] @OverrideAction { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "default_action", @out: false, min: 1, max: 1)]
        public default_action[] @DefaultAction { get; }

        [nterraform.Core.TerraformProperty(name: "metric_name", @out: false, min: 1, max: 1)]
        public string @MetricName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "rule", @out: false, min: 0, max: 0)]
        public rule[] @Rule { get; }
    }

}
