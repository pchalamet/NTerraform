using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_express_route_circuit_authorization")]
    public sealed class azurerm_express_route_circuit_authorization : nterraform.Core.resource
    {
        public azurerm_express_route_circuit_authorization(string @expressRouteCircuitName,
                                                           string @name,
                                                           string @resourceGroupName)
        {
            @ExpressRouteCircuitName = @expressRouteCircuitName;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "express_route_circuit_name", @out: false, min: 1, max: 1)]
        public string @ExpressRouteCircuitName { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "authorization_key", @out: true, min: 0, max: 1)]
        public string @AuthorizationKey { get; }

        [nterraform.Core.TerraformProperty(name: "authorization_use_status", @out: true, min: 0, max: 1)]
        public string @AuthorizationUseStatus { get; }
    }

}
