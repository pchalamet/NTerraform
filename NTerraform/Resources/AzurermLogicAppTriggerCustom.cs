using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_logic_app_trigger_custom")]
    public sealed class azurerm_logic_app_trigger_custom : NTerraform.resource
    {
        public azurerm_logic_app_trigger_custom(string @body,
                                                string @logicAppId,
                                                string @name)
        {
            @Body = @body;
            @LogicAppId = @logicAppId;
            @Name = @name;
            base._validate_();
        }

        [TerraformProperty(name: "body", @out: false, min: 1, max: 1)]
        public string @Body { get; }

        [TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
