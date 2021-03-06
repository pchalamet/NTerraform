using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_iam_policy_document")]
    public sealed class aws_iam_policy_document : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "statement")]
        public sealed class statement : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "data", typeName: "principals")]
            public sealed class principals : nterraform.structure
            {
                public principals(string[] @identifiers,
                                  string @type)
                {
                    @Identifiers = @identifiers;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "identifiers", @out: false, min: 1, max: 1)]
                public string[] @Identifiers { get; }

                [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            [nterraform.TerraformStructure(category: "data", typeName: "not_principals")]
            public sealed class not_principals : nterraform.structure
            {
                public not_principals(string[] @identifiers,
                                      string @type)
                {
                    @Identifiers = @identifiers;
                    @Type = @type;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "identifiers", @out: false, min: 1, max: 1)]
                public string[] @Identifiers { get; }

                [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
                public string @Type { get; }
            }

            [nterraform.TerraformStructure(category: "data", typeName: "condition")]
            public sealed class condition : nterraform.structure
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

                [nterraform.TerraformProperty(name: "test", @out: false, min: 1, max: 1)]
                public string @Test { get; }

                [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
                public string[] @Values { get; }

                [nterraform.TerraformProperty(name: "variable", @out: false, min: 1, max: 1)]
                public string @Variable { get; }
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

            [nterraform.TerraformProperty(name: "actions", @out: false, min: 0, max: 1)]
            public string[] @Actions { get; }

            [nterraform.TerraformProperty(name: "condition", @out: false, min: 0, max: 0)]
            public condition[] @Condition { get; }

            [nterraform.TerraformProperty(name: "effect", @out: false, min: 0, max: 1)]
            public string @Effect { get; }

            [nterraform.TerraformProperty(name: "not_actions", @out: false, min: 0, max: 1)]
            public string[] @NotActions { get; }

            [nterraform.TerraformProperty(name: "not_principals", @out: false, min: 0, max: 0)]
            public not_principals[] @NotPrincipals { get; }

            [nterraform.TerraformProperty(name: "not_resources", @out: false, min: 0, max: 1)]
            public string[] @NotResources { get; }

            [nterraform.TerraformProperty(name: "principals", @out: false, min: 0, max: 0)]
            public principals[] @Principals { get; }

            [nterraform.TerraformProperty(name: "resources", @out: false, min: 0, max: 1)]
            public string[] @Resources { get; }

            [nterraform.TerraformProperty(name: "sid", @out: false, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "statement", @out: false, min: 1, max: 0)]
        public statement[] @Statement { get; }

        [nterraform.TerraformProperty(name: "json", @out: true, min: 0, max: 1)]
        public string @Json { get; }

        [nterraform.TerraformProperty(name: "override_json", @out: false, min: 0, max: 1)]
        public string @OverrideJson { get; }

        [nterraform.TerraformProperty(name: "policy_id", @out: false, min: 0, max: 1)]
        public string @PolicyId { get; }

        [nterraform.TerraformProperty(name: "source_json", @out: false, min: 0, max: 1)]
        public string @SourceJson { get; }
    }

}
