using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_resource_group")]
    public sealed class azurerm_resource_group : nterraform.resource
    {
        public azurerm_resource_group(string @location,
                                      string @name)
        {
            @Location = @location;
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
