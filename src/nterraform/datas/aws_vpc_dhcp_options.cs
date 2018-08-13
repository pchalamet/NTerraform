using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_vpc_dhcp_options")]
    public sealed class aws_vpc_dhcp_options : nterraform.data
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

        public aws_vpc_dhcp_options(filter[] @filter = null)
        {
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "dhcp_options_id", @out: true, min: 0, max: 1)]
        public string @DhcpOptionsId { get; }

        [nterraform.TerraformProperty(name: "domain_name", @out: true, min: 0, max: 1)]
        public string @DomainName { get; }

        [nterraform.TerraformProperty(name: "domain_name_servers", @out: true, min: 0, max: 1)]
        public string[] @DomainNameServers { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "netbios_name_servers", @out: true, min: 0, max: 1)]
        public string[] @NetbiosNameServers { get; }

        [nterraform.TerraformProperty(name: "netbios_node_type", @out: true, min: 0, max: 1)]
        public string @NetbiosNodeType { get; }

        [nterraform.TerraformProperty(name: "ntp_servers", @out: true, min: 0, max: 1)]
        public string[] @NtpServers { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
