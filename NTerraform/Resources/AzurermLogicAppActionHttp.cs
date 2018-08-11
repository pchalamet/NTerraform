using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_logic_app_action_http : NTerraform.resource
    {
        public azurerm_logic_app_action_http(string @logicAppId,
                                             string @method,
                                             string @name,
                                             string @uri,
                                             string @body = null,
                                             Dictionary<string,string> @headers = null)
        {
            @LogicAppId = @logicAppId;
            @Method = @method;
            @Name = @name;
            @Uri = @uri;
            @Body = @body;
            @Headers = @headers;
        }

        public string @LogicAppId { get; }
        public string @Method { get; }
        public string @Name { get; }
        public string @Uri { get; }
        public string @Body { get; }
        public Dictionary<string,string> @Headers { get; }
    }

}
