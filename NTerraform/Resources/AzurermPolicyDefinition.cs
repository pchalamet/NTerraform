using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_policy_definition")]
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
            base._validate_();
        }

        [TerraformProperty(name: "display_name", @out: false, min: 1, max: 1)]
        public string @DisplayName { get; }

        [TerraformProperty(name: "mode", @out: false, min: 1, max: 1)]
        public string @Mode { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "policy_type", @out: false, min: 1, max: 1)]
        public string @PolicyType { get; }

        [TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "metadata", @out: false, min: 0, max: 1)]
        public string @Metadata { get; }

        [TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public string @Parameters { get; }

        [TerraformProperty(name: "policy_rule", @out: false, min: 0, max: 1)]
        public string @PolicyRule { get; }
    }

}
