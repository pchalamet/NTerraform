using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc_peering_connection_options")]
    public sealed class aws_vpc_peering_connection_options : nterraform.resource
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

        public aws_vpc_peering_connection_options(string @vpcPeeringConnectionId,
                                                  accepter[] @accepter = null,
                                                  requester[] @requester = null)
        {
            @VpcPeeringConnectionId = @vpcPeeringConnectionId;
            @Accepter = @accepter;
            @Requester = @requester;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "vpc_peering_connection_id", @out: false, min: 1, max: 1)]
        public string @VpcPeeringConnectionId { get; }

        [nterraform.TerraformProperty(name: "accepter", @out: false, min: 0, max: 1)]
        public accepter[] @Accepter { get; }

        [nterraform.TerraformProperty(name: "requester", @out: false, min: 0, max: 1)]
        public requester[] @Requester { get; }
    }

}
