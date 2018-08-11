using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_traffic_manager_profile : NTerraform.resource
    {
        public class dns_config
        {
            public dns_config(string @relativeName,
                              int @ttl)
            {
                @RelativeName = @relativeName;
                @Ttl = @ttl;
            }

            public string @RelativeName { get; }
            public int @Ttl { get; }
        }

        public class monitor_config
        {
            public monitor_config(int @port,
                                  string @protocol,
                                  string @path = null)
            {
                @Port = @port;
                @Protocol = @protocol;
                @Path = @path;
            }

            public int @Port { get; }
            public string @Protocol { get; }
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
        }

        public dns_config[] @DnsConfig { get; }
        public monitor_config[] @MonitorConfig { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @TrafficRoutingMethod { get; }
        public string @Fqdn { get; }
        public string @ProfileStatus { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
