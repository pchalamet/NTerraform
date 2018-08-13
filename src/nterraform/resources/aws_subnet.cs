using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_subnet")]
    public sealed class aws_subnet : nterraform.Core.resource
    {
        public aws_subnet(string @cidrBlock,
                          string @vpcId,
                          bool? @assignIpv6AddressOnCreation = null,
                          bool? @mapPublicIpOnLaunch = null,
                          Dictionary<string,string> @tags = null)
        {
            @CidrBlock = @cidrBlock;
            @VpcId = @vpcId;
            @AssignIpv6AddressOnCreation = @assignIpv6AddressOnCreation;
            @MapPublicIpOnLaunch = @mapPublicIpOnLaunch;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "cidr_block", @out: false, min: 1, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.Core.TerraformProperty(name: "assign_ipv6_address_on_creation", @out: false, min: 0, max: 1)]
        public bool? @AssignIpv6AddressOnCreation { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_cidr_block", @out: true, min: 0, max: 1)]
        public string @Ipv6CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_cidr_block_association_id", @out: true, min: 0, max: 1)]
        public string @Ipv6CidrBlockAssociationId { get; }

        [nterraform.Core.TerraformProperty(name: "map_public_ip_on_launch", @out: false, min: 0, max: 1)]
        public bool? @MapPublicIpOnLaunch { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
