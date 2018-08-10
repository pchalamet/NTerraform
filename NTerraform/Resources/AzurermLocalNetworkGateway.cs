using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_local_network_gateway : NTerraform.resource
    {
        public class bgp_settings
        {
            public bgp_settings(int @asn,
                                string @bgpPeeringAddress)
            {
                @Asn = @asn;
                @BgpPeeringAddress = @bgpPeeringAddress;
            }

            public int @Asn { get; }
            public string @BgpPeeringAddress { get; }
            public int? @PeerWeight { get; }
        }

        public azurerm_local_network_gateway(List<string> @addressSpace,
                                             string @gatewayAddress,
                                             string @location,
                                             string @name,
                                             string @resourceGroupName,
                                             List<bgp_settings> @bgpSettings = null)
        {
            @AddressSpace = @addressSpace;
            @GatewayAddress = @gatewayAddress;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @BgpSettings = @bgpSettings;
        }

        public List<string> @AddressSpace { get; }
        public string @GatewayAddress { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public List<bgp_settings> @BgpSettings { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
