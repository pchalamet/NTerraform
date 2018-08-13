using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc")]
    public sealed class aws_vpc : nterraform.resource
    {
        public aws_vpc(string @cidrBlock,
                       bool? @assignGeneratedIpv6CidrBlock = null,
                       bool? @enableDnsSupport = null,
                       string @instanceTenancy = null,
                       Dictionary<string,string> @tags = null)
        {
            @CidrBlock = @cidrBlock;
            @AssignGeneratedIpv6CidrBlock = @assignGeneratedIpv6CidrBlock;
            @EnableDnsSupport = @enableDnsSupport;
            @InstanceTenancy = @instanceTenancy;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "cidr_block", @out: false, min: 1, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "assign_generated_ipv6_cidr_block", @out: false, min: 0, max: 1)]
        public bool? @AssignGeneratedIpv6CidrBlock { get; }

        [nterraform.TerraformProperty(name: "default_network_acl_id", @out: true, min: 0, max: 1)]
        public string @DefaultNetworkAclId { get; }

        [nterraform.TerraformProperty(name: "default_route_table_id", @out: true, min: 0, max: 1)]
        public string @DefaultRouteTableId { get; }

        [nterraform.TerraformProperty(name: "default_security_group_id", @out: true, min: 0, max: 1)]
        public string @DefaultSecurityGroupId { get; }

        [nterraform.TerraformProperty(name: "dhcp_options_id", @out: true, min: 0, max: 1)]
        public string @DhcpOptionsId { get; }

        [nterraform.TerraformProperty(name: "enable_classiclink", @out: true, min: 0, max: 1)]
        public bool? @EnableClassiclink { get; }

        [nterraform.TerraformProperty(name: "enable_classiclink_dns_support", @out: true, min: 0, max: 1)]
        public bool? @EnableClassiclinkDnsSupport { get; }

        [nterraform.TerraformProperty(name: "enable_dns_hostnames", @out: true, min: 0, max: 1)]
        public bool? @EnableDnsHostnames { get; }

        [nterraform.TerraformProperty(name: "enable_dns_support", @out: false, min: 0, max: 1)]
        public bool? @EnableDnsSupport { get; }

        [nterraform.TerraformProperty(name: "instance_tenancy", @out: false, min: 0, max: 1)]
        public string @InstanceTenancy { get; }

        [nterraform.TerraformProperty(name: "ipv6_association_id", @out: true, min: 0, max: 1)]
        public string @Ipv6AssociationId { get; }

        [nterraform.TerraformProperty(name: "ipv6_cidr_block", @out: true, min: 0, max: 1)]
        public string @Ipv6CidrBlock { get; }

        [nterraform.TerraformProperty(name: "main_route_table_id", @out: true, min: 0, max: 1)]
        public string @MainRouteTableId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
