using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_customer_gateway")]
    public sealed class aws_customer_gateway : nterraform.Core.resource
    {
        public aws_customer_gateway(int @bgpAsn,
                                    string @ipAddress,
                                    string @type,
                                    Dictionary<string,string> @tags = null)
        {
            @BgpAsn = @bgpAsn;
            @IpAddress = @ipAddress;
            @Type = @type;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "bgp_asn", @out: false, min: 1, max: 1)]
        public int @BgpAsn { get; }

        [nterraform.Core.TerraformProperty(name: "ip_address", @out: false, min: 1, max: 1)]
        public string @IpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
