using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_subnet")]
    public sealed class azurerm_subnet : nterraform.Core.resource
    {
        public azurerm_subnet(string @addressPrefix,
                              string @name,
                              string @resourceGroupName,
                              string @virtualNetworkName,
                              FSharpOption<string> @networkSecurityGroupId = null,
                              FSharpOption<string> @routeTableId = null,
                              FSharpOption<FSharpList<string>> @serviceEndpoints = null)
        {
            @AddressPrefix = @addressPrefix;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @VirtualNetworkName = @virtualNetworkName;
            @NetworkSecurityGroupId = @networkSecurityGroupId;
            @RouteTableId = @routeTableId;
            @ServiceEndpoints = @serviceEndpoints ?? FSharpList<string>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "address_prefix", @out: false, min: 1, max: 1)]
        public string @AddressPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "virtual_network_name", @out: false, min: 1, max: 1)]
        public string @VirtualNetworkName { get; }

        [nterraform.Core.TerraformProperty(name: "ip_configurations", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @IpConfigurations { get; }

        [nterraform.Core.TerraformProperty(name: "network_security_group_id", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @NetworkSecurityGroupId { get; }

        [nterraform.Core.TerraformProperty(name: "route_table_id", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @RouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "service_endpoints", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @ServiceEndpoints { get; }
    }

}
