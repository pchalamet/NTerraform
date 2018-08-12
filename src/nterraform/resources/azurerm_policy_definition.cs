using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_policy_definition")]
    public sealed class azurerm_policy_definition : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "display_name", @out: false, min: 1, max: 1)]
        public string @DisplayName { get; }

        [nterraform.Core.TerraformProperty(name: "mode", @out: false, min: 1, max: 1)]
        public string @Mode { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "policy_type", @out: false, min: 1, max: 1)]
        public string @PolicyType { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "metadata", @out: false, min: 0, max: 1)]
        public string @Metadata { get; }

        [nterraform.Core.TerraformProperty(name: "parameters", @out: false, min: 0, max: 1)]
        public string @Parameters { get; }

        [nterraform.Core.TerraformProperty(name: "policy_rule", @out: false, min: 0, max: 1)]
        public string @PolicyRule { get; }
    }

}
