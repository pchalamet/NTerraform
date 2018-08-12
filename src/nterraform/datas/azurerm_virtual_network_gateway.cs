using System.Collections.Generic;

namespace nterraform.datas.azurerm
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_virtual_network_gateway")]
    public sealed class azurerm_virtual_network_gateway : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "ip_configuration")]
        public sealed class ip_configuration : nterraform.Core.structure
        {
            public ip_configuration()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address_allocation", @out: true, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [nterraform.Core.TerraformProperty(name: "public_ip_address_id", @out: true, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "vpn_client_configuration")]
        public sealed class vpn_client_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "data", typeName: "root_certificate")]
            public sealed class root_certificate : nterraform.Core.structure
            {
                public root_certificate()
                {
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "public_cert_data", @out: true, min: 0, max: 1)]
                public string @PublicCertData { get; }
            }

            [nterraform.Core.TerraformStructure(category: "data", typeName: "revoked_certificate")]
            public sealed class revoked_certificate : nterraform.Core.structure
            {
                public revoked_certificate()
                {
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "thumbprint", @out: true, min: 0, max: 1)]
                public string @Thumbprint { get; }
            }

            public vpn_client_configuration(revoked_certificate[] @revokedCertificate = null,
                                            root_certificate[] @rootCertificate = null)
            {
                @RevokedCertificate = @revokedCertificate;
                @RootCertificate = @rootCertificate;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address_space", @out: true, min: 0, max: 1)]
            public string[] @AddressSpace { get; }

            [nterraform.Core.TerraformProperty(name: "radius_server_address", @out: true, min: 0, max: 1)]
            public string @RadiusServerAddress { get; }

            [nterraform.Core.TerraformProperty(name: "radius_server_secret", @out: true, min: 0, max: 1)]
            public string @RadiusServerSecret { get; }

            [nterraform.Core.TerraformProperty(name: "revoked_certificate", @out: false, min: 0, max: 0)]
            public revoked_certificate[] @RevokedCertificate { get; }

            [nterraform.Core.TerraformProperty(name: "root_certificate", @out: false, min: 0, max: 0)]
            public root_certificate[] @RootCertificate { get; }

            [nterraform.Core.TerraformProperty(name: "vpn_client_protocols", @out: true, min: 0, max: 1)]
            public string[] @VpnClientProtocols { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "bgp_settings")]
        public sealed class bgp_settings : nterraform.Core.structure
        {
            public bgp_settings()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "asn", @out: true, min: 0, max: 1)]
            public int? @Asn { get; }

            [nterraform.Core.TerraformProperty(name: "peer_weight", @out: true, min: 0, max: 1)]
            public int? @PeerWeight { get; }

            [nterraform.Core.TerraformProperty(name: "peering_address", @out: true, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "active_active", @out: true, min: 0, max: 1)]
        public bool? @ActiveActive { get; }

        [nterraform.Core.TerraformProperty(name: "bgp_settings", @out: false, min: 0, max: 0)]
        public bgp_settings[] @BgpSettings { get; }

        [nterraform.Core.TerraformProperty(name: "default_local_network_gateway_id", @out: true, min: 0, max: 1)]
        public string @DefaultLocalNetworkGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "enable_bgp", @out: true, min: 0, max: 1)]
        public bool? @EnableBgp { get; }

        [nterraform.Core.TerraformProperty(name: "ip_configuration", @out: false, min: 0, max: 0)]
        public ip_configuration[] @IpConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_client_configuration", @out: false, min: 0, max: 0)]
        public vpn_client_configuration[] @VpnClientConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_type", @out: true, min: 0, max: 1)]
        public string @VpnType { get; }
    }

}
