using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_logic_app_trigger_http_request : NTerraform.resource
    {
        public azurerm_logic_app_trigger_http_request(string @logicAppId,
                                                      string @name,
                                                      string @schema,
                                                      string @method = null,
                                                      string @relativePath = null)
        {
            @LogicAppId = @logicAppId;
            @Name = @name;
            @Schema = @schema;
            @Method = @method;
            @RelativePath = @relativePath;
        }

        public string @LogicAppId { get; }
        public string @Name { get; }
        public string @Schema { get; }
        public string @Method { get; }
        public string @RelativePath { get; }
    }

}
