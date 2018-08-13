using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_customer_gateway")]
    public sealed class aws_customer_gateway : nterraform.resource
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

        [nterraform.TerraformProperty(name: "bgp_asn", @out: false, min: 1, max: 1)]
        public int @BgpAsn { get; }

        [nterraform.TerraformProperty(name: "ip_address", @out: false, min: 1, max: 1)]
        public string @IpAddress { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
