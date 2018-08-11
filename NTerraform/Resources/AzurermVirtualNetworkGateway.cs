using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_virtual_network_gateway")]
    public sealed class azurerm_virtual_network_gateway : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "ip_configuration")]
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

            [TerraformProperty(name: "subnet_id", @out: false, nested: false, min: 1, max: 1)]
            public string @SubnetId { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "private_ip_address_allocation", @out: false, nested: false, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [TerraformProperty(name: "public_ip_address_id", @out: false, nested: false, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }
        }

        [TerraformStructure(category: "", typeName: "vpn_client_configuration")]
        public sealed class vpn_client_configuration
        {
            [TerraformStructure(category: "", typeName: "root_certificate")]
            public sealed class root_certificate
            {
                public root_certificate(string @name,
                                        string @publicCertData)
                {
                    @Name = @name;
                    @PublicCertData = @publicCertData;
                }

                [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
                public string @Name { get; }

                [TerraformProperty(name: "public_cert_data", @out: false, nested: false, min: 1, max: 1)]
                public string @PublicCertData { get; }
            }

            [TerraformStructure(category: "", typeName: "revoked_certificate")]
            public sealed class revoked_certificate
            {
                public revoked_certificate(string @name,
                                           string @thumbprint)
                {
                    @Name = @name;
                    @Thumbprint = @thumbprint;
                }

                [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
                public string @Name { get; }

                [TerraformProperty(name: "thumbprint", @out: false, nested: false, min: 1, max: 1)]
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

            [TerraformProperty(name: "address_space", @out: false, nested: false, min: 1, max: 1)]
            public string[] @AddressSpace { get; }

            [TerraformProperty(name: "radius_server_address", @out: false, nested: false, min: 0, max: 1)]
            public string @RadiusServerAddress { get; }

            [TerraformProperty(name: "radius_server_secret", @out: false, nested: false, min: 0, max: 1)]
            public string @RadiusServerSecret { get; }

            [TerraformProperty(name: "revoked_certificate", @out: false, nested: false, min: 0, max: 0)]
            public revoked_certificate[] @RevokedCertificate { get; }

            [TerraformProperty(name: "root_certificate", @out: false, nested: false, min: 0, max: 0)]
            public root_certificate[] @RootCertificate { get; }

            [TerraformProperty(name: "vpn_client_protocols", @out: false, nested: false, min: 0, max: 1)]
            public string[] @VpnClientProtocols { get; }
        }

        [TerraformStructure(category: "", typeName: "bgp_settings")]
        public sealed class bgp_settings
        {
            public bgp_settings(int? @asn = null,
                                int? @peerWeight = null)
            {
                @Asn = @asn;
                @PeerWeight = @peerWeight;
            }

            [TerraformProperty(name: "asn", @out: false, nested: false, min: 0, max: 1)]
            public int? @Asn { get; }

            [TerraformProperty(name: "peer_weight", @out: false, nested: false, min: 0, max: 1)]
            public int? @PeerWeight { get; }

            [TerraformProperty(name: "peering_address", @out: true, nested: false, min: 0, max: 1)]
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
        }

        [TerraformProperty(name: "ip_configuration", @out: false, nested: true, min: 1, max: 2)]
        public ip_configuration[] @IpConfiguration { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, nested: true, min: 1, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "type", @out: false, nested: true, min: 1, max: 1)]
        public string @Type { get; }

        [TerraformProperty(name: "active_active", @out: true, nested: true, min: 0, max: 1)]
        public bool? @ActiveActive { get; }

        [TerraformProperty(name: "bgp_settings", @out: false, nested: true, min: 0, max: 1)]
        public bgp_settings[] @BgpSettings { get; }

        [TerraformProperty(name: "default_local_network_gateway_id", @out: false, nested: true, min: 0, max: 1)]
        public string @DefaultLocalNetworkGatewayId { get; }

        [TerraformProperty(name: "enable_bgp", @out: true, nested: true, min: 0, max: 1)]
        public bool? @EnableBgp { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "vpn_client_configuration", @out: false, nested: true, min: 0, max: 1)]
        public vpn_client_configuration[] @VpnClientConfiguration { get; }

        [TerraformProperty(name: "vpn_type", @out: false, nested: true, min: 0, max: 1)]
        public string @VpnType { get; }
    }

}
