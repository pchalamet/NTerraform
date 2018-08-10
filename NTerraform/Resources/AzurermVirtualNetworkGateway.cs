using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_virtual_network_gateway : NTerraform.resource
    {
        public class bgp_settings
        {
            public bgp_settings(int? @asn = null,
                                int? @peerWeight = null)
            {
                @Asn = @asn;
                @PeerWeight = @peerWeight;
            }

            public int? @Asn { get; }
            public int? @PeerWeight { get; }
            public string @PeeringAddress { get; }
        }

        public class ip_configuration
        {
            public ip_configuration(string @subnetId,
                                    string @name = null,
                                    string @privateIpAddressAllocation = null,
                                    string @publicIpAddressId = null)
            {
                @SubnetId = @subnetId;
                @Name = @name;
                @PrivateIpAddressAllocation = @privateIpAddressAllocation;
                @PublicIpAddressId = @publicIpAddressId;
            }

            public string @SubnetId { get; }
            public string @Name { get; }
            public string @PrivateIpAddressAllocation { get; }
            public string @PublicIpAddressId { get; }
        }

        public class vpn_client_configuration
        {
            public class root_certificate
            {
                public root_certificate(string @name,
                                        string @publicCertData)
                {
                    @Name = @name;
                    @PublicCertData = @publicCertData;
                }

                public string @Name { get; }
                public string @PublicCertData { get; }
            }

            public class revoked_certificate
            {
                public revoked_certificate(string @name,
                                           string @thumbprint)
                {
                    @Name = @name;
                    @Thumbprint = @thumbprint;
                }

                public string @Name { get; }
                public string @Thumbprint { get; }
            }

            public vpn_client_configuration(List<string> @addressSpace,
                                            string @radiusServerAddress = null,
                                            string @radiusServerSecret = null,
                                            HashSet<revoked_certificate> @revokedCertificate = null,
                                            HashSet<root_certificate> @rootCertificate = null,
                                            HashSet<string> @vpnClientProtocols = null)
            {
                @AddressSpace = @addressSpace;
                @RadiusServerAddress = @radiusServerAddress;
                @RadiusServerSecret = @radiusServerSecret;
                @RevokedCertificate = @revokedCertificate;
                @RootCertificate = @rootCertificate;
                @VpnClientProtocols = @vpnClientProtocols;
            }

            public List<string> @AddressSpace { get; }
            public string @RadiusServerAddress { get; }
            public string @RadiusServerSecret { get; }
            public HashSet<revoked_certificate> @RevokedCertificate { get; }
            public HashSet<root_certificate> @RootCertificate { get; }
            public HashSet<string> @VpnClientProtocols { get; }
        }

        public azurerm_virtual_network_gateway(List<ip_configuration> @ipConfiguration,
                                               string @location,
                                               string @name,
                                               string @resourceGroupName,
                                               string @sku,
                                               string @type,
                                               List<bgp_settings> @bgpSettings = null,
                                               string @defaultLocalNetworkGatewayId = null,
                                               List<vpn_client_configuration> @vpnClientConfiguration = null,
                                               string @vpnType = null)
        {
            @IpConfiguration = @ipConfiguration;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Type = @type;
            @BgpSettings = @bgpSettings;
            @DefaultLocalNetworkGatewayId = @defaultLocalNetworkGatewayId;
            @VpnClientConfiguration = @vpnClientConfiguration;
            @VpnType = @vpnType;
        }

        public List<ip_configuration> @IpConfiguration { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Sku { get; }
        public string @Type { get; }
        public bool? @ActiveActive { get; }
        public List<bgp_settings> @BgpSettings { get; }
        public string @DefaultLocalNetworkGatewayId { get; }
        public bool? @EnableBgp { get; }
        public Dictionary<string,string> @Tags { get; }
        public List<vpn_client_configuration> @VpnClientConfiguration { get; }
        public string @VpnType { get; }
    }

}
