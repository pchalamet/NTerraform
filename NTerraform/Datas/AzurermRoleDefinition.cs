using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_role_definition")]
    public sealed class azurerm_role_definition : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "permissions")]
        public sealed class permissions
        {
            public permissions()
            {
            }

            [TerraformProperty(name: "actions", @out: true, nested: false, min: 0, max: 1)]
            public string[] @Actions { get; }

            [TerraformProperty(name: "not_actions", @out: true, nested: false, min: 0, max: 1)]
            public string[] @NotActions { get; }
        }

        public azurerm_role_definition(string @roleDefinitionId,
                                       string @scope,
                                       permissions[] @permissions = null)
        {
            @RoleDefinitionId = @roleDefinitionId;
            @Scope = @scope;
            @Permissions = @permissions;
        }

        [TerraformProperty(name: "role_definition_id", @out: false, nested: true, min: 1, max: 1)]
        public string @RoleDefinitionId { get; }

        [TerraformProperty(name: "scope", @out: false, nested: true, min: 1, max: 1)]
        public string @Scope { get; }

        [TerraformProperty(name: "assignable_scopes", @out: true, nested: true, min: 0, max: 1)]
        public string[] @AssignableScopes { get; }

        [TerraformProperty(name: "description", @out: true, nested: true, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "name", @out: true, nested: true, min: 0, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "permissions", @out: false, nested: true, min: 0, max: 0)]
        public permissions[] @Permissions { get; }

        [TerraformProperty(name: "type", @out: true, nested: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
