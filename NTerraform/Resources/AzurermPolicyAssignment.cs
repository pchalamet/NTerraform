using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_policy_assignment")]
    public sealed class azurerm_policy_assignment : NTerraform.resource
    {
        public azurerm_policy_assignment(string @name,
                                         string @policyDefinitionId,
                                         string @scope,
                                         string @description = null,
                                         string @displayName = null,
                                         string @parameters = null)
        {
            @Name = @name;
            @PolicyDefinitionId = @policyDefinitionId;
            @Scope = @scope;
            @Description = @description;
            @DisplayName = @displayName;
            @Parameters = @parameters;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "policy_definition_id", @out: false, min: 1, max: 1)]
        public string @PolicyDefinitionId { get; }

        [TerraformProperty(name: "scope", @out: false, min: 1, max: 1)]
        public string @Scope { get; }

        [TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "display_name", @out: false, min: 0, max: 1)]
        public string @DisplayName { get; }

        [TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public string @Parameters { get; }
    }

}
