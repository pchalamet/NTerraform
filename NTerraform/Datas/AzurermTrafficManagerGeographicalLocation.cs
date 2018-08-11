using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_traffic_manager_geographical_location : NTerraform.data
    {
        public azurerm_traffic_manager_geographical_location(string @name)
        {
            @Name = @name;
        }

        public string @Name { get; }
    }

}
