using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_role_definition")]
    public sealed class azurerm_role_definition : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "permissions")]
        public sealed class permissions : nterraform.Core.structure
        {
            public permissions()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "actions", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @Actions { get; }

            [nterraform.Core.TerraformProperty(name: "not_actions", @out: true, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @NotActions { get; }
        }

        public azurerm_role_definition(string @roleDefinitionId,
                                       string @scope,
                                       FSharpOption<FSharpList<permissions>> @permissions = null)
        {
            @RoleDefinitionId = @roleDefinitionId;
            @Scope = @scope;
            @Permissions = @permissions ?? FSharpList<permissions>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "role_definition_id", @out: false, min: 1, max: 1)]
        public string @RoleDefinitionId { get; }

        [nterraform.Core.TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
        public string @Scope { get; }

        [nterraform.Core.TerraformProperty(name: "assignable_scopes", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @AssignableScopes { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Description { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Name { get; }

        [nterraform.Core.TerraformProperty(name: "permissions", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<permissions>> @Permissions { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Type { get; }
    }

}
