using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_local_network_gateway : NTerraform.resource
    {
        public sealed class bgp_settings
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

        public azurerm_local_network_gateway(string[] @addressSpace,
                                             string @gatewayAddress,
                                             string @location,
                                             string @name,
                                             string @resourceGroupName,
                                             bgp_settings[] @bgpSettings = null)
        {
            @AddressSpace = @addressSpace;
            @GatewayAddress = @gatewayAddress;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @BgpSettings = @bgpSettings;
        }

        public string[] @AddressSpace { get; }
        public string @GatewayAddress { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public bgp_settings[] @BgpSettings { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
