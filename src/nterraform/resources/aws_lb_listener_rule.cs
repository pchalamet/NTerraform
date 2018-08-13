using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lb_listener_rule")]
    public sealed class aws_lb_listener_rule : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "action")]
        public sealed class action : nterraform.structure
        {
            public action(string @targetGroupArn,
                          string @type)
            {
                @TargetGroupArn = @targetGroupArn;
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "target_group_arn", @out: false, min: 1, max: 1)]
            public string @TargetGroupArn { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "condition")]
        public sealed class condition : nterraform.structure
        {
            public condition(string @field = null,
                             string[] @values = null)
            {
                @Field = @field;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "field", @out: false, min: 0, max: 1)]
            public string @Field { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 0, max: 1)]
            public string[] @Values { get; }
        }

        public aws_lb_listener_rule(action[] @action,
                                    condition[] @condition,
                                    string @listenerArn)
        {
            @Action = @action;
            @Condition = @condition;
            @ListenerArn = @listenerArn;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "action", @out: false, min: 1, max: 0)]
        public action[] @Action { get; }

        [nterraform.TerraformProperty(name: "condition", @out: false, min: 1, max: 0)]
        public condition[] @Condition { get; }

        [nterraform.TerraformProperty(name: "listener_arn", @out: false, min: 1, max: 1)]
        public string @ListenerArn { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "priority", @out: true, min: 0, max: 1)]
        public int? @Priority { get; }
    }

}
