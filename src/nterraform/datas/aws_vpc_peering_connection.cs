using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_vpc_peering_connection")]
    public sealed class aws_vpc_peering_connection : nterraform.Core.data
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

        public aws_vpc_peering_connection(filter[] @filter = null)
        {
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "accepter", @out: true, min: 0, max: 1)]
        public Dictionary<string,bool> @Accepter { get; }

        [nterraform.Core.TerraformProperty(name: "cidr_block", @out: true, min: 0, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.Core.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.Core.TerraformProperty(name: "peer_cidr_block", @out: true, min: 0, max: 1)]
        public string @PeerCidrBlock { get; }

        [nterraform.Core.TerraformProperty(name: "peer_owner_id", @out: true, min: 0, max: 1)]
        public string @PeerOwnerId { get; }

        [nterraform.Core.TerraformProperty(name: "peer_region", @out: true, min: 0, max: 1)]
        public string @PeerRegion { get; }

        [nterraform.Core.TerraformProperty(name: "peer_vpc_id", @out: true, min: 0, max: 1)]
        public string @PeerVpcId { get; }

        [nterraform.Core.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.Core.TerraformProperty(name: "requester", @out: true, min: 0, max: 1)]
        public Dictionary<string,bool> @Requester { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
