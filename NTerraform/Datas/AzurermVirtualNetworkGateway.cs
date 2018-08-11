using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_virtual_network_gateway")]
    public sealed class azurerm_virtual_network_gateway : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "vpn_client_configuration")]
        public sealed class vpn_client_configuration
        {
            [TerraformStructure(category: "", typeName: "revoked_certificate")]
            public sealed class revoked_certificate
            {
                public revoked_certificate()
                {
                }

                [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
                public string @Name { get; }

                [TerraformProperty(name: "thumbprint", @out: true, min: 0, max: 1)]
                public string @Thumbprint { get; }
            }

            [TerraformStructure(category: "", typeName: "root_certificate")]
            public sealed class root_certificate
            {
                public root_certificate()
                {
                }

                [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
                public string @Name { get; }

                [TerraformProperty(name: "public_cert_data", @out: true, min: 0, max: 1)]
                public string @PublicCertData { get; }
            }

            public vpn_client_configuration(revoked_certificate[] @revokedCertificate = null,
                                            root_certificate[] @rootCertificate = null)
            {
                @RevokedCertificate = @revokedCertificate;
                @RootCertificate = @rootCertificate;
            }

            [TerraformProperty(name: "address_space", @out: true, min: 0, max: 1)]
            public string[] @AddressSpace { get; }

            [TerraformProperty(name: "radius_server_address", @out: true, min: 0, max: 1)]
            public string @RadiusServerAddress { get; }

            [TerraformProperty(name: "radius_server_secret", @out: true, min: 0, max: 1)]
            public string @RadiusServerSecret { get; }

            [TerraformProperty(name: "revoked_certificate", @out: false, min: 0, max: 0)]
            public revoked_certificate[] @RevokedCertificate { get; }

            [TerraformProperty(name: "root_certificate", @out: false, min: 0, max: 0)]
            public root_certificate[] @RootCertificate { get; }

            [TerraformProperty(name: "vpn_client_protocols", @out: true, min: 0, max: 1)]
            public string[] @VpnClientProtocols { get; }
        }

        [TerraformStructure(category: "", typeName: "ip_configuration")]
        public sealed class ip_configuration
        {
            public ip_configuration()
            {
            }

            [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "private_ip_address_allocation", @out: true, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [TerraformProperty(name: "public_ip_address_id", @out: true, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }

            [TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        [TerraformStructure(category: "", typeName: "bgp_settings")]
        public sealed class bgp_settings
        {
            public bgp_settings()
            {
            }

            [TerraformProperty(name: "asn", @out: true, min: 0, max: 1)]
            public int? @Asn { get; }

            [TerraformProperty(name: "peer_weight", @out: true, min: 0, max: 1)]
            public int? @PeerWeight { get; }

            [TerraformProperty(name: "peering_address", @out: true, min: 0, max: 1)]
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

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "active_active", @out: true, min: 0, max: 1)]
        public bool? @ActiveActive { get; }

        [TerraformProperty(name: "bgp_settings", @out: false, min: 0, max: 0)]
        public bgp_settings[] @BgpSettings { get; }

        [TerraformProperty(name: "default_local_network_gateway_id", @out: true, min: 0, max: 1)]
        public string @DefaultLocalNetworkGatewayId { get; }

        [TerraformProperty(name: "enable_bgp", @out: true, min: 0, max: 1)]
        public bool? @EnableBgp { get; }

        [TerraformProperty(name: "ip_configuration", @out: false, min: 0, max: 0)]
        public ip_configuration[] @IpConfiguration { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }

        [TerraformProperty(name: "vpn_client_configuration", @out: false, min: 0, max: 0)]
        public vpn_client_configuration[] @VpnClientConfiguration { get; }

        [TerraformProperty(name: "vpn_type", @out: true, min: 0, max: 1)]
        public string @VpnType { get; }
    }

}
