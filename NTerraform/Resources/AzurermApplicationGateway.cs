using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_application_gateway : NTerraform.resource
    {
        public sealed class backend_address_pool
        {
            public backend_address_pool(string @name,
                                        string[] @fqdnList = null,
                                        string[] @ipAddressList = null)
            {
                @Name = @name;
                @FqdnList = @fqdnList;
                @IpAddressList = @ipAddressList;
            }

            public string @Name { get; }
            public string[] @FqdnList { get; }
            public string @Id { get; }
            public string[] @IpAddressList { get; }
        }

        public sealed class http_listener
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

        public sealed class ssl_certificate
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

        public sealed class gateway_ip_configuration
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

        public sealed class url_path_map
        {
            public sealed class path_rule
            {
                public path_rule(string @backendAddressPoolName,
                                 string @backendHttpSettingsName,
                                 string @name,
                                 string[] @paths)
                {
                    @BackendAddressPoolName = @backendAddressPoolName;
                    @BackendHttpSettingsName = @backendHttpSettingsName;
                    @Name = @name;
                    @Paths = @paths;
                }

                public string @BackendAddressPoolName { get; }
                public string @BackendHttpSettingsName { get; }
                public string @Name { get; }
                public string[] @Paths { get; }
                public string @BackendAddressPoolId { get; }
                public string @BackendHttpSettingsId { get; }
                public string @Id { get; }
            }

            public url_path_map(string @defaultBackendAddressPoolName,
                                string @defaultBackendHttpSettingsName,
                                string @name,
                                path_rule[] @pathRule)
            {
                @DefaultBackendAddressPoolName = @defaultBackendAddressPoolName;
                @DefaultBackendHttpSettingsName = @defaultBackendHttpSettingsName;
                @Name = @name;
                @PathRule = @pathRule;
            }

            public string @DefaultBackendAddressPoolName { get; }
            public string @DefaultBackendHttpSettingsName { get; }
            public string @Name { get; }
            public path_rule[] @PathRule { get; }
            public string @DefaultBackendAddressPoolId { get; }
            public string @DefaultBackendHttpSettingsId { get; }
            public string @Id { get; }
        }

        public sealed class frontend_ip_configuration
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

        public sealed class sku
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

        public sealed class waf_configuration
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

        public sealed class request_routing_rule
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

        public sealed class frontend_port
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

        public sealed class probe
        {
            public sealed class match
            {
                public match(string @body = null,
                             string[] @statusCode = null)
                {
                    @Body = @body;
                    @StatusCode = @statusCode;
                }

                public string @Body { get; }
                public string[] @StatusCode { get; }
            }

            public probe(string @host,
                         int @interval,
                         string @name,
                         string @path,
                         string @protocol,
                         int @timeout,
                         int @unhealthyThreshold,
                         match[] @match = null,
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
            public match[] @Match { get; }
            public int? @MinimumServers { get; }
        }

        public sealed class authentication_certificate
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

        public sealed class backend_http_settings
        {
            public sealed class authentication_certificate
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
                                         authentication_certificate[] @authenticationCertificate = null,
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
            public authentication_certificate[] @AuthenticationCertificate { get; }
            public string @Id { get; }
            public string @ProbeId { get; }
            public string @ProbeName { get; }
            public int? @RequestTimeout { get; }
        }

        public azurerm_application_gateway(backend_address_pool[] @backendAddressPool,
                                           backend_http_settings[] @backendHttpSettings,
                                           frontend_ip_configuration[] @frontendIpConfiguration,
                                           frontend_port[] @frontendPort,
                                           gateway_ip_configuration[] @gatewayIpConfiguration,
                                           http_listener[] @httpListener,
                                           string @location,
                                           string @name,
                                           request_routing_rule[] @requestRoutingRule,
                                           string @resourceGroupName,
                                           sku[] @sku,
                                           authentication_certificate[] @authenticationCertificate = null,
                                           string[] @disabledSslProtocols = null,
                                           probe[] @probe = null,
                                           ssl_certificate[] @sslCertificate = null,
                                           url_path_map[] @urlPathMap = null,
                                           waf_configuration[] @wafConfiguration = null)
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

        public backend_address_pool[] @BackendAddressPool { get; }
        public backend_http_settings[] @BackendHttpSettings { get; }
        public frontend_ip_configuration[] @FrontendIpConfiguration { get; }
        public frontend_port[] @FrontendPort { get; }
        public gateway_ip_configuration[] @GatewayIpConfiguration { get; }
        public http_listener[] @HttpListener { get; }
        public string @Location { get; }
        public string @Name { get; }
        public request_routing_rule[] @RequestRoutingRule { get; }
        public string @ResourceGroupName { get; }
        public sku[] @Sku { get; }
        public authentication_certificate[] @AuthenticationCertificate { get; }
        public string[] @DisabledSslProtocols { get; }
        public probe[] @Probe { get; }
        public ssl_certificate[] @SslCertificate { get; }
        public Dictionary<string,string> @Tags { get; }
        public url_path_map[] @UrlPathMap { get; }
        public waf_configuration[] @WafConfiguration { get; }
    }

}
