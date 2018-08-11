using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_resource_group : NTerraform.data
    {
        public azurerm_resource_group(string @name)
        {
            @Name = @name;
        }

        public string @Name { get; }
        public string @Location { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
