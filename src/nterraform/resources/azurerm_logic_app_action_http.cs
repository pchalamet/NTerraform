using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_logic_app_action_http")]
    public sealed class azurerm_logic_app_action_http : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [nterraform.Core.TerraformProperty(name: "method", @out: false, min: 1, max: 1)]
        public string @Method { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "uri", @out: false, min: 1, max: 1)]
        public string @Uri { get; }

        [nterraform.Core.TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
        public string @Body { get; }

        [nterraform.Core.TerraformProperty(name: "headers", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Headers { get; }
    }

}
