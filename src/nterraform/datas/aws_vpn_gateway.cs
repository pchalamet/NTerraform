using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_vpn_gateway")]
    public sealed class aws_vpn_gateway : nterraform.Core.data
    {
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

        public aws_vpn_gateway(filter[] @filter = null)
        {
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "amazon_side_asn", @out: true, min: 0, max: 1)]
        public string @AmazonSideAsn { get; }

        [nterraform.Core.TerraformProperty(name: "attached_vpc_id", @out: true, min: 0, max: 1)]
        public string @AttachedVpcId { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
