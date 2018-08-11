using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @PrincipalId { get; }
        public string @Scope { get; }
        public string @Name { get; }
        public string @RoleDefinitionId { get; }
        public string @RoleDefinitionName { get; }
    }

}
