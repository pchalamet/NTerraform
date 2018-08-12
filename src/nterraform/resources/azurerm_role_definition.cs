using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_role_definition")]
    public sealed class azurerm_role_definition : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "permissions")]
        public sealed class permissions : nterraform.Core.structure
        {
            public permissions(FSharpList<string> @actions = null,
                               FSharpList<string> @notActions = null)
            {
                @Actions = @actions ?? FSharpList<string>.Empty;
                @NotActions = @notActions ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "actions", @out: false, min: 0, max: 1)]
            public FSharpList<string> @Actions { get; }

            [nterraform.Core.TerraformProperty(name: "not_actions", @out: false, min: 0, max: 1)]
            public FSharpList<string> @NotActions { get; }
        }

        public azurerm_role_definition(FSharpList<string> @assignableScopes,
                                       string @name,
                                       FSharpList<permissions> @permissions,
                                       string @scope,
                                       string @description = null)
        {
            @AssignableScopes = @assignableScopes;
            @Name = @name;
            @Permissions = @permissions;
            @Scope = @scope;
            @Description = @description;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "assignable_scopes", @out: false, min: 1, max: 1)]
        public FSharpList<string> @AssignableScopes { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "permissions", @out: false, min: 1, max: 0)]
        public FSharpList<permissions> @Permissions { get; }

        [nterraform.Core.TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
        public string @Scope { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "role_definition_id", @out: true, min: 0, max: 1)]
        public string @RoleDefinitionId { get; }
    }

}
