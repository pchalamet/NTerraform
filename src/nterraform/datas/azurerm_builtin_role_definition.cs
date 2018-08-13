using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_builtin_role_definition")]
    public sealed class azurerm_builtin_role_definition : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "permissions")]
        public sealed class permissions : nterraform.structure
        {
            public permissions()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "actions", @out: true, min: 0, max: 1)]
            public string[] @Actions { get; }

            [nterraform.TerraformProperty(name: "not_actions", @out: true, min: 0, max: 1)]
            public string[] @NotActions { get; }
        }

        public azurerm_builtin_role_definition(string @name,
                                               permissions[] @permissions = null)
        {
            @Name = @name;
            @Permissions = @permissions;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "assignable_scopes", @out: true, min: 0, max: 1)]
        public string[] @AssignableScopes { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "permissions", @out: false, min: 0, max: 0)]
        public permissions[] @Permissions { get; }

        [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
