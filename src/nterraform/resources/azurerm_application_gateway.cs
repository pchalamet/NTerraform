using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_application_gateway")]
    public sealed class azurerm_application_gateway : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "authentication_certificate")]
        public sealed class authentication_certificate : nterraform.structure
        {
            public authentication_certificate(string @data,
                                              string @name)
            {
                @Data = @data;
                @Name = @name;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "data", @out: false, min: 1, max: 1)]
            public string @Data { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.structure
        {
            public sku(int @capacity,
                       string @name,
                       string @tier)
            {
                @Capacity = @capacity;
                @Name = @name;
                @Tier = @tier;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public int @Capacity { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "tier", @out: false, min: 1, max: 1)]
            public string @Tier { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "probe")]
        public sealed class probe : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "match")]
            public sealed class match : nterraform.structure
            {
                public match(string @body = null,
                             string[] @statusCode = null)
                {
                    @Body = @body;
                    @StatusCode = @statusCode;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "body", @out: false, min: 0, max: 1)]
                public string @Body { get; }

                [nterraform.TerraformProperty(name: "status_code", @out: false, min: 0, max: 1)]
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "host", @out: false, min: 1, max: 1)]
            public string @Host { get; }

            [nterraform.TerraformProperty(name: "interval", @out: false, min: 1, max: 1)]
            public int @Interval { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
            public string @Path { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "timeout", @out: false, min: 1, max: 1)]
            public int @Timeout { get; }

            [nterraform.TerraformProperty(name: "unhealthy_threshold", @out: false, min: 1, max: 1)]
            public int @UnhealthyThreshold { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "match", @out: false, min: 0, max: 1)]
            public match[] @Match { get; }

            [nterraform.TerraformProperty(name: "minimum_servers", @out: false, min: 0, max: 1)]
            public int? @MinimumServers { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "url_path_map")]
        public sealed class url_path_map : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "path_rule")]
            public sealed class path_rule : nterraform.structure
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
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "backend_address_pool_name", @out: false, min: 1, max: 1)]
                public string @BackendAddressPoolName { get; }

                [nterraform.TerraformProperty(name: "backend_http_settings_name", @out: false, min: 1, max: 1)]
                public string @BackendHttpSettingsName { get; }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "paths", @out: false, min: 1, max: 1)]
                public string[] @Paths { get; }

                [nterraform.TerraformProperty(name: "backend_address_pool_id", @out: true, min: 0, max: 1)]
                public string @BackendAddressPoolId { get; }

                [nterraform.TerraformProperty(name: "backend_http_settings_id", @out: true, min: 0, max: 1)]
                public string @BackendHttpSettingsId { get; }

                [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "default_backend_address_pool_name", @out: false, min: 1, max: 1)]
            public string @DefaultBackendAddressPoolName { get; }

            [nterraform.TerraformProperty(name: "default_backend_http_settings_name", @out: false, min: 1, max: 1)]
            public string @DefaultBackendHttpSettingsName { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "path_rule", @out: false, min: 1, max: 0)]
            public path_rule[] @PathRule { get; }

            [nterraform.TerraformProperty(name: "default_backend_address_pool_id", @out: true, min: 0, max: 1)]
            public string @DefaultBackendAddressPoolId { get; }

            [nterraform.TerraformProperty(name: "default_backend_http_settings_id", @out: true, min: 0, max: 1)]
            public string @DefaultBackendHttpSettingsId { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "gateway_ip_configuration")]
        public sealed class gateway_ip_configuration : nterraform.structure
        {
            public gateway_ip_configuration(string @name,
                                            string @subnetId)
            {
                @Name = @name;
                @SubnetId = @subnetId;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
            public string @SubnetId { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "frontend_ip_configuration")]
        public sealed class frontend_ip_configuration : nterraform.structure
        {
            public frontend_ip_configuration(string @name)
            {
                @Name = @name;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "private_ip_address", @out: true, min: 0, max: 1)]
            public string @PrivateIpAddress { get; }

            [nterraform.TerraformProperty(name: "private_ip_address_allocation", @out: true, min: 0, max: 1)]
            public string @PrivateIpAddressAllocation { get; }

            [nterraform.TerraformProperty(name: "public_ip_address_id", @out: true, min: 0, max: 1)]
            public string @PublicIpAddressId { get; }

            [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
            public string @SubnetId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "ssl_certificate")]
        public sealed class ssl_certificate : nterraform.structure
        {
            public ssl_certificate(string @data,
                                   string @name,
                                   string @password)
            {
                @Data = @data;
                @Name = @name;
                @Password = @password;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "data", @out: false, min: 1, max: 1)]
            public string @Data { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "public_cert_data", @out: true, min: 0, max: 1)]
            public string @PublicCertData { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "backend_http_settings")]
        public sealed class backend_http_settings : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "authentication_certificate")]
            public sealed class authentication_certificate : nterraform.structure
            {
                public authentication_certificate(string @name)
                {
                    @Name = @name;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "cookie_based_affinity", @out: false, min: 1, max: 1)]
            public string @CookieBasedAffinity { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
            public int @Port { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "authentication_certificate", @out: false, min: 0, max: 0)]
            public authentication_certificate[] @AuthenticationCertificate { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "probe_id", @out: true, min: 0, max: 1)]
            public string @ProbeId { get; }

            [nterraform.TerraformProperty(name: "probe_name", @out: false, min: 0, max: 1)]
            public string @ProbeName { get; }

            [nterraform.TerraformProperty(name: "request_timeout", @out: false, min: 0, max: 1)]
            public int? @RequestTimeout { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "frontend_port")]
        public sealed class frontend_port : nterraform.structure
        {
            public frontend_port(string @name,
                                 int @port)
            {
                @Name = @name;
                @Port = @port;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "port", @out: false, min: 1, max: 1)]
            public int @Port { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "http_listener")]
        public sealed class http_listener : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "frontend_ip_configuration_name", @out: false, min: 1, max: 1)]
            public string @FrontendIpConfigurationName { get; }

            [nterraform.TerraformProperty(name: "frontend_port_name", @out: false, min: 1, max: 1)]
            public string @FrontendPortName { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
            public string @Protocol { get; }

            [nterraform.TerraformProperty(name: "frontend_ip_configuration_id", @out: true, min: 0, max: 1)]
            public string @FrontendIpConfigurationId { get; }

            [nterraform.TerraformProperty(name: "frontend_port_id", @out: true, min: 0, max: 1)]
            public string @FrontendPortId { get; }

            [nterraform.TerraformProperty(name: "host_name", @out: false, min: 0, max: 1)]
            public string @HostName { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "require_sni", @out: false, min: 0, max: 1)]
            public bool? @RequireSni { get; }

            [nterraform.TerraformProperty(name: "ssl_certificate_id", @out: true, min: 0, max: 1)]
            public string @SslCertificateId { get; }

            [nterraform.TerraformProperty(name: "ssl_certificate_name", @out: false, min: 0, max: 1)]
            public string @SslCertificateName { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "waf_configuration")]
        public sealed class waf_configuration : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.TerraformProperty(name: "firewall_mode", @out: false, min: 1, max: 1)]
            public string @FirewallMode { get; }

            [nterraform.TerraformProperty(name: "rule_set_version", @out: false, min: 1, max: 1)]
            public string @RuleSetVersion { get; }

            [nterraform.TerraformProperty(name: "rule_set_type", @out: false, min: 0, max: 1)]
            public string @RuleSetType { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "request_routing_rule")]
        public sealed class request_routing_rule : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "http_listener_name", @out: false, min: 1, max: 1)]
            public string @HttpListenerName { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "rule_type", @out: false, min: 1, max: 1)]
            public string @RuleType { get; }

            [nterraform.TerraformProperty(name: "backend_address_pool_id", @out: true, min: 0, max: 1)]
            public string @BackendAddressPoolId { get; }

            [nterraform.TerraformProperty(name: "backend_address_pool_name", @out: false, min: 0, max: 1)]
            public string @BackendAddressPoolName { get; }

            [nterraform.TerraformProperty(name: "backend_http_settings_id", @out: true, min: 0, max: 1)]
            public string @BackendHttpSettingsId { get; }

            [nterraform.TerraformProperty(name: "backend_http_settings_name", @out: false, min: 0, max: 1)]
            public string @BackendHttpSettingsName { get; }

            [nterraform.TerraformProperty(name: "http_listener_id", @out: true, min: 0, max: 1)]
            public string @HttpListenerId { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "url_path_map_id", @out: true, min: 0, max: 1)]
            public string @UrlPathMapId { get; }

            [nterraform.TerraformProperty(name: "url_path_map_name", @out: false, min: 0, max: 1)]
            public string @UrlPathMapName { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "backend_address_pool")]
        public sealed class backend_address_pool : nterraform.structure
        {
            public backend_address_pool(string @name,
                                        string[] @fqdnList = null,
                                        string[] @ipAddressList = null)
            {
                @Name = @name;
                @FqdnList = @fqdnList;
                @IpAddressList = @ipAddressList;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "fqdn_list", @out: false, min: 0, max: 1)]
            public string[] @FqdnList { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "ip_address_list", @out: false, min: 0, max: 1)]
            public string[] @IpAddressList { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "backend_address_pool", @out: false, min: 1, max: 0)]
        public backend_address_pool[] @BackendAddressPool { get; }

        [nterraform.TerraformProperty(name: "backend_http_settings", @out: false, min: 1, max: 0)]
        public backend_http_settings[] @BackendHttpSettings { get; }

        [nterraform.TerraformProperty(name: "frontend_ip_configuration", @out: false, min: 1, max: 0)]
        public frontend_ip_configuration[] @FrontendIpConfiguration { get; }

        [nterraform.TerraformProperty(name: "frontend_port", @out: false, min: 1, max: 0)]
        public frontend_port[] @FrontendPort { get; }

        [nterraform.TerraformProperty(name: "gateway_ip_configuration", @out: false, min: 1, max: 0)]
        public gateway_ip_configuration[] @GatewayIpConfiguration { get; }

        [nterraform.TerraformProperty(name: "http_listener", @out: false, min: 1, max: 0)]
        public http_listener[] @HttpListener { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "request_routing_rule", @out: false, min: 1, max: 0)]
        public request_routing_rule[] @RequestRoutingRule { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [nterraform.TerraformProperty(name: "authentication_certificate", @out: false, min: 0, max: 0)]
        public authentication_certificate[] @AuthenticationCertificate { get; }

        [nterraform.TerraformProperty(name: "disabled_ssl_protocols", @out: false, min: 0, max: 1)]
        public string[] @DisabledSslProtocols { get; }

        [nterraform.TerraformProperty(name: "probe", @out: false, min: 0, max: 0)]
        public probe[] @Probe { get; }

        [nterraform.TerraformProperty(name: "ssl_certificate", @out: false, min: 0, max: 0)]
        public ssl_certificate[] @SslCertificate { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "url_path_map", @out: false, min: 0, max: 0)]
        public url_path_map[] @UrlPathMap { get; }

        [nterraform.TerraformProperty(name: "waf_configuration", @out: false, min: 0, max: 1)]
        public waf_configuration[] @WafConfiguration { get; }
    }

}
