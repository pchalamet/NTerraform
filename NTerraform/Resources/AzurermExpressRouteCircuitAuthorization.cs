using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_express_route_circuit_authorization")]
    public sealed class azurerm_express_route_circuit_authorization : NTerraform.resource
    {
        public azurerm_express_route_circuit_authorization(string @expressRouteCircuitName,
                                                           string @name,
                                                           string @resourceGroupName)
        {
            @ExpressRouteCircuitName = @expressRouteCircuitName;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "express_route_circuit_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ExpressRouteCircuitName { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "authorization_key", @out: true, nested: true, min: 0, max: 1)]
        public string @AuthorizationKey { get; }

        [TerraformProperty(name: "authorization_use_status", @out: true, nested: true, min: 0, max: 1)]
        public string @AuthorizationUseStatus { get; }
    }

}
