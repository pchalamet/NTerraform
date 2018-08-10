using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_express_route_circuit_authorization : NTerraform.resource
    {
        public azurerm_express_route_circuit_authorization(string @expressRouteCircuitName,
                                                           string @name,
                                                           string @resourceGroupName)
        {
            @ExpressRouteCircuitName = @expressRouteCircuitName;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @ExpressRouteCircuitName { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @AuthorizationKey { get; }
        public string @AuthorizationUseStatus { get; }
    }

}
