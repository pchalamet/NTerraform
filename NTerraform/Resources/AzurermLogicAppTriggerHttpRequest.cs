using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_logic_app_trigger_http_request")]
    public sealed class azurerm_logic_app_trigger_http_request : NTerraform.resource
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

        [TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "schema", @out: false, min: 1, max: 1)]
        public string @Schema { get; }

        [TerraformProperty(name: "method", @out: false, min: 0, max: 1)]
        public string @Method { get; }

        [TerraformProperty(name: "relative_path", @out: false, min: 0, max: 1)]
        public string @RelativePath { get; }
    }

}
