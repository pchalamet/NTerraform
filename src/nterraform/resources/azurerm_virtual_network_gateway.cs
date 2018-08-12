using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_virtual_network_gateway")]
    public sealed class azurerm_virtual_network_gateway : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "vpn_client_configuration")]
        public sealed class vpn_client_configuration : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "root_certificate")]
            public sealed class root_certificate : nterraform.Core.structure
            {
                public root_certificate(string @name,
                                        string @publicCertData)
                {
                    @Name = @name;
                    @PublicCertData = @publicCertData;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "public_cert_data", @out: false, min: 1, max: 1)]
                public string @PublicCertData { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "revoked_certificate")]
            public sealed class revoked_certificate : nterraform.Core.structure
            {
                public revoked_certificate(string @name,
                                           string @thumbprint)
                {
                    @Name = @name;
                    @Thumbprint = @thumbprint;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "thumbprint", @out: false, min: 1, max: 1)]
                public string @Thumbprint { get; }
            }

            public vpn_client_configuration(FSharpList<string> @addressSpace,
                                            string @radiusServerAddress = null,
                                            string @radiusServerSecret = null,
                                            FSharpList<revoked_certificate> @revokedCertificate = null,
                                            FSharpList<root_certificate> @rootCertificate = null,
                                            FSharpList<string> @vpnClientProtocols = null)
            {
                @AddressSpace = @addressSpace;
                @RadiusServerAddress = @radiusServerAddress;
                @RadiusServerSecret = @radiusServerSecret;
                @RevokedCertificate = @revokedCertificate ?? FSharpList<revoked_certificate>.Empty;
                @RootCertificate = @rootCertificate ?? FSharpList<root_certificate>.Empty;
                @VpnClientProtocols = @vpnClientProtocols ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "address_space", @out: false, min: 1, max: 1)]
            public FSharpList<string> @AddressSpace { get; }

            [nterraform.Core.TerraformProperty(name: "radius_server_address", @out: false, min: 0, max: 1)]
            public string @RadiusServerAddress { get; }

            [nterraform.Core.TerraformProperty(name: "radius_server_secret", @out: false, min: 0, max: 1)]
            public string @RadiusServerSecret { get; }

            [nterraform.Core.TerraformProperty(name: "revoked_certificate", @out: false, min: 0, max: 0)]
            public FSharpList<revoked_certificate> @RevokedCertificate { get; }

            [nterraform.Core.TerraformProperty(name: "root_certificate", @out: false, min: 0, max: 0)]
            public FSharpList<root_certificate> @RootCertificate { get; }

            [nterraform.Core.TerraformProperty(name: "vpn_client_protocols", @out: false, min: 0, max: 1)]
            public FSharpList<string> @VpnClientProtocols { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "ip_configuration")]
        public sealed class ip_configuration : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
            public string @SubnetId { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "private_ip_address_allocation", @out: false, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [nterraform.Core.TerraformProperty(name: "public_ip_address_id", @out: false, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "bgp_settings")]
        public sealed class bgp_settings : nterraform.Core.structure
        {
            public bgp_settings(int? @asn = null,
                                int? @peerWeight = null)
            {
                @Asn = @asn;
                @PeerWeight = @peerWeight;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "asn", @out: false, min: 0, max: 1)]
            public int? @Asn { get; }

            [nterraform.Core.TerraformProperty(name: "peer_weight", @out: false, min: 0, max: 1)]
            public int? @PeerWeight { get; }

            [nterraform.Core.TerraformProperty(name: "peering_address", @out: true, min: 0, max: 1)]
            public string @PeeringAddress { get; }
        }

        public azurerm_virtual_network_gateway(FSharpList<ip_configuration> @ipConfiguration,
                                               string @location,
                                               string @name,
                                               string @resourceGroupName,
                                               string @sku,
                                               string @type,
                                               FSharpList<bgp_settings> @bgpSettings = null,
                                               string @defaultLocalNetworkGatewayId = null,
                                               FSharpList<vpn_client_configuration> @vpnClientConfiguration = null,
                                               string @vpnType = null)
        {
            @IpConfiguration = @ipConfiguration;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Type = @type;
            @BgpSettings = @bgpSettings ?? FSharpList<bgp_settings>.Empty;
            @DefaultLocalNetworkGatewayId = @defaultLocalNetworkGatewayId;
            @VpnClientConfiguration = @vpnClientConfiguration ?? FSharpList<vpn_client_configuration>.Empty;
            @VpnType = @vpnType;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "ip_configuration", @out: false, min: 1, max: 2)]
        public FSharpList<ip_configuration> @IpConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "active_active", @out: true, min: 0, max: 1)]
        public bool? @ActiveActive { get; }

        [nterraform.Core.TerraformProperty(name: "bgp_settings", @out: false, min: 0, max: 1)]
        public FSharpList<bgp_settings> @BgpSettings { get; }

        [nterraform.Core.TerraformProperty(name: "default_local_network_gateway_id", @out: false, min: 0, max: 1)]
        public string @DefaultLocalNetworkGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "enable_bgp", @out: true, min: 0, max: 1)]
        public bool? @EnableBgp { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_client_configuration", @out: false, min: 0, max: 1)]
        public FSharpList<vpn_client_configuration> @VpnClientConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_type", @out: false, min: 0, max: 1)]
        public string @VpnType { get; }
    }

}
