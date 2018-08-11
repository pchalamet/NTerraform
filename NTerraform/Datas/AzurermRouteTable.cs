using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_route_table : NTerraform.data
    {
        public class route
        {
            public route()
            {
            }

            public string @AddressPrefix { get; }
            public string @Name { get; }
            public string @NextHopInIpAddress { get; }
            public string @NextHopType { get; }
        }

        public azurerm_route_table(string @name,
                                   string @resourceGroupName,
                                   route[] @route = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Route = @route;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Location { get; }
        public route[] @Route { get; }
        public string[] @Subnets { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
