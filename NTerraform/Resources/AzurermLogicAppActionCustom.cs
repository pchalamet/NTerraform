using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_logic_app_action_custom : NTerraform.resource
    {
        public azurerm_logic_app_action_custom(string @body,
                                               string @logicAppId,
                                               string @name)
        {
            @Body = @body;
            @LogicAppId = @logicAppId;
            @Name = @name;
        }

        public string @Body { get; }
        public string @LogicAppId { get; }
        public string @Name { get; }
    }

}
