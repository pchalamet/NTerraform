using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpn_connection")]
    public sealed class aws_vpn_connection : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "vgw_telemetry")]
        public sealed class vgw_telemetry : nterraform.structure
        {
            public vgw_telemetry()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "accepted_route_count", @out: true, min: 0, max: 1)]
            public int? @AcceptedRouteCount { get; }

            [nterraform.TerraformProperty(name: "last_status_change", @out: true, min: 0, max: 1)]
            public string @LastStatusChange { get; }

            [nterraform.TerraformProperty(name: "outside_ip_address", @out: true, min: 0, max: 1)]
            public string @OutsideIpAddress { get; }

            [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
            public string @Status { get; }

            [nterraform.TerraformProperty(name: "status_message", @out: true, min: 0, max: 1)]
            public string @StatusMessage { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "routes")]
        public sealed class routes : nterraform.structure
        {
            public routes()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "destination_cidr_block", @out: true, min: 0, max: 1)]
            public string @DestinationCidrBlock { get; }

            [nterraform.TerraformProperty(name: "source", @out: true, min: 0, max: 1)]
            public string @Source { get; }

            [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
            public string @State { get; }
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

        [nterraform.TerraformProperty(name: "customer_gateway_id", @out: false, min: 1, max: 1)]
        public string @CustomerGatewayId { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "vpn_gateway_id", @out: false, min: 1, max: 1)]
        public string @VpnGatewayId { get; }

        [nterraform.TerraformProperty(name: "customer_gateway_configuration", @out: true, min: 0, max: 1)]
        public string @CustomerGatewayConfiguration { get; }

        [nterraform.TerraformProperty(name: "routes", @out: false, min: 0, max: 0)]
        public routes[] @Routes { get; }

        [nterraform.TerraformProperty(name: "static_routes_only", @out: true, min: 0, max: 1)]
        public bool? @StaticRoutesOnly { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "tunnel1_address", @out: true, min: 0, max: 1)]
        public string @Tunnel1Address { get; }

        [nterraform.TerraformProperty(name: "tunnel1_bgp_asn", @out: true, min: 0, max: 1)]
        public string @Tunnel1BgpAsn { get; }

        [nterraform.TerraformProperty(name: "tunnel1_bgp_holdtime", @out: true, min: 0, max: 1)]
        public int? @Tunnel1BgpHoldtime { get; }

        [nterraform.TerraformProperty(name: "tunnel1_cgw_inside_address", @out: true, min: 0, max: 1)]
        public string @Tunnel1CgwInsideAddress { get; }

        [nterraform.TerraformProperty(name: "tunnel1_inside_cidr", @out: true, min: 0, max: 1)]
        public string @Tunnel1InsideCidr { get; }

        [nterraform.TerraformProperty(name: "tunnel1_preshared_key", @out: true, min: 0, max: 1)]
        public string @Tunnel1PresharedKey { get; }

        [nterraform.TerraformProperty(name: "tunnel1_vgw_inside_address", @out: true, min: 0, max: 1)]
        public string @Tunnel1VgwInsideAddress { get; }

        [nterraform.TerraformProperty(name: "tunnel2_address", @out: true, min: 0, max: 1)]
        public string @Tunnel2Address { get; }

        [nterraform.TerraformProperty(name: "tunnel2_bgp_asn", @out: true, min: 0, max: 1)]
        public string @Tunnel2BgpAsn { get; }

        [nterraform.TerraformProperty(name: "tunnel2_bgp_holdtime", @out: true, min: 0, max: 1)]
        public int? @Tunnel2BgpHoldtime { get; }

        [nterraform.TerraformProperty(name: "tunnel2_cgw_inside_address", @out: true, min: 0, max: 1)]
        public string @Tunnel2CgwInsideAddress { get; }

        [nterraform.TerraformProperty(name: "tunnel2_inside_cidr", @out: true, min: 0, max: 1)]
        public string @Tunnel2InsideCidr { get; }

        [nterraform.TerraformProperty(name: "tunnel2_preshared_key", @out: true, min: 0, max: 1)]
        public string @Tunnel2PresharedKey { get; }

        [nterraform.TerraformProperty(name: "tunnel2_vgw_inside_address", @out: true, min: 0, max: 1)]
        public string @Tunnel2VgwInsideAddress { get; }

        [nterraform.TerraformProperty(name: "vgw_telemetry", @out: false, min: 0, max: 0)]
        public vgw_telemetry[] @VgwTelemetry { get; }
    }

}
