using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_traffic_manager_profile")]
    public sealed class azurerm_traffic_manager_profile : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "monitor_config")]
        public sealed class monitor_config : nterraform.Core.structure
        {
            public monitor_config(int @port,
                                  string @protocol,
                                  FSharpOption<string> @path = null)
            {
                @Port = @port;
                @Protocol = @protocol;
                @Path = @path;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
            public int @Port { get; }

            [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Path { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "dns_config")]
        public sealed class dns_config : nterraform.Core.structure
        {
            public dns_config(string @relativeName,
                              int @ttl)
            {
                @RelativeName = @relativeName;
                @Ttl = @ttl;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "relative_name", @out: false, min: 1, max: 1)]
            public string @RelativeName { get; }

            [nterraform.Core.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
            public int @Ttl { get; }
        }

        public azurerm_traffic_manager_profile(FSharpList<dns_config> @dnsConfig,
                                               FSharpList<monitor_config> @monitorConfig,
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

        [nterraform.Core.TerraformProperty(name: "dns_config", @out: false, min: 1, max: 0)]
        public FSharpList<dns_config> @DnsConfig { get; }

        [nterraform.Core.TerraformProperty(name: "monitor_config", @out: false, min: 1, max: 0)]
        public FSharpList<monitor_config> @MonitorConfig { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "traffic_routing_method", @out: false, min: 1, max: 1)]
        public string @TrafficRoutingMethod { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "profile_status", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ProfileStatus { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
