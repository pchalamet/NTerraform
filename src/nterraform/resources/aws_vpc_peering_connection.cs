using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc_peering_connection")]
    public sealed class aws_vpc_peering_connection : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "accepter")]
        public sealed class accepter : nterraform.structure
        {
            public accepter(bool? @allowClassicLinkToRemoteVpc = null,
                            bool? @allowRemoteVpcDnsResolution = null,
                            bool? @allowVpcToRemoteClassicLink = null)
            {
                @AllowClassicLinkToRemoteVpc = @allowClassicLinkToRemoteVpc;
                @AllowRemoteVpcDnsResolution = @allowRemoteVpcDnsResolution;
                @AllowVpcToRemoteClassicLink = @allowVpcToRemoteClassicLink;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allow_classic_link_to_remote_vpc", @out: false, min: 0, max: 1)]
            public bool? @AllowClassicLinkToRemoteVpc { get; }

            [nterraform.TerraformProperty(name: "allow_remote_vpc_dns_resolution", @out: false, min: 0, max: 1)]
            public bool? @AllowRemoteVpcDnsResolution { get; }

            [nterraform.TerraformProperty(name: "allow_vpc_to_remote_classic_link", @out: false, min: 0, max: 1)]
            public bool? @AllowVpcToRemoteClassicLink { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "requester")]
        public sealed class requester : nterraform.structure
        {
            public requester(bool? @allowClassicLinkToRemoteVpc = null,
                             bool? @allowRemoteVpcDnsResolution = null,
                             bool? @allowVpcToRemoteClassicLink = null)
            {
                @AllowClassicLinkToRemoteVpc = @allowClassicLinkToRemoteVpc;
                @AllowRemoteVpcDnsResolution = @allowRemoteVpcDnsResolution;
                @AllowVpcToRemoteClassicLink = @allowVpcToRemoteClassicLink;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allow_classic_link_to_remote_vpc", @out: false, min: 0, max: 1)]
            public bool? @AllowClassicLinkToRemoteVpc { get; }

            [nterraform.TerraformProperty(name: "allow_remote_vpc_dns_resolution", @out: false, min: 0, max: 1)]
            public bool? @AllowRemoteVpcDnsResolution { get; }

            [nterraform.TerraformProperty(name: "allow_vpc_to_remote_classic_link", @out: false, min: 0, max: 1)]
            public bool? @AllowVpcToRemoteClassicLink { get; }
        }

        public aws_vpc_peering_connection(string @peerVpcId,
                                          string @vpcId,
                                          accepter[] @accepter = null,
                                          bool? @autoAccept = null,
                                          requester[] @requester = null,
                                          Dictionary<string,string> @tags = null)
        {
            @PeerVpcId = @peerVpcId;
            @VpcId = @vpcId;
            @Accepter = @accepter;
            @AutoAccept = @autoAccept;
            @Requester = @requester;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "peer_vpc_id", @out: false, min: 1, max: 1)]
        public string @PeerVpcId { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
        public string @VpcId { get; }

        [nterraform.TerraformProperty(name: "accept_status", @out: true, min: 0, max: 1)]
        public string @AcceptStatus { get; }

        [nterraform.TerraformProperty(name: "accepter", @out: false, min: 0, max: 1)]
        public accepter[] @Accepter { get; }

        [nterraform.TerraformProperty(name: "auto_accept", @out: false, min: 0, max: 1)]
        public bool? @AutoAccept { get; }

        [nterraform.TerraformProperty(name: "peer_owner_id", @out: true, min: 0, max: 1)]
        public string @PeerOwnerId { get; }

        [nterraform.TerraformProperty(name: "peer_region", @out: true, min: 0, max: 1)]
        public string @PeerRegion { get; }

        [nterraform.TerraformProperty(name: "requester", @out: false, min: 0, max: 1)]
        public requester[] @Requester { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
