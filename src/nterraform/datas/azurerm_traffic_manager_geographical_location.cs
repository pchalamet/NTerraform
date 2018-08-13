using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_traffic_manager_geographical_location")]
    public sealed class azurerm_traffic_manager_geographical_location : nterraform.data
    {
        public azurerm_traffic_manager_geographical_location(string @name)
        {
            @Name = @name;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
