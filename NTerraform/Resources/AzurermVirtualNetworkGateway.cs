using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_virtual_network_gateway : NTerraform.resource
    {
        public sealed class ip_configuration
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

        public sealed class bgp_settings
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

        public sealed class vpn_client_configuration
        {
            public sealed class root_certificate
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

            public sealed class revoked_certificate
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

            public vpn_client_configuration(string[] @addressSpace,
                                            string @radiusServerAddress = null,
                                            string @radiusServerSecret = null,
                                            revoked_certificate[] @revokedCertificate = null,
                                            root_certificate[] @rootCertificate = null,
                                            string[] @vpnClientProtocols = null)
            {
                @AddressSpace = @addressSpace;
                @RadiusServerAddress = @radiusServerAddress;
                @RadiusServerSecret = @radiusServerSecret;
                @RevokedCertificate = @revokedCertificate;
                @RootCertificate = @rootCertificate;
                @VpnClientProtocols = @vpnClientProtocols;
            }

            public string[] @AddressSpace { get; }
            public string @RadiusServerAddress { get; }
            public string @RadiusServerSecret { get; }
            public revoked_certificate[] @RevokedCertificate { get; }
            public root_certificate[] @RootCertificate { get; }
            public string[] @VpnClientProtocols { get; }
        }

        public azurerm_virtual_network_gateway(ip_configuration[] @ipConfiguration,
                                               string @location,
                                               string @name,
                                               string @resourceGroupName,
                                               string @sku,
                                               string @type,
                                               bgp_settings[] @bgpSettings = null,
                                               string @defaultLocalNetworkGatewayId = null,
                                               vpn_client_configuration[] @vpnClientConfiguration = null,
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

        public ip_configuration[] @IpConfiguration { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Sku { get; }
        public string @Type { get; }
        public bool? @ActiveActive { get; }
        public bgp_settings[] @BgpSettings { get; }
        public string @DefaultLocalNetworkGatewayId { get; }
        public bool? @EnableBgp { get; }
        public Dictionary<string,string> @Tags { get; }
        public vpn_client_configuration[] @VpnClientConfiguration { get; }
        public string @VpnType { get; }
    }

}
