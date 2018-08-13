using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_policy_definition")]
    public sealed class azurerm_policy_definition : nterraform.resource
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

        [nterraform.TerraformProperty(name: "display_name", @out: false, min: 1, max: 1)]
        public string @DisplayName { get; }

        [nterraform.TerraformProperty(name: "mode", @out: false, min: 1, max: 1)]
        public string @Mode { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "policy_type", @out: false, min: 1, max: 1)]
        public string @PolicyType { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "metadata", @out: false, min: 0, max: 1)]
        public string @Metadata { get; }

        [nterraform.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public string @Parameters { get; }

        [nterraform.TerraformProperty(name: "policy_rule", @out: false, min: 0, max: 1)]
        public string @PolicyRule { get; }
    }

}
