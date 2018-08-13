using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_vpc_dhcp_options")]
    public sealed class aws_vpc_dhcp_options : nterraform.Core.data
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

        public aws_vpc_dhcp_options(filter[] @filter = null)
        {
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "dhcp_options_id", @out: true, min: 0, max: 1)]
        public string @DhcpOptionsId { get; }

        [nterraform.Core.TerraformProperty(name: "domain_name", @out: true, min: 0, max: 1)]
        public string @DomainName { get; }

        [nterraform.Core.TerraformProperty(name: "domain_name_servers", @out: true, min: 0, max: 1)]
        public string[] @DomainNameServers { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "netbios_name_servers", @out: true, min: 0, max: 1)]
        public string[] @NetbiosNameServers { get; }

        [nterraform.Core.TerraformProperty(name: "netbios_node_type", @out: true, min: 0, max: 1)]
        public string @NetbiosNodeType { get; }

        [nterraform.Core.TerraformProperty(name: "ntp_servers", @out: true, min: 0, max: 1)]
        public string[] @NtpServers { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
