using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_role_assignment")]
    public sealed class azurerm_role_assignment : NTerraform.resource
    {
        public azurerm_role_assignment(string @principalId,
                                       string @scope,
                                       string @roleDefinitionName = null)
        {
            @PrincipalId = @principalId;
            @Scope = @scope;
            @RoleDefinitionName = @roleDefinitionName;
        }

        [TerraformProperty(name: "principal_id", @out: false, min: 1, max: 1)]
        public string @PrincipalId { get; }

        [TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
        public string @Scope { get; }

        [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "role_definition_id", @out: true, min: 0, max: 1)]
        public string @RoleDefinitionId { get; }

        [TerraformProperty(name: "role_definition_name", @out: false, min: 0, max: 1)]
        public string @RoleDefinitionName { get; }
    }

}
