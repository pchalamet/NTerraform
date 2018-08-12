using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_builtin_role_definition")]
    public sealed class azurerm_builtin_role_definition : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "permissions")]
        public sealed class permissions : nterraform.Core.structure
        {
            public permissions()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "actions", @out: true, min: 0, max: 1)]
            public FSharpList<string> @Actions { get; }

            [nterraform.Core.TerraformProperty(name: "not_actions", @out: true, min: 0, max: 1)]
            public FSharpList<string> @NotActions { get; }
        }

        public azurerm_builtin_role_definition(string @name,
                                               FSharpList<permissions> @permissions = null)
        {
            @Name = @name;
            @Permissions = @permissions ?? FSharpList<permissions>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "assignable_scopes", @out: true, min: 0, max: 1)]
        public FSharpList<string> @AssignableScopes { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "permissions", @out: false, min: 0, max: 0)]
        public FSharpList<permissions> @Permissions { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }
    }

}
