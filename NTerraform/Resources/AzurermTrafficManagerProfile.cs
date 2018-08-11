using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_traffic_manager_profile")]
    public sealed class azurerm_traffic_manager_profile : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "monitor_config")]
        public sealed class monitor_config
        {
            public monitor_config(int @port,
                                  string @protocol,
                                  string @path = null)
            {
                @Port = @port;
                @Protocol = @protocol;
                @Path = @path;
            }

            [TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
            public int @Port { get; }

            [TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
            public string @Path { get; }
        }

        [TerraformStructure(category: "", typeName: "dns_config")]
        public sealed class dns_config
        {
            public dns_config(string @relativeName,
                              int @ttl)
            {
                @RelativeName = @relativeName;
                @Ttl = @ttl;
            }

            [TerraformProperty(name: "relative_name", @out: false, min: 1, max: 1)]
            public string @RelativeName { get; }

            [TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
            public int @Ttl { get; }
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
        }

        [TerraformProperty(name: "dns_config", @out: false, min: 1, max: 0)]
        public dns_config[] @DnsConfig { get; }

        [TerraformProperty(name: "monitor_config", @out: false, min: 1, max: 0)]
        public monitor_config[] @MonitorConfig { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "traffic_routing_method", @out: false, min: 1, max: 1)]
        public string @TrafficRoutingMethod { get; }

        [TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [TerraformProperty(name: "profile_status", @out: true, min: 0, max: 1)]
        public string @ProfileStatus { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
