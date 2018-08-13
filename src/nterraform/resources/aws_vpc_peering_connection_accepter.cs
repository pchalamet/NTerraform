using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpc_peering_connection_accepter")]
    public sealed class aws_vpc_peering_connection_accepter : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "requester")]
        public sealed class requester : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "allow_classic_link_to_remote_vpc", @out: false, min: 0, max: 1)]
            public bool? @AllowClassicLinkToRemoteVpc { get; }

            [nterraform.Core.TerraformProperty(name: "allow_remote_vpc_dns_resolution", @out: false, min: 0, max: 1)]
            public bool? @AllowRemoteVpcDnsResolution { get; }

            [nterraform.Core.TerraformProperty(name: "allow_vpc_to_remote_classic_link", @out: false, min: 0, max: 1)]
            public bool? @AllowVpcToRemoteClassicLink { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "accepter")]
        public sealed class accepter : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "allow_classic_link_to_remote_vpc", @out: false, min: 0, max: 1)]
            public bool? @AllowClassicLinkToRemoteVpc { get; }

            [nterraform.Core.TerraformProperty(name: "allow_remote_vpc_dns_resolution", @out: false, min: 0, max: 1)]
            public bool? @AllowRemoteVpcDnsResolution { get; }

            [nterraform.Core.TerraformProperty(name: "allow_vpc_to_remote_classic_link", @out: false, min: 0, max: 1)]
            public bool? @AllowVpcToRemoteClassicLink { get; }
        }

        public aws_vpc_peering_connection_accepter(string @vpcPeeringConnectionId,
                                                   accepter[] @accepter = null,
                                                   bool? @autoAccept = null,
                                                   requester[] @requester = null,
                                                   Dictionary<string,string> @tags = null)
        {
            @VpcPeeringConnectionId = @vpcPeeringConnectionId;
            @Accepter = @accepter;
            @AutoAccept = @autoAccept;
            @Requester = @requester;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "vpc_peering_connection_id", @out: false, min: 1, max: 1)]
        public string @VpcPeeringConnectionId { get; }

        [nterraform.Core.TerraformProperty(name: "accept_status", @out: true, min: 0, max: 1)]
        public string @AcceptStatus { get; }

        [nterraform.Core.TerraformProperty(name: "accepter", @out: false, min: 0, max: 1)]
        public accepter[] @Accepter { get; }

        [nterraform.Core.TerraformProperty(name: "auto_accept", @out: false, min: 0, max: 1)]
        public bool? @AutoAccept { get; }

        [nterraform.Core.TerraformProperty(name: "peer_owner_id", @out: true, min: 0, max: 1)]
        public string @PeerOwnerId { get; }

        [nterraform.Core.TerraformProperty(name: "peer_region", @out: true, min: 0, max: 1)]
        public string @PeerRegion { get; }

        [nterraform.Core.TerraformProperty(name: "peer_vpc_id", @out: true, min: 0, max: 1)]
        public string @PeerVpcId { get; }

        [nterraform.Core.TerraformProperty(name: "requester", @out: false, min: 0, max: 1)]
        public requester[] @Requester { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
