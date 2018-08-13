using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_logic_app_action_http")]
    public sealed class azurerm_logic_app_action_http : nterraform.resource
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

        [nterraform.TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [nterraform.TerraformProperty(name: "method", @out: false, min: 1, max: 1)]
        public string @Method { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "uri", @out: false, min: 1, max: 1)]
        public string @Uri { get; }

        [nterraform.TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
        public string @Body { get; }

        [nterraform.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Headers { get; }
    }

}
