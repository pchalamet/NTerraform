using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_default_vpc")]
    public sealed class aws_default_vpc : nterraform.Core.resource
    {
        public aws_default_vpc(bool? @enableDnsSupport = null,
                               Dictionary<string,string> @tags = null)
        {
            @EnableDnsSupport = @enableDnsSupport;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "assign_generated_ipv6_cidr_block", @out: true, min: 0, max: 1)]
        public bool? @AssignGeneratedIpv6CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "cidr_block", @out: true, min: 0, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "default_network_acl_id", @out: true, min: 0, max: 1)]
        public string @DefaultNetworkAclId { get; }

        [nterraform.Core.TerraformProperty(name: "default_route_table_id", @out: true, min: 0, max: 1)]
        public string @DefaultRouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "default_security_group_id", @out: true, min: 0, max: 1)]
        public string @DefaultSecurityGroupId { get; }

        [nterraform.Core.TerraformProperty(name: "dhcp_options_id", @out: true, min: 0, max: 1)]
        public string @DhcpOptionsId { get; }

        [nterraform.Core.TerraformProperty(name: "enable_classiclink", @out: true, min: 0, max: 1)]
        public bool? @EnableClassiclink { get; }

        [nterraform.Core.TerraformProperty(name: "enable_classiclink_dns_support", @out: true, min: 0, max: 1)]
        public bool? @EnableClassiclinkDnsSupport { get; }

        [nterraform.Core.TerraformProperty(name: "enable_dns_hostnames", @out: true, min: 0, max: 1)]
        public bool? @EnableDnsHostnames { get; }

        [nterraform.Core.TerraformProperty(name: "enable_dns_support", @out: false, min: 0, max: 1)]
        public bool? @EnableDnsSupport { get; }

        [nterraform.Core.TerraformProperty(name: "instance_tenancy", @out: true, min: 0, max: 1)]
        public string @InstanceTenancy { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_association_id", @out: true, min: 0, max: 1)]
        public string @Ipv6AssociationId { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_cidr_block", @out: true, min: 0, max: 1)]
        public string @Ipv6CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "main_route_table_id", @out: true, min: 0, max: 1)]
        public string @MainRouteTableId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
