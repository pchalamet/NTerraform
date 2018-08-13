using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_subnet")]
    public sealed class aws_subnet : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_subnet(filter[] @filter = null)
        {
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "assign_ipv6_address_on_creation", @out: true, min: 0, max: 1)]
        public bool? @AssignIpv6AddressOnCreation { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "cidr_block", @out: true, min: 0, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.TerraformProperty(name: "default_for_az", @out: true, min: 0, max: 1)]
        public bool? @DefaultForAz { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.TerraformProperty(name: "ipv6_cidr_block", @out: true, min: 0, max: 1)]
        public string @Ipv6CidrBlock { get; }

        [nterraform.TerraformProperty(name: "ipv6_cidr_block_association_id", @out: true, min: 0, max: 1)]
        public string @Ipv6CidrBlockAssociationId { get; }

        [nterraform.TerraformProperty(name: "map_public_ip_on_launch", @out: true, min: 0, max: 1)]
        public bool? @MapPublicIpOnLaunch { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
