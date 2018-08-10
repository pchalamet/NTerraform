using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_application_gateway : NTerraform.resource
    {
        public class url_path_map
        {
            public class path_rule
            {
                public path_rule(string @backendAddressPoolName,
                                 string @backendHttpSettingsName,
                                 string @name,
                                 List<string> @paths)
                {
                    @BackendAddressPoolName = @backendAddressPoolName;
                    @BackendHttpSettingsName = @backendHttpSettingsName;
                    @Name = @name;
                    @Paths = @paths;
                }

                public string @BackendAddressPoolName { get; }
                public string @BackendHttpSettingsName { get; }
                public string @Name { get; }
                public List<string> @Paths { get; }
                public string @BackendAddressPoolId { get; }
                public string @BackendHttpSettingsId { get; }
                public string @Id { get; }
            }

            public url_path_map(string @defaultBackendAddressPoolName,
                                string @defaultBackendHttpSettingsName,
                                string @name,
                                List<path_rule> @pathRule)
            {
                @DefaultBackendAddressPoolName = @defaultBackendAddressPoolName;
                @DefaultBackendHttpSettingsName = @defaultBackendHttpSettingsName;
                @Name = @name;
                @PathRule = @pathRule;
            }

            public string @DefaultBackendAddressPoolName { get; }
            public string @DefaultBackendHttpSettingsName { get; }
            public string @Name { get; }
            public List<path_rule> @PathRule { get; }
            public string @DefaultBackendAddressPoolId { get; }
            public string @DefaultBackendHttpSettingsId { get; }
            public string @Id { get; }
        }

        public class http_listener
        {
            public http_listener(string @frontendIpConfigurationName,
                                 string @frontendPortName,
                                 string @name,
                                 string @protocol,
                                 string @hostName = null,
                                 bool? @requireSni = null,
                                 string @sslCertificateName = null)
            {
                @FrontendIpConfigurationName = @frontendIpConfigurationName;
                @FrontendPortName = @frontendPortName;
                @Name = @name;
                @Protocol = @protocol;
                @HostName = @hostName;
                @RequireSni = @requireSni;
                @SslCertificateName = @sslCertificateName;
            }

            public string @FrontendIpConfigurationName { get; }
            public string @FrontendPortName { get; }
            public string @Name { get; }
            public string @Protocol { get; }
            public string @FrontendIpConfigurationId { get; }
            public string @FrontendPortId { get; }
            public string @HostName { get; }
            public string @Id { get; }
            public bool? @RequireSni { get; }
            public string @SslCertificateId { get; }
            public string @SslCertificateName { get; }
        }

        public class request_routing_rule
        {
            public request_routing_rule(string @httpListenerName,
                                        string @name,
                                        string @ruleType,
                                        string @backendAddressPoolName = null,
                                        string @backendHttpSettingsName = null,
                                        string @urlPathMapName = null)
            {
                @HttpListenerName = @httpListenerName;
                @Name = @name;
                @RuleType = @ruleType;
                @BackendAddressPoolName = @backendAddressPoolName;
                @BackendHttpSettingsName = @backendHttpSettingsName;
                @UrlPathMapName = @urlPathMapName;
            }

            public string @HttpListenerName { get; }
            public string @Name { get; }
            public string @RuleType { get; }
            public string @BackendAddressPoolId { get; }
            public string @BackendAddressPoolName { get; }
            public string @BackendHttpSettingsId { get; }
            public string @BackendHttpSettingsName { get; }
            public string @HttpListenerId { get; }
            public string @Id { get; }
            public string @UrlPathMapId { get; }
            public string @UrlPathMapName { get; }
        }

        public class probe
        {
            public class match
            {
                public match(string @body = null,
                             List<string> @statusCode = null)
                {
                    @Body = @body;
                    @StatusCode = @statusCode;
                }

                public string @Body { get; }
                public List<string> @StatusCode { get; }
            }

            public probe(string @host,
                         int @interval,
                         string @name,
                         string @path,
                         string @protocol,
                         int @timeout,
                         int @unhealthyThreshold,
                         List<match> @match = null,
                         int? @minimumServers = null)
            {
                @Host = @host;
                @Interval = @interval;
                @Name = @name;
                @Path = @path;
                @Protocol = @protocol;
                @Timeout = @timeout;
                @UnhealthyThreshold = @unhealthyThreshold;
                @Match = @match;
                @MinimumServers = @minimumServers;
            }

            public string @Host { get; }
            public int @Interval { get; }
            public string @Name { get; }
            public string @Path { get; }
            public string @Protocol { get; }
            public int @Timeout { get; }
            public int @UnhealthyThreshold { get; }
            public string @Id { get; }
            public List<match> @Match { get; }
            public int? @MinimumServers { get; }
        }

        public class gateway_ip_configuration
        {
            public gateway_ip_configuration(string @name,
                                            string @subnetId)
            {
                @Name = @name;
                @SubnetId = @subnetId;
            }

            public string @Name { get; }
            public string @SubnetId { get; }
            public string @Id { get; }
        }

        public class backend_address_pool
        {
            public backend_address_pool(string @name,
                                        List<string> @fqdnList = null,
                                        List<string> @ipAddressList = null)
            {
                @Name = @name;
                @FqdnList = @fqdnList;
                @IpAddressList = @ipAddressList;
            }

            public string @Name { get; }
            public List<string> @FqdnList { get; }
            public string @Id { get; }
            public List<string> @IpAddressList { get; }
        }

        public class frontend_ip_configuration
        {
            public frontend_ip_configuration(string @name)
            {
                @Name = @name;
            }

            public string @Name { get; }
            public string @Id { get; }
            public string @PrivateIpAddress { get; }
            public string @PrivateIpAddressAllocation { get; }
            public string @PublicIpAddressId { get; }
            public string @SubnetId { get; }
        }

        public class authentication_certificate
        {
            public authentication_certificate(string @data,
                                              string @name)
            {
                @Data = @data;
                @Name = @name;
            }

            public string @Data { get; }
            public string @Name { get; }
            public string @Id { get; }
        }

        public class sku
        {
            public sku(int @capacity,
                       string @name,
                       string @tier)
            {
                @Capacity = @capacity;
                @Name = @name;
                @Tier = @tier;
            }

            public int @Capacity { get; }
            public string @Name { get; }
            public string @Tier { get; }
        }

        public class waf_configuration
        {
            public waf_configuration(bool @enabled,
                                     string @firewallMode,
                                     string @ruleSetVersion,
                                     string @ruleSetType = null)
            {
                @Enabled = @enabled;
                @FirewallMode = @firewallMode;
                @RuleSetVersion = @ruleSetVersion;
                @RuleSetType = @ruleSetType;
            }

            public bool @Enabled { get; }
            public string @FirewallMode { get; }
            public string @RuleSetVersion { get; }
            public string @RuleSetType { get; }
        }

        public class frontend_port
        {
            public frontend_port(string @name,
                                 int @port)
            {
                @Name = @name;
                @Port = @port;
            }

            public string @Name { get; }
            public int @Port { get; }
            public string @Id { get; }
        }

        public class backend_http_settings
        {
            public class authentication_certificate
            {
                public authentication_certificate(string @name)
                {
                    @Name = @name;
                }

                public string @Name { get; }
                public string @Id { get; }
            }

            public backend_http_settings(string @cookieBasedAffinity,
                                         string @name,
                                         int @port,
                                         string @protocol,
                                         List<authentication_certificate> @authenticationCertificate = null,
                                         string @probeName = null,
                                         int? @requestTimeout = null)
            {
                @CookieBasedAffinity = @cookieBasedAffinity;
                @Name = @name;
                @Port = @port;
                @Protocol = @protocol;
                @AuthenticationCertificate = @authenticationCertificate;
                @ProbeName = @probeName;
                @RequestTimeout = @requestTimeout;
            }

            public string @CookieBasedAffinity { get; }
            public string @Name { get; }
            public int @Port { get; }
            public string @Protocol { get; }
            public List<authentication_certificate> @AuthenticationCertificate { get; }
            public string @Id { get; }
            public string @ProbeId { get; }
            public string @ProbeName { get; }
            public int? @RequestTimeout { get; }
        }

        public class ssl_certificate
        {
            public ssl_certificate(string @data,
                                   string @name,
                                   string @password)
            {
                @Data = @data;
                @Name = @name;
                @Password = @password;
            }

            public string @Data { get; }
            public string @Name { get; }
            public string @Password { get; }
            public string @Id { get; }
            public string @PublicCertData { get; }
        }

        public azurerm_application_gateway(List<backend_address_pool> @backendAddressPool,
                                           List<backend_http_settings> @backendHttpSettings,
                                           List<frontend_ip_configuration> @frontendIpConfiguration,
                                           List<frontend_port> @frontendPort,
                                           List<gateway_ip_configuration> @gatewayIpConfiguration,
                                           List<http_listener> @httpListener,
                                           string @location,
                                           string @name,
                                           List<request_routing_rule> @requestRoutingRule,
                                           string @resourceGroupName,
                                           HashSet<sku> @sku,
                                           List<authentication_certificate> @authenticationCertificate = null,
                                           List<string> @disabledSslProtocols = null,
                                           List<probe> @probe = null,
                                           List<ssl_certificate> @sslCertificate = null,
                                           List<url_path_map> @urlPathMap = null,
                                           HashSet<waf_configuration> @wafConfiguration = null)
        {
            @BackendAddressPool = @backendAddressPool;
            @BackendHttpSettings = @backendHttpSettings;
            @FrontendIpConfiguration = @frontendIpConfiguration;
            @FrontendPort = @frontendPort;
            @GatewayIpConfiguration = @gatewayIpConfiguration;
            @HttpListener = @httpListener;
            @Location = @location;
            @Name = @name;
            @RequestRoutingRule = @requestRoutingRule;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @AuthenticationCertificate = @authenticationCertificate;
            @DisabledSslProtocols = @disabledSslProtocols;
            @Probe = @probe;
            @SslCertificate = @sslCertificate;
            @UrlPathMap = @urlPathMap;
            @WafConfiguration = @wafConfiguration;
        }

        public List<backend_address_pool> @BackendAddressPool { get; }
        public List<backend_http_settings> @BackendHttpSettings { get; }
        public List<frontend_ip_configuration> @FrontendIpConfiguration { get; }
        public List<frontend_port> @FrontendPort { get; }
        public List<gateway_ip_configuration> @GatewayIpConfiguration { get; }
        public List<http_listener> @HttpListener { get; }
        public string @Location { get; }
        public string @Name { get; }
        public List<request_routing_rule> @RequestRoutingRule { get; }
        public string @ResourceGroupName { get; }
        public HashSet<sku> @Sku { get; }
        public List<authentication_certificate> @AuthenticationCertificate { get; }
        public List<string> @DisabledSslProtocols { get; }
        public List<probe> @Probe { get; }
        public List<ssl_certificate> @SslCertificate { get; }
        public Dictionary<string,string> @Tags { get; }
        public List<url_path_map> @UrlPathMap { get; }
        public HashSet<waf_configuration> @WafConfiguration { get; }
    }

}
