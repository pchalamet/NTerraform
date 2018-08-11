using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_virtual_network_gateway : NTerraform.data
    {
        public sealed class ip_configuration
        {
            public ip_configuration()
            {
            }

            public string @Name { get; }
            public string @PrivateIpAddressAllocation { get; }
            public string @PublicIpAddressId { get; }
            public string @SubnetId { get; }
        }

        public sealed class vpn_client_configuration
        {
            public sealed class root_certificate
            {
                public root_certificate()
                {
                }

                public string @Name { get; }
                public string @PublicCertData { get; }
            }

            public sealed class revoked_certificate
            {
                public revoked_certificate()
                {
                }

                public string @Name { get; }
                public string @Thumbprint { get; }
            }

            public vpn_client_configuration(revoked_certificate[] @revokedCertificate = null,
                                            root_certificate[] @rootCertificate = null)
            {
                @RevokedCertificate = @revokedCertificate;
                @RootCertificate = @rootCertificate;
            }

            public string[] @AddressSpace { get; }
            public string @RadiusServerAddress { get; }
            public string @RadiusServerSecret { get; }
            public revoked_certificate[] @RevokedCertificate { get; }
            public root_certificate[] @RootCertificate { get; }
            public string[] @VpnClientProtocols { get; }
        }

        public sealed class bgp_settings
        {
            public bgp_settings()
            {
            }

            public int? @Asn { get; }
            public int? @PeerWeight { get; }
            public string @PeeringAddress { get; }
        }

        public azurerm_virtual_network_gateway(string @name,
                                               string @resourceGroupName,
                                               bgp_settings[] @bgpSettings = null,
                                               ip_configuration[] @ipConfiguration = null,
                                               vpn_client_configuration[] @vpnClientConfiguration = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @BgpSettings = @bgpSettings;
            @IpConfiguration = @ipConfiguration;
            @VpnClientConfiguration = @vpnClientConfiguration;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public bool? @ActiveActive { get; }
        public bgp_settings[] @BgpSettings { get; }
        public string @DefaultLocalNetworkGatewayId { get; }
        public bool? @EnableBgp { get; }
        public ip_configuration[] @IpConfiguration { get; }
        public string @Location { get; }
        public string @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Type { get; }
        public vpn_client_configuration[] @VpnClientConfiguration { get; }
        public string @VpnType { get; }
    }

}
