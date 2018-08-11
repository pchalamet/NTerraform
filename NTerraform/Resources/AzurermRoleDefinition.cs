using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_role_definition : NTerraform.resource
    {
        public class permissions
        {
            public permissions(string[] @actions = null,
                               string[] @notActions = null)
            {
                @Actions = @actions;
                @NotActions = @notActions;
            }

            public string[] @Actions { get; }
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

        public string[] @AssignableScopes { get; }
        public string @Name { get; }
        public permissions[] @Permissions { get; }
        public string @Scope { get; }
        public string @Description { get; }
        public string @RoleDefinitionId { get; }
    }

}
