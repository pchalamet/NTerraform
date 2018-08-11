using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_resource_group")]
    public sealed class azurerm_resource_group : NTerraform.data
    {
        public azurerm_resource_group(string @name)
        {
            @Name = @name;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
