using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_role_definition")]
    public sealed class azurerm_role_definition : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "permissions")]
        public sealed class permissions
        {
            public permissions(string[] @actions = null,
                               string[] @notActions = null)
            {
                @Actions = @actions;
                @NotActions = @notActions;
            }

            [TerraformProperty(name: "actions", @out: false, min: 0, max: 1)]
            public string[] @Actions { get; }

            [TerraformProperty(name: "not_actions", @out: false, min: 0, max: 1)]
            public string[] @NotActions { get; }
        }

        public azurerm_role_definition(string[] @assignableScopes,
                                       string @name,
                                       permissions[] @permissions,
                                       string @scope,
                                       string @description = null)
        {
            @AssignableScopes = @assignableScopes;
            @Name = @name;
            @Permissions = @permissions;
            @Scope = @scope;
            @Description = @description;
        }

        [TerraformProperty(name: "assignable_scopes", @out: false, min: 1, max: 1)]
        public string[] @AssignableScopes { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "permissions", @out: false, min: 1, max: 0)]
        public permissions[] @Permissions { get; }

        [TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
        public string @Scope { get; }

        [TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "role_definition_id", @out: true, min: 0, max: 1)]
        public string @RoleDefinitionId { get; }
    }

}
