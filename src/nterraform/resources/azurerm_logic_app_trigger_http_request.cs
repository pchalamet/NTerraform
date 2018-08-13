using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_logic_app_trigger_http_request")]
    public sealed class azurerm_logic_app_trigger_http_request : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "schema", @out: false, min: 1, max: 1)]
        public string @Schema { get; }

        [nterraform.TerraformProperty(name: "method", @out: false, min: 0, max: 1)]
        public string @Method { get; }

        [nterraform.TerraformProperty(name: "relative_path", @out: false, min: 0, max: 1)]
        public string @RelativePath { get; }
    }

}
