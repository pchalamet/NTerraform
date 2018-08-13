using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_cognito_resource_server")]
    public sealed class aws_cognito_resource_server : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "scope")]
        public sealed class scope : nterraform.Core.structure
        {
            public scope(string @scopeDescription,
                         string @scopeName)
            {
                @ScopeDescription = @scopeDescription;
                @ScopeName = @scopeName;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "scope_description", @out: false, min: 1, max: 1)]
            public string @ScopeDescription { get; }

            [nterraform.Core.TerraformProperty(name: "scope_name", @out: false, min: 1, max: 1)]
            public string @ScopeName { get; }
        }

        public aws_cognito_resource_server(string @identifier,
                                           string @name,
                                           string @userPoolId,
                                           scope[] @scope = null)
        {
            @Identifier = @identifier;
            @Name = @name;
            @UserPoolId = @userPoolId;
            @Scope = @scope;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "identifier", @out: false, min: 1, max: 1)]
        public string @Identifier { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "user_pool_id", @out: false, min: 1, max: 1)]
        public string @UserPoolId { get; }

        [nterraform.Core.TerraformProperty(name: "scope", @out: false, min: 0, max: 25)]
        public scope[] @Scope { get; }

        [nterraform.Core.TerraformProperty(name: "scope_identifiers", @out: true, min: 0, max: 1)]
        public string[] @ScopeIdentifiers { get; }
    }

}
