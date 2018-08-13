using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpn_connection")]
    public sealed class aws_vpn_connection : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "routes")]
        public sealed class routes : nterraform.Core.structure
        {
            public routes()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "destination_cidr_block", @out: true, min: 0, max: 1)]
            public string @DestinationCidrBlock { get; }

            [nterraform.Core.TerraformProperty(name: "source", @out: true, min: 0, max: 1)]
            public string @Source { get; }

            [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
            public string @State { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "vgw_telemetry")]
        public sealed class vgw_telemetry : nterraform.Core.structure
        {
            public vgw_telemetry()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "accepted_route_count", @out: true, min: 0, max: 1)]
            public int? @AcceptedRouteCount { get; }

            [nterraform.Core.TerraformProperty(name: "last_status_change", @out: true, min: 0, max: 1)]
            public string @LastStatusChange { get; }

            [nterraform.Core.TerraformProperty(name: "outside_ip_address", @out: true, min: 0, max: 1)]
            public string @OutsideIpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
            public string @Status { get; }

            [nterraform.Core.TerraformProperty(name: "status_message", @out: true, min: 0, max: 1)]
            public string @StatusMessage { get; }
        }

        public aws_vpn_connection(string @customerGatewayId,
                                  string @type,
                                  string @vpnGatewayId,
                                  routes[] @routes = null,
                                  Dictionary<string,string> @tags = null,
                                  vgw_telemetry[] @vgwTelemetry = null)
        {
            @CustomerGatewayId = @customerGatewayId;
            @Type = @type;
            @VpnGatewayId = @vpnGatewayId;
            @Routes = @routes;
            @Tags = @tags;
            @VgwTelemetry = @vgwTelemetry;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "customer_gateway_id", @out: false, min: 1, max: 1)]
        public string @CustomerGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 1, max: 1)]
        public string @VpnGatewayId { get; }

        [nterraform.Core.TerraformProperty(name: "customer_gateway_configuration", @out: true, min: 0, max: 1)]
        public string @CustomerGatewayConfiguration { get; }

        [nterraform.Core.TerraformProperty(name: "routes", @out: false, min: 0, max: 0)]
        public routes[] @Routes { get; }

        [nterraform.Core.TerraformProperty(name: "static_routes_only", @out: true, min: 0, max: 1)]
        public bool? @StaticRoutesOnly { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel1_address", @out: true, min: 0, max: 1)]
        public string @Tunnel1Address { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel1_bgp_asn", @out: true, min: 0, max: 1)]
        public string @Tunnel1BgpAsn { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel1_bgp_holdtime", @out: true, min: 0, max: 1)]
        public int? @Tunnel1BgpHoldtime { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel1_cgw_inside_address", @out: true, min: 0, max: 1)]
        public string @Tunnel1CgwInsideAddress { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel1_inside_cidr", @out: true, min: 0, max: 1)]
        public string @Tunnel1InsideCidr { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel1_preshared_key", @out: true, min: 0, max: 1)]
        public string @Tunnel1PresharedKey { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel1_vgw_inside_address", @out: true, min: 0, max: 1)]
        public string @Tunnel1VgwInsideAddress { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel2_address", @out: true, min: 0, max: 1)]
        public string @Tunnel2Address { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel2_bgp_asn", @out: true, min: 0, max: 1)]
        public string @Tunnel2BgpAsn { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel2_bgp_holdtime", @out: true, min: 0, max: 1)]
        public int? @Tunnel2BgpHoldtime { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel2_cgw_inside_address", @out: true, min: 0, max: 1)]
        public string @Tunnel2CgwInsideAddress { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel2_inside_cidr", @out: true, min: 0, max: 1)]
        public string @Tunnel2InsideCidr { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel2_preshared_key", @out: true, min: 0, max: 1)]
        public string @Tunnel2PresharedKey { get; }

        [nterraform.Core.TerraformProperty(name: "tunnel2_vgw_inside_address", @out: true, min: 0, max: 1)]
        public string @Tunnel2VgwInsideAddress { get; }

        [nterraform.Core.TerraformProperty(name: "vgw_telemetry", @out: false, min: 0, max: 0)]
        public vgw_telemetry[] @VgwTelemetry { get; }
    }

}
