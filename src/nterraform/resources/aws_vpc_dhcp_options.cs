using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_vpc_dhcp_options")]
    public sealed class aws_vpc_dhcp_options : nterraform.Core.resource
    {
        public aws_vpc_dhcp_options(string @domainName = null,
                                    string[] @domainNameServers = null,
                                    string[] @netbiosNameServers = null,
                                    string @netbiosNodeType = null,
                                    string[] @ntpServers = null,
                                    Dictionary<string,string> @tags = null)
        {
            @DomainName = @domainName;
            @DomainNameServers = @domainNameServers;
            @NetbiosNameServers = @netbiosNameServers;
            @NetbiosNodeType = @netbiosNodeType;
            @NtpServers = @ntpServers;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "domain_name", @out: false, min: 0, max: 1)]
        public string @DomainName { get; }

        [nterraform.Core.TerraformProperty(name: "domain_name_servers", @out: false, min: 0, max: 1)]
        public string[] @DomainNameServers { get; }

        [nterraform.Core.TerraformProperty(name: "netbios_name_servers", @out: false, min: 0, max: 1)]
        public string[] @NetbiosNameServers { get; }

        [nterraform.Core.TerraformProperty(name: "netbios_node_type", @out: false, min: 0, max: 1)]
        public string @NetbiosNodeType { get; }

        [nterraform.Core.TerraformProperty(name: "ntp_servers", @out: false, min: 0, max: 1)]
        public string[] @NtpServers { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
