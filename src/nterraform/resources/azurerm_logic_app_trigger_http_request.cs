using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_logic_app_trigger_http_request")]
    public sealed class azurerm_logic_app_trigger_http_request : nterraform.Core.resource
    {
        public azurerm_logic_app_trigger_http_request(string @logicAppId,
                                                      string @name,
                                                      string @schema,
                                                      FSharpOption<string> @method = null,
                                                      FSharpOption<string> @relativePath = null)
        {
            @LogicAppId = @logicAppId;
            @Name = @name;
            @Schema = @schema;
            @Method = @method;
            @RelativePath = @relativePath;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "schema", @out: false, min: 1, max: 1)]
        public string @Schema { get; }

        [nterraform.Core.TerraformProperty(name: "method", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Method { get; }

        [nterraform.Core.TerraformProperty(name: "relative_path", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @RelativePath { get; }
    }

}
