using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_logic_app_action_http")]
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
            base._validate_();
        }

        [TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [TerraformProperty(name: "method", @out: false, min: 1, max: 1)]
        public string @Method { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "uri", @out: false, min: 1, max: 1)]
        public string @Uri { get; }

        [TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
        public string @Body { get; }

        [TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Headers { get; }
    }

}
