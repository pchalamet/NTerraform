using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_vpc_dhcp_options")]
    public sealed class aws_vpc_dhcp_options : nterraform.resource
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

        [nterraform.TerraformProperty(name: "domain_name", @out: false, min: 0, max: 1)]
        public string @DomainName { get; }

        [nterraform.TerraformProperty(name: "domain_name_servers", @out: false, min: 0, max: 1)]
        public string[] @DomainNameServers { get; }

        [nterraform.TerraformProperty(name: "netbios_name_servers", @out: false, min: 0, max: 1)]
        public string[] @NetbiosNameServers { get; }

        [nterraform.TerraformProperty(name: "netbios_node_type", @out: false, min: 0, max: 1)]
        public string @NetbiosNodeType { get; }

        [nterraform.TerraformProperty(name: "ntp_servers", @out: false, min: 0, max: 1)]
        public string[] @NtpServers { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
