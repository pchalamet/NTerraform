using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_role_definition : NTerraform.resource
    {
        public class permissions
        {
            public permissions(List<string> @actions = null,
                               List<string> @notActions = null)
            {
                @Actions = @actions;
                @NotActions = @notActions;
            }

            public List<string> @Actions { get; }
            public List<string> @NotActions { get; }
        }

        public azurerm_role_definition(List<string> @assignableScopes,
                                       string @name,
                                       List<permissions> @permissions,
                                       string @scope,
                                       string @description = null)
        {
            @AssignableScopes = @assignableScopes;
            @Name = @name;
            @Permissions = @permissions;
            @Scope = @scope;
            @Description = @description;
        }

        public List<string> @AssignableScopes { get; }
        public string @Name { get; }
        public List<permissions> @Permissions { get; }
        public string @Scope { get; }
        public string @Description { get; }
        public string @RoleDefinitionId { get; }
    }

}
