using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_logic_app_trigger_custom")]
    public sealed class azurerm_logic_app_trigger_custom : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "body", @out: false, min: 1, max: 1)]
        public string @Body { get; }

        [nterraform.Core.TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
