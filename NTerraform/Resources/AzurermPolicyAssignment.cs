using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_policy_assignment : NTerraform.resource
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

        public string @Name { get; }
        public string @PolicyDefinitionId { get; }
        public string @Scope { get; }
        public string @Description { get; }
        public string @DisplayName { get; }
        public string @Parameters { get; }
    }

}
