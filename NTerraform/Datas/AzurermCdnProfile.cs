using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_cdn_profile : NTerraform.data
    {
        public azurerm_cdn_profile(string @name,
                                   string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Location { get; }
        public string @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
