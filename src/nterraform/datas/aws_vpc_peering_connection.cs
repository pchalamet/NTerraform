using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_vpc_peering_connection")]
    public sealed class aws_vpc_peering_connection : nterraform.data
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

        public aws_vpc_peering_connection(filter[] @filter = null)
        {
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "accepter", @out: true, min: 0, max: 1)]
        public Dictionary<string,bool> @Accepter { get; }

        [nterraform.TerraformProperty(name: "cidr_block", @out: true, min: 0, max: 1)]
        public string @CidrBlock { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.TerraformProperty(name: "peer_cidr_block", @out: true, min: 0, max: 1)]
        public string @PeerCidrBlock { get; }

        [nterraform.TerraformProperty(name: "peer_owner_id", @out: true, min: 0, max: 1)]
        public string @PeerOwnerId { get; }

        [nterraform.TerraformProperty(name: "peer_region", @out: true, min: 0, max: 1)]
        public string @PeerRegion { get; }

        [nterraform.TerraformProperty(name: "peer_vpc_id", @out: true, min: 0, max: 1)]
        public string @PeerVpcId { get; }

        [nterraform.TerraformProperty(name: "region", @out: true, min: 0, max: 1)]
        public string @Region { get; }

        [nterraform.TerraformProperty(name: "requester", @out: true, min: 0, max: 1)]
        public Dictionary<string,bool> @Requester { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
