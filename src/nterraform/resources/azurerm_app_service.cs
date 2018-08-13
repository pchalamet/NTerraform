using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_app_service")]
    public sealed class azurerm_app_service : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "source_control")]
        public sealed class source_control : nterraform.structure
        {
            public source_control()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "branch", @out: true, min: 0, max: 1)]
            public string @Branch { get; }

            [nterraform.TerraformProperty(name: "repo_url", @out: true, min: 0, max: 1)]
            public string @RepoUrl { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "site_config")]
        public sealed class site_config : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "ip_restriction")]
            public sealed class ip_restriction : nterraform.structure
            {
                public ip_restriction(string @ipAddress,
                                      string @subnetMask = null)
                {
                    @IpAddress = @ipAddress;
                    @SubnetMask = @subnetMask;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "ip_address", @out: false, min: 1, max: 1)]
                public string @IpAddress { get; }

                [nterraform.TerraformProperty(name: "subnet_mask", @out: false, min: 0, max: 1)]
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

            [nterraform.TerraformProperty(name: "always_on", @out: false, min: 0, max: 1)]
            public bool? @AlwaysOn { get; }

            [nterraform.TerraformProperty(name: "default_documents", @out: false, min: 0, max: 1)]
            public string[] @DefaultDocuments { get; }

            [nterraform.TerraformProperty(name: "dotnet_framework_version", @out: false, min: 0, max: 1)]
            public string @DotnetFrameworkVersion { get; }

            [nterraform.TerraformProperty(name: "ftps_state", @out: true, min: 0, max: 1)]
            public string @FtpsState { get; }

            [nterraform.TerraformProperty(name: "http2_enabled", @out: false, min: 0, max: 1)]
            public bool? @Http2Enabled { get; }

            [nterraform.TerraformProperty(name: "ip_restriction", @out: false, min: 0, max: 0)]
            public ip_restriction[] @IpRestriction { get; }

            [nterraform.TerraformProperty(name: "java_container", @out: false, min: 0, max: 1)]
            public string @JavaContainer { get; }

            [nterraform.TerraformProperty(name: "java_container_version", @out: false, min: 0, max: 1)]
            public string @JavaContainerVersion { get; }

            [nterraform.TerraformProperty(name: "java_version", @out: false, min: 0, max: 1)]
            public string @JavaVersion { get; }

            [nterraform.TerraformProperty(name: "linux_fx_version", @out: true, min: 0, max: 1)]
            public string @LinuxFxVersion { get; }

            [nterraform.TerraformProperty(name: "local_mysql_enabled", @out: true, min: 0, max: 1)]
            public bool? @LocalMysqlEnabled { get; }

            [nterraform.TerraformProperty(name: "managed_pipeline_mode", @out: true, min: 0, max: 1)]
            public string @ManagedPipelineMode { get; }

            [nterraform.TerraformProperty(name: "min_tls_version", @out: true, min: 0, max: 1)]
            public string @MinTlsVersion { get; }

            [nterraform.TerraformProperty(name: "php_version", @out: false, min: 0, max: 1)]
            public string @PhpVersion { get; }

            [nterraform.TerraformProperty(name: "python_version", @out: false, min: 0, max: 1)]
            public string @PythonVersion { get; }

            [nterraform.TerraformProperty(name: "remote_debugging_enabled", @out: false, min: 0, max: 1)]
            public bool? @RemoteDebuggingEnabled { get; }

            [nterraform.TerraformProperty(name: "remote_debugging_version", @out: true, min: 0, max: 1)]
            public string @RemoteDebuggingVersion { get; }

            [nterraform.TerraformProperty(name: "scm_type", @out: false, min: 0, max: 1)]
            public string @ScmType { get; }

            [nterraform.TerraformProperty(name: "use_32_bit_worker_process", @out: true, min: 0, max: 1)]
            public bool? @Use32BitWorkerProcess { get; }

            [nterraform.TerraformProperty(name: "websockets_enabled", @out: true, min: 0, max: 1)]
            public bool? @WebsocketsEnabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "connection_string")]
        public sealed class connection_string : nterraform.structure
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

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "identity")]
        public sealed class identity : nterraform.structure
        {
            public identity(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public string @PrincipalId { get; }

            [nterraform.TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
            public string @TenantId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "site_credential")]
        public sealed class site_credential : nterraform.structure
        {
            public site_credential()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "password", @out: true, min: 0, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "username", @out: true, min: 0, max: 1)]
            public string @Username { get; }
        }

        public azurerm_app_service(string @appServicePlanId,
                                   string @location,
                                   string @name,
                                   string @resourceGroupName,
                                   connection_string[] @connectionString = null,
                                   bool? @enabled = null,
                                   bool? @httpsOnly = null,
                                   identity[] @identity = null,
                                   site_config[] @siteConfig = null,
                                   site_credential[] @siteCredential = null,
                                   source_control[] @sourceControl = null)
        {
            @AppServicePlanId = @appServicePlanId;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ConnectionString = @connectionString;
            @Enabled = @enabled;
            @HttpsOnly = @httpsOnly;
            @Identity = @identity;
            @SiteConfig = @siteConfig;
            @SiteCredential = @siteCredential;
            @SourceControl = @sourceControl;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "app_service_plan_id", @out: false, min: 1, max: 1)]
        public string @AppServicePlanId { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "app_settings", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @AppSettings { get; }

        [nterraform.TerraformProperty(name: "client_affinity_enabled", @out: true, min: 0, max: 1)]
        public bool? @ClientAffinityEnabled { get; }

        [nterraform.TerraformProperty(name: "connection_string", @out: false, min: 0, max: 0)]
        public connection_string[] @ConnectionString { get; }

        [nterraform.TerraformProperty(name: "default_site_hostname", @out: true, min: 0, max: 1)]
        public string @DefaultSiteHostname { get; }

        [nterraform.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [nterraform.TerraformProperty(name: "https_only", @out: false, min: 0, max: 1)]
        public bool? @HttpsOnly { get; }

        [nterraform.TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public identity[] @Identity { get; }

        [nterraform.TerraformProperty(name: "outbound_ip_addresses", @out: true, min: 0, max: 1)]
        public string @OutboundIpAddresses { get; }

        [nterraform.TerraformProperty(name: "site_config", @out: false, min: 0, max: 1)]
        public site_config[] @SiteConfig { get; }

        [nterraform.TerraformProperty(name: "site_credential", @out: false, min: 0, max: 1)]
        public site_credential[] @SiteCredential { get; }

        [nterraform.TerraformProperty(name: "source_control", @out: false, min: 0, max: 1)]
        public source_control[] @SourceControl { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
