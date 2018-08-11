using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_builtin_role_definition : NTerraform.data
    {
        public class permissions
        {
            public permissions()
            {
            }

            public string[] @Actions { get; }
            public string[] @NotActions { get; }
        }

        public azurerm_builtin_role_definition(string @name,
                                               permissions[] @permissions = null)
        {
            @Name = @name;
            @Permissions = @permissions;
        }

        public string @Name { get; }
        public string[] @AssignableScopes { get; }
        public string @Description { get; }
        public permissions[] @Permissions { get; }
        public string @Type { get; }
    }

}
