using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_vpc")]
    public sealed class aws_vpc : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "cidr_block_associations")]
        public sealed class cidr_block_associations : nterraform.Core.structure
        {
            public cidr_block_associations()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "association_id", @out: true, min: 0, max: 1)]
            public string @AssociationId { get; }

            [nterraform.Core.TerraformProperty(name: "cidr_block", @out: true, min: 0, max: 1)]
            public string @CidrBlock { get; }

            [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
            public string @State { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_vpc(cidr_block_associations[] @cidrBlockAssociations = null,
                       filter[] @filter = null)
        {
            @CidrBlockAssociations = @cidrBlockAssociations;
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "cidr_block", @out: true, min: 0, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "cidr_block_associations", @out: false, min: 0, max: 0)]
        public cidr_block_associations[] @CidrBlockAssociations { get; }

        [nterraform.Core.TerraformProperty(name: "default", @out: true, min: 0, max: 1)]
        public bool? @Default { get; }

        [nterraform.Core.TerraformProperty(name: "dhcp_options_id", @out: true, min: 0, max: 1)]
        public string @DhcpOptionsId { get; }

        [nterraform.Core.TerraformProperty(name: "enable_dns_hostnames", @out: true, min: 0, max: 1)]
        public bool? @EnableDnsHostnames { get; }

        [nterraform.Core.TerraformProperty(name: "enable_dns_support", @out: true, min: 0, max: 1)]
        public bool? @EnableDnsSupport { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.Core.TerraformProperty(name: "instance_tenancy", @out: true, min: 0, max: 1)]
        public string @InstanceTenancy { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_association_id", @out: true, min: 0, max: 1)]
        public string @Ipv6AssociationId { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_cidr_block", @out: true, min: 0, max: 1)]
        public string @Ipv6CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
