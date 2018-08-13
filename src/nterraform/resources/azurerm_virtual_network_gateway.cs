using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_virtual_network_gateway")]
    public sealed class azurerm_virtual_network_gateway : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "vpn_client_configuration")]
        public sealed class vpn_client_configuration : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "root_certificate")]
            public sealed class root_certificate : nterraform.structure
            {
                public root_certificate(string @name,
                                        string @publicCertData)
                {
                    @Name = @name;
                    @PublicCertData = @publicCertData;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "public_cert_data", @out: false, min: 1, max: 1)]
                public string @PublicCertData { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "revoked_certificate")]
            public sealed class revoked_certificate : nterraform.structure
            {
                public revoked_certificate(string @name,
                                           string @thumbprint)
                {
                    @Name = @name;
                    @Thumbprint = @thumbprint;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "thumbprint", @out: false, min: 1, max: 1)]
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "address_space", @out: false, min: 1, max: 1)]
            public string[] @AddressSpace { get; }

            [nterraform.TerraformProperty(name: "radius_server_address", @out: false, min: 0, max: 1)]
            public string @RadiusServerAddress { get; }

            [nterraform.TerraformProperty(name: "radius_server_secret", @out: false, min: 0, max: 1)]
            public string @RadiusServerSecret { get; }

            [nterraform.TerraformProperty(name: "revoked_certificate", @out: false, min: 0, max: 0)]
            public revoked_certificate[] @RevokedCertificate { get; }

            [nterraform.TerraformProperty(name: "root_certificate", @out: false, min: 0, max: 0)]
            public root_certificate[] @RootCertificate { get; }

            [nterraform.TerraformProperty(name: "vpn_client_protocols", @out: false, min: 0, max: 1)]
            public string[] @VpnClientProtocols { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ip_configuration")]
        public sealed class ip_configuration : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
            public string @SubnetId { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "private_ip_address_allocation", @out: false, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [nterraform.TerraformProperty(name: "public_ip_address_id", @out: false, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "bgp_settings")]
        public sealed class bgp_settings : nterraform.structure
        {
            public bgp_settings(int? @asn = null,
                                int? @peerWeight = null)
            {
                @Asn = @asn;
                @PeerWeight = @peerWeight;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "asn", @out: false, min: 0, max: 1)]
            public int? @Asn { get; }

            [nterraform.TerraformProperty(name: "peer_weight", @out: false, min: 0, max: 1)]
            public int? @PeerWeight { get; }

            [nterraform.TerraformProperty(name: "peering_address", @out: true, min: 0, max: 1)]
            public string @PeeringAddress { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "ip_configuration", @out: false, min: 1, max: 2)]
        public ip_configuration[] @IpConfiguration { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "active_active", @out: true, min: 0, max: 1)]
        public bool? @ActiveActive { get; }

        [nterraform.TerraformProperty(name: "bgp_settings", @out: false, min: 0, max: 1)]
        public bgp_settings[] @BgpSettings { get; }

        [nterraform.TerraformProperty(name: "default_local_network_gateway_id", @out: false, min: 0, max: 1)]
        public string @DefaultLocalNetworkGatewayId { get; }

        [nterraform.TerraformProperty(name: "enable_bgp", @out: true, min: 0, max: 1)]
        public bool? @EnableBgp { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpn_client_configuration", @out: false, min: 0, max: 1)]
        public vpn_client_configuration[] @VpnClientConfiguration { get; }

        [nterraform.TerraformProperty(name: "vpn_type", @out: false, min: 0, max: 1)]
        public string @VpnType { get; }
    }

}
