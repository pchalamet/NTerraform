using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_iam_policy_document")]
    public sealed class aws_iam_policy_document : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "statement")]
        public sealed class statement : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "data", typeName: "principals")]
            public sealed class principals : nterraform.Core.structure
            {
                public principals(string[] @identifiers,
                                  string @type)
                {
                    @Identifiers = @identifiers;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "identifiers", @out: false, min: 1, max: 1)]
                public string[] @Identifiers { get; }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            [nterraform.Core.TerraformStructure(category: "data", typeName: "condition")]
            public sealed class condition : nterraform.Core.structure
            {
                public condition(string @test,
                                 string[] @values,
                                 string @variable)
                {
                    @Test = @test;
                    @Values = @values;
                    @Variable = @variable;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "test", @out: false, min: 1, max: 1)]
                public string @Test { get; }

                [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
                public string[] @Values { get; }

                [nterraform.Core.TerraformProperty(name: "variable", @out: false, min: 1, max: 1)]
                public string @Variable { get; }
            }

            [nterraform.Core.TerraformStructure(category: "data", typeName: "not_principals")]
            public sealed class not_principals : nterraform.Core.structure
            {
                public not_principals(string[] @identifiers,
                                      string @type)
                {
                    @Identifiers = @identifiers;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "identifiers", @out: false, min: 1, max: 1)]
                public string[] @Identifiers { get; }

                [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            public statement(string[] @actions = null,
                             condition[] @condition = null,
                             string @effect = null,
                             string[] @notActions = null,
                             not_principals[] @notPrincipals = null,
                             string[] @notResources = null,
                             principals[] @principals = null,
                             string[] @resources = null,
                             string @sid = null)
            {
                @Actions = @actions;
                @Condition = @condition;
                @Effect = @effect;
                @NotActions = @notActions;
                @NotPrincipals = @notPrincipals;
                @NotResources = @notResources;
                @Principals = @principals;
                @Resources = @resources;
                @Sid = @sid;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "actions", @out: false, min: 0, max: 1)]
            public string[] @Actions { get; }

            [nterraform.Core.TerraformProperty(name: "condition", @out: false, min: 0, max: 0)]
            public condition[] @Condition { get; }

            [nterraform.Core.TerraformProperty(name: "effect", @out: false, min: 0, max: 1)]
            public string @Effect { get; }

            [nterraform.Core.TerraformProperty(name: "not_actions", @out: false, min: 0, max: 1)]
            public string[] @NotActions { get; }

            [nterraform.Core.TerraformProperty(name: "not_principals", @out: false, min: 0, max: 0)]
            public not_principals[] @NotPrincipals { get; }

            [nterraform.Core.TerraformProperty(name: "not_resources", @out: false, min: 0, max: 1)]
            public string[] @NotResources { get; }

            [nterraform.Core.TerraformProperty(name: "principals", @out: false, min: 0, max: 0)]
            public principals[] @Principals { get; }

            [nterraform.Core.TerraformProperty(name: "resources", @out: false, min: 0, max: 1)]
            public string[] @Resources { get; }

            [nterraform.Core.TerraformProperty(name: "sid", @out: false, min: 0, max: 1)]
            public string @Sid { get; }
        }

        public aws_iam_policy_document(statement[] @statement,
                                       string @overrideJson = null,
                                       string @policyId = null,
                                       string @sourceJson = null)
        {
            @Statement = @statement;
            @OverrideJson = @overrideJson;
            @PolicyId = @policyId;
            @SourceJson = @sourceJson;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "statement", @out: false, min: 1, max: 0)]
        public statement[] @Statement { get; }

        [nterraform.Core.TerraformProperty(name: "json", @out: true, min: 0, max: 1)]
        public string @Json { get; }

        [nterraform.Core.TerraformProperty(name: "override_json", @out: false, min: 0, max: 1)]
        public string @OverrideJson { get; }

        [nterraform.Core.TerraformProperty(name: "policy_id", @out: false, min: 0, max: 1)]
        public string @PolicyId { get; }

        [nterraform.Core.TerraformProperty(name: "source_json", @out: false, min: 0, max: 1)]
        public string @SourceJson { get; }
    }

}
