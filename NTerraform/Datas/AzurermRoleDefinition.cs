using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_role_definition : NTerraform.data
    {
        public class permissions
        {
            public permissions()
            {
            }

            public string[] @Actions { get; }
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

        public string @RoleDefinitionId { get; }
        public string @Scope { get; }
        public string[] @AssignableScopes { get; }
        public string @Description { get; }
        public string @Name { get; }
        public permissions[] @Permissions { get; }
        public string @Type { get; }
    }

}
