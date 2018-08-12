using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_policy_assignment")]
    public sealed class azurerm_policy_assignment : nterraform.Core.resource
    {
        public azurerm_policy_assignment(string @name,
                                         string @policyDefinitionId,
                                         string @scope,
                                         FSharpOption<string> @description = null,
                                         FSharpOption<string> @displayName = null,
                                         FSharpOption<string> @parameters = null)
        {
            @Name = @name;
            @PolicyDefinitionId = @policyDefinitionId;
            @Scope = @scope;
            @Description = @description;
            @DisplayName = @displayName;
            @Parameters = @parameters;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "policy_definition_id", @out: false, min: 1, max: 1)]
        public string @PolicyDefinitionId { get; }

        [nterraform.Core.TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
        public string @Scope { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Description { get; }

        [nterraform.Core.TerraformProperty(name: "display_name", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @DisplayName { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Parameters { get; }
    }

}
