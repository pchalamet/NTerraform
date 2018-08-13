using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_cognito_identity_pool_roles_attachment")]
    public sealed class aws_cognito_identity_pool_roles_attachment : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "role_mapping")]
        public sealed class role_mapping : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "mapping_rule")]
            public sealed class mapping_rule : nterraform.structure
            {
                public mapping_rule(string @claim,
                                    string @matchType,
                                    string @roleArn,
                                    string @value)
                {
                    @Claim = @claim;
                    @MatchType = @matchType;
                    @RoleArn = @roleArn;
                    @Value = @value;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "claim", @out: false, min: 1, max: 1)]
                public string @Claim { get; }

                [nterraform.TerraformProperty(name: "match_type", @out: false, min: 1, max: 1)]
                public string @MatchType { get; }

                [nterraform.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
                public string @RoleArn { get; }

                [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
                public string @Value { get; }
            }

            public role_mapping(string @identityProvider,
                                string @type,
                                string @ambiguousRoleResolution = null,
                                mapping_rule[] @mappingRule = null)
            {
                @IdentityProvider = @identityProvider;
                @Type = @type;
                @AmbiguousRoleResolution = @ambiguousRoleResolution;
                @MappingRule = @mappingRule;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "identity_provider", @out: false, min: 1, max: 1)]
            public string @IdentityProvider { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "ambiguous_role_resolution", @out: false, min: 0, max: 1)]
            public string @AmbiguousRoleResolution { get; }

            [nterraform.TerraformProperty(name: "mapping_rule", @out: false, min: 0, max: 25)]
            public mapping_rule[] @MappingRule { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "roles")]
        public sealed class roles : nterraform.structure
        {
            public roles(string @authenticated = null,
                         string @unauthenticated = null)
            {
                @Authenticated = @authenticated;
                @Unauthenticated = @unauthenticated;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "authenticated", @out: false, min: 0, max: 1)]
            public string @Authenticated { get; }

            [nterraform.TerraformProperty(name: "unauthenticated", @out: false, min: 0, max: 1)]
            public string @Unauthenticated { get; }
        }

        public aws_cognito_identity_pool_roles_attachment(string @identityPoolId,
                                                          Dictionary<string,roles> @roles,
                                                          role_mapping[] @roleMapping = null)
        {
            @IdentityPoolId = @identityPoolId;
            @Roles = @roles;
            @RoleMapping = @roleMapping;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "identity_pool_id", @out: false, min: 1, max: 1)]
        public string @IdentityPoolId { get; }

        [nterraform.TerraformProperty(name: "roles", @out: false, min: 1, max: 0)]
        public Dictionary<string,roles> @Roles { get; }

        [nterraform.TerraformProperty(name: "role_mapping", @out: false, min: 0, max: 0)]
        public role_mapping[] @RoleMapping { get; }
    }

}
