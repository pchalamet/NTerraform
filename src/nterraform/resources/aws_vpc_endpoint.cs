using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc_endpoint")]
    public sealed class aws_vpc_endpoint : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "dns_entry")]
        public sealed class dns_entry : nterraform.structure
        {
            public dns_entry()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
            public string @DnsName { get; }

            [nterraform.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
            public string @HostedZoneId { get; }
        }

        public aws_vpc_endpoint(string @serviceName,
                                string @vpcId,
                                bool? @autoAccept = null,
                                dns_entry[] @dnsEntry = null,
                                bool? @privateDnsEnabled = null,
                                string @vpcEndpointType = null)
        {
            @ServiceName = @serviceName;
            @VpcId = @vpcId;
            @AutoAccept = @autoAccept;
            @DnsEntry = @dnsEntry;
            @PrivateDnsEnabled = @privateDnsEnabled;
            @VpcEndpointType = @vpcEndpointType;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "service_name", @out: false, min: 1, max: 1)]
        public string @ServiceName { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.TerraformProperty(name: "auto_accept", @out: false, min: 0, max: 1)]
        public bool? @AutoAccept { get; }

        [nterraform.TerraformProperty(name: "cidr_blocks", @out: true, min: 0, max: 1)]
        public string[] @CidrBlocks { get; }

        [nterraform.TerraformProperty(name: "dns_entry", @out: false, min: 0, max: 0)]
        public dns_entry[] @DnsEntry { get; }

        [nterraform.TerraformProperty(name: "network_interface_ids", @out: true, min: 0, max: 1)]
        public string[] @NetworkInterfaceIds { get; }

        [nterraform.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.TerraformProperty(name: "prefix_list_id", @out: true, min: 0, max: 1)]
        public string @PrefixListId { get; }

        [nterraform.TerraformProperty(name: "private_dns_enabled", @out: false, min: 0, max: 1)]
        public bool? @PrivateDnsEnabled { get; }

        [nterraform.TerraformProperty(name: "route_table_ids", @out: true, min: 0, max: 1)]
        public string[] @RouteTableIds { get; }

        [nterraform.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupIds { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
        public string[] @SubnetIds { get; }

        [nterraform.TerraformProperty(name: "vpc_endpoint_type", @out: false, min: 0, max: 1)]
        public string @VpcEndpointType { get; }
    }

}
