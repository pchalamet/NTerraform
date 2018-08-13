using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_virtual_network_gateway")]
    public sealed class azurerm_virtual_network_gateway : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "ip_configuration")]
        public sealed class ip_configuration : nterraform.structure
        {
            public ip_configuration()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "private_ip_address_allocation", @out: true, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [nterraform.TerraformProperty(name: "public_ip_address_id", @out: true, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }

            [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "bgp_settings")]
        public sealed class bgp_settings : nterraform.structure
        {
            public bgp_settings()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "asn", @out: true, min: 0, max: 1)]
            public int? @Asn { get; }

            [nterraform.TerraformProperty(name: "peer_weight", @out: true, min: 0, max: 1)]
            public int? @PeerWeight { get; }

            [nterraform.TerraformProperty(name: "peering_address", @out: true, min: 0, max: 1)]
            public string @PeeringAddress { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "vpn_client_configuration")]
        public sealed class vpn_client_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "data", typeName: "root_certificate")]
            public sealed class root_certificate : nterraform.structure
            {
                public root_certificate()
                {
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "public_cert_data", @out: true, min: 0, max: 1)]
                public string @PublicCertData { get; }
            }

            [nterraform.TerraformStructure(category: "data", typeName: "revoked_certificate")]
            public sealed class revoked_certificate : nterraform.structure
            {
                public revoked_certificate()
                {
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "thumbprint", @out: true, min: 0, max: 1)]
                public string @Thumbprint { get; }
            }

            public vpn_client_configuration(revoked_certificate[] @revokedCertificate = null,
                                            root_certificate[] @rootCertificate = null)
            {
                @RevokedCertificate = @revokedCertificate;
                @RootCertificate = @rootCertificate;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "address_space", @out: true, min: 0, max: 1)]
            public string[] @AddressSpace { get; }

            [nterraform.TerraformProperty(name: "radius_server_address", @out: true, min: 0, max: 1)]
            public string @RadiusServerAddress { get; }

            [nterraform.TerraformProperty(name: "radius_server_secret", @out: true, min: 0, max: 1)]
            public string @RadiusServerSecret { get; }

            [nterraform.TerraformProperty(name: "revoked_certificate", @out: false, min: 0, max: 0)]
            public revoked_certificate[] @RevokedCertificate { get; }

            [nterraform.TerraformProperty(name: "root_certificate", @out: false, min: 0, max: 0)]
            public root_certificate[] @RootCertificate { get; }

            [nterraform.TerraformProperty(name: "vpn_client_protocols", @out: true, min: 0, max: 1)]
            public string[] @VpnClientProtocols { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "active_active", @out: true, min: 0, max: 1)]
        public bool? @ActiveActive { get; }

        [nterraform.TerraformProperty(name: "bgp_settings", @out: false, min: 0, max: 0)]
        public bgp_settings[] @BgpSettings { get; }

        [nterraform.TerraformProperty(name: "default_local_network_gateway_id", @out: true, min: 0, max: 1)]
        public string @DefaultLocalNetworkGatewayId { get; }

        [nterraform.TerraformProperty(name: "enable_bgp", @out: true, min: 0, max: 1)]
        public bool? @EnableBgp { get; }

        [nterraform.TerraformProperty(name: "ip_configuration", @out: false, min: 0, max: 0)]
        public ip_configuration[] @IpConfiguration { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "vpn_client_configuration", @out: false, min: 0, max: 0)]
        public vpn_client_configuration[] @VpnClientConfiguration { get; }

        [nterraform.TerraformProperty(name: "vpn_type", @out: true, min: 0, max: 1)]
        public string @VpnType { get; }
    }

}
