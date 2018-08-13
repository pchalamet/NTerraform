using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_traffic_manager_profile")]
    public sealed class azurerm_traffic_manager_profile : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "dns_config")]
        public sealed class dns_config : nterraform.structure
        {
            public dns_config(string @relativeName,
                              int @ttl)
            {
                @RelativeName = @relativeName;
                @Ttl = @ttl;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "relative_name", @out: false, min: 1, max: 1)]
            public string @RelativeName { get; }

            [nterraform.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
            public int @Ttl { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "monitor_config")]
        public sealed class monitor_config : nterraform.structure
        {
            public monitor_config(int @port,
                                  string @protocol,
                                  string @path = null)
            {
                @Port = @port;
                @Protocol = @protocol;
                @Path = @path;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
            public int @Port { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
            public string @Path { get; }
        }

        public azurerm_traffic_manager_profile(dns_config[] @dnsConfig,
                                               monitor_config[] @monitorConfig,
                                               string @name,
                                               string @resourceGroupName,
                                               string @trafficRoutingMethod)
        {
            @DnsConfig = @dnsConfig;
            @MonitorConfig = @monitorConfig;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @TrafficRoutingMethod = @trafficRoutingMethod;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "dns_config", @out: false, min: 1, max: 0)]
        public dns_config[] @DnsConfig { get; }

        [nterraform.TerraformProperty(name: "monitor_config", @out: false, min: 1, max: 0)]
        public monitor_config[] @MonitorConfig { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "traffic_routing_method", @out: false, min: 1, max: 1)]
        public string @TrafficRoutingMethod { get; }

        [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.TerraformProperty(name: "profile_status", @out: true, min: 0, max: 1)]
        public string @ProfileStatus { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
