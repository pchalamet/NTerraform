using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpc_endpoint")]
    public sealed class aws_vpc_endpoint : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "dns_entry")]
        public sealed class dns_entry : nterraform.Core.structure
        {
            public dns_entry()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "dns_name", @out: true, min: 0, max: 1)]
            public string @DnsName { get; }

            [nterraform.Core.TerraformProperty(name: "hosted_zone_id", @out: true, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "service_name", @out: false, min: 1, max: 1)]
        public string @ServiceName { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.Core.TerraformProperty(name: "auto_accept", @out: false, min: 0, max: 1)]
        public bool? @AutoAccept { get; }

        [nterraform.Core.TerraformProperty(name: "cidr_blocks", @out: true, min: 0, max: 1)]
        public string[] @CidrBlocks { get; }

        [nterraform.Core.TerraformProperty(name: "dns_entry", @out: false, min: 0, max: 0)]
        public dns_entry[] @DnsEntry { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface_ids", @out: true, min: 0, max: 1)]
        public string[] @NetworkInterfaceIds { get; }

        [nterraform.Core.TerraformProperty(name: "policy", @out: true, min: 0, max: 1)]
        public string @Policy { get; }

        [nterraform.Core.TerraformProperty(name: "prefix_list_id", @out: true, min: 0, max: 1)]
        public string @PrefixListId { get; }

        [nterraform.Core.TerraformProperty(name: "private_dns_enabled", @out: false, min: 0, max: 1)]
        public bool? @PrivateDnsEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "route_table_ids", @out: true, min: 0, max: 1)]
        public string[] @RouteTableIds { get; }

        [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroupIds { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
        public string[] @SubnetIds { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_endpoint_type", @out: false, min: 0, max: 1)]
        public string @VpcEndpointType { get; }
    }

}
