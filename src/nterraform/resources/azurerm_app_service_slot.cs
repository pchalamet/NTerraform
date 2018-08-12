using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_app_service_slot")]
    public sealed class azurerm_app_service_slot : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "connection_string")]
        public sealed class connection_string : nterraform.Core.structure
        {
            public connection_string(string @name,
                                     string @type,
                                     string @value)
            {
                @Name = @name;
                @Type = @type;
                @Value = @value;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "identity")]
        public sealed class identity : nterraform.Core.structure
        {
            public identity(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public string @PrincipalId { get; }

            [nterraform.Core.TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
            public string @TenantId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "site_config")]
        public sealed class site_config : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ip_restriction")]
            public sealed class ip_restriction : nterraform.Core.structure
            {
                public ip_restriction(string @ipAddress,
                                      string @subnetMask = null)
                {
                    @IpAddress = @ipAddress;
                    @SubnetMask = @subnetMask;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "ip_address", @out: false, min: 1, max: 1)]
                public string @IpAddress { get; }

                [nterraform.Core.TerraformProperty(name: "subnet_mask", @out: false, min: 0, max: 1)]
                public string @SubnetMask { get; }
            }

            public site_config(bool? @alwaysOn = null,
                               string[] @defaultDocuments = null,
                               string @dotnetFrameworkVersion = null,
                               bool? @http2Enabled = null,
                               ip_restriction[] @ipRestriction = null,
                               string @javaContainer = null,
                               string @javaContainerVersion = null,
                               string @javaVersion = null,
                               string @phpVersion = null,
                               string @pythonVersion = null,
                               bool? @remoteDebuggingEnabled = null,
                               string @scmType = null)
            {
                @AlwaysOn = @alwaysOn;
                @DefaultDocuments = @defaultDocuments;
                @DotnetFrameworkVersion = @dotnetFrameworkVersion;
                @Http2Enabled = @http2Enabled;
                @IpRestriction = @ipRestriction;
                @JavaContainer = @javaContainer;
                @JavaContainerVersion = @javaContainerVersion;
                @JavaVersion = @javaVersion;
                @PhpVersion = @phpVersion;
                @PythonVersion = @pythonVersion;
                @RemoteDebuggingEnabled = @remoteDebuggingEnabled;
                @ScmType = @scmType;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "always_on", @out: false, min: 0, max: 1)]
            public bool? @AlwaysOn { get; }

            [nterraform.Core.TerraformProperty(name: "default_documents", @out: false, min: 0, max: 1)]
            public string[] @DefaultDocuments { get; }

            [nterraform.Core.TerraformProperty(name: "dotnet_framework_version", @out: false, min: 0, max: 1)]
            public string @DotnetFrameworkVersion { get; }

            [nterraform.Core.TerraformProperty(name: "ftps_state", @out: true, min: 0, max: 1)]
            public string @FtpsState { get; }

            [nterraform.Core.TerraformProperty(name: "http2_enabled", @out: false, min: 0, max: 1)]
            public bool? @Http2Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "ip_restriction", @out: false, min: 0, max: 0)]
            public ip_restriction[] @IpRestriction { get; }

            [nterraform.Core.TerraformProperty(name: "java_container", @out: false, min: 0, max: 1)]
            public string @JavaContainer { get; }

            [nterraform.Core.TerraformProperty(name: "java_container_version", @out: false, min: 0, max: 1)]
            public string @JavaContainerVersion { get; }

            [nterraform.Core.TerraformProperty(name: "java_version", @out: false, min: 0, max: 1)]
            public string @JavaVersion { get; }

            [nterraform.Core.TerraformProperty(name: "linux_fx_version", @out: true, min: 0, max: 1)]
            public string @LinuxFxVersion { get; }

            [nterraform.Core.TerraformProperty(name: "local_mysql_enabled", @out: true, min: 0, max: 1)]
            public bool? @LocalMysqlEnabled { get; }

            [nterraform.Core.TerraformProperty(name: "managed_pipeline_mode", @out: true, min: 0, max: 1)]
            public string @ManagedPipelineMode { get; }

            [nterraform.Core.TerraformProperty(name: "min_tls_version", @out: true, min: 0, max: 1)]
            public string @MinTlsVersion { get; }

            [nterraform.Core.TerraformProperty(name: "php_version", @out: false, min: 0, max: 1)]
            public string @PhpVersion { get; }

            [nterraform.Core.TerraformProperty(name: "python_version", @out: false, min: 0, max: 1)]
            public string @PythonVersion { get; }

            [nterraform.Core.TerraformProperty(name: "remote_debugging_enabled", @out: false, min: 0, max: 1)]
            public bool? @RemoteDebuggingEnabled { get; }

            [nterraform.Core.TerraformProperty(name: "remote_debugging_version", @out: true, min: 0, max: 1)]
            public string @RemoteDebuggingVersion { get; }

            [nterraform.Core.TerraformProperty(name: "scm_type", @out: false, min: 0, max: 1)]
            public string @ScmType { get; }

            [nterraform.Core.TerraformProperty(name: "use_32_bit_worker_process", @out: true, min: 0, max: 1)]
            public bool? @Use32BitWorkerProcess { get; }

            [nterraform.Core.TerraformProperty(name: "websockets_enabled", @out: true, min: 0, max: 1)]
            public bool? @WebsocketsEnabled { get; }
        }

        public azurerm_app_service_slot(string @appServiceName,
                                        string @appServicePlanId,
                                        string @location,
                                        string @name,
                                        string @resourceGroupName,
                                        connection_string[] @connectionString = null,
                                        bool? @enabled = null,
                                        bool? @httpsOnly = null,
                                        identity[] @identity = null,
                                        site_config[] @siteConfig = null)
        {
            @AppServiceName = @appServiceName;
            @AppServicePlanId = @appServicePlanId;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ConnectionString = @connectionString;
            @Enabled = @enabled;
            @HttpsOnly = @httpsOnly;
            @Identity = @identity;
            @SiteConfig = @siteConfig;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "app_service_name", @out: false, min: 1, max: 1)]
        public string @AppServiceName { get; }

        [nterraform.Core.TerraformProperty(name: "app_service_plan_id", @out: false, min: 1, max: 1)]
        public string @AppServicePlanId { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "app_settings", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @AppSettings { get; }

        [nterraform.Core.TerraformProperty(name: "client_affinity_enabled", @out: true, min: 0, max: 1)]
        public bool? @ClientAffinityEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "connection_string", @out: false, min: 0, max: 0)]
        public connection_string[] @ConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "default_site_hostname", @out: true, min: 0, max: 1)]
        public string @DefaultSiteHostname { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "https_only", @out: false, min: 0, max: 1)]
        public bool? @HttpsOnly { get; }

        [nterraform.Core.TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public identity[] @Identity { get; }

        [nterraform.Core.TerraformProperty(name: "site_config", @out: false, min: 0, max: 1)]
        public site_config[] @SiteConfig { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
