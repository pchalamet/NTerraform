using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_traffic_manager_geographical_location")]
    public sealed class azurerm_traffic_manager_geographical_location : NTerraform.data
    {
        public azurerm_traffic_manager_geographical_location(string @name)
        {
            @Name = @name;
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
