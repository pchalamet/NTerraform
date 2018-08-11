using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_policy_definition : NTerraform.resource
    {
        public azurerm_policy_definition(string @displayName,
                                         string @mode,
                                         string @name,
                                         string @policyType,
                                         string @description = null,
                                         string @metadata = null,
                                         string @parameters = null,
                                         string @policyRule = null)
        {
            @DisplayName = @displayName;
            @Mode = @mode;
            @Name = @name;
            @PolicyType = @policyType;
            @Description = @description;
            @Metadata = @metadata;
            @Parameters = @parameters;
            @PolicyRule = @policyRule;
        }

        public string @DisplayName { get; }
        public string @Mode { get; }
        public string @Name { get; }
        public string @PolicyType { get; }
        public string @Description { get; }
        public string @Metadata { get; }
        public string @Parameters { get; }
        public string @PolicyRule { get; }
    }

}
