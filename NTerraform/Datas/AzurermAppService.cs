using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_app_service")]
    public sealed class azurerm_app_service : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "source_control")]
        public sealed class source_control: NTerraform.structure
        {
            public source_control()
            {
                base._validate_();
            }

            [TerraformProperty(name: "branch", @out: true, min: 0, max: 1)]
            public string @Branch { get; }

            [TerraformProperty(name: "repo_url", @out: true, min: 0, max: 1)]
            public string @RepoUrl { get; }
        }

        [TerraformStructure(category: "", typeName: "connection_string")]
        public sealed class connection_string: NTerraform.structure
        {
            public connection_string()
            {
                base._validate_();
            }

            [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
            public string @Type { get; }

            [TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
            public string @Value { get; }
        }

        [TerraformStructure(category: "", typeName: "site_config")]
        public sealed class site_config: NTerraform.structure
        {
            [TerraformStructure(category: "", typeName: "ip_restriction")]
            public sealed class ip_restriction: NTerraform.structure
            {
                public ip_restriction(string @ipAddress,
                                      string @subnetMask = null)
                {
                    @IpAddress = @ipAddress;
                    @SubnetMask = @subnetMask;
                    base._validate_();
                }

                [TerraformProperty(name: "ip_address", @out: false, min: 1, max: 1)]
                public string @IpAddress { get; }

                [TerraformProperty(name: "subnet_mask", @out: false, min: 0, max: 1)]
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

            [TerraformProperty(name: "always_on", @out: false, min: 0, max: 1)]
            public bool? @AlwaysOn { get; }

            [TerraformProperty(name: "default_documents", @out: false, min: 0, max: 1)]
            public string[] @DefaultDocuments { get; }

            [TerraformProperty(name: "dotnet_framework_version", @out: false, min: 0, max: 1)]
            public string @DotnetFrameworkVersion { get; }

            [TerraformProperty(name: "ftps_state", @out: true, min: 0, max: 1)]
            public string @FtpsState { get; }

            [TerraformProperty(name: "http2_enabled", @out: false, min: 0, max: 1)]
            public bool? @Http2Enabled { get; }

            [TerraformProperty(name: "ip_restriction", @out: false, min: 0, max: 0)]
            public ip_restriction[] @IpRestriction { get; }

            [TerraformProperty(name: "java_container", @out: false, min: 0, max: 1)]
            public string @JavaContainer { get; }

            [TerraformProperty(name: "java_container_version", @out: false, min: 0, max: 1)]
            public string @JavaContainerVersion { get; }

            [TerraformProperty(name: "java_version", @out: false, min: 0, max: 1)]
            public string @JavaVersion { get; }

            [TerraformProperty(name: "linux_fx_version", @out: true, min: 0, max: 1)]
            public string @LinuxFxVersion { get; }

            [TerraformProperty(name: "local_mysql_enabled", @out: true, min: 0, max: 1)]
            public bool? @LocalMysqlEnabled { get; }

            [TerraformProperty(name: "managed_pipeline_mode", @out: true, min: 0, max: 1)]
            public string @ManagedPipelineMode { get; }

            [TerraformProperty(name: "min_tls_version", @out: true, min: 0, max: 1)]
            public string @MinTlsVersion { get; }

            [TerraformProperty(name: "php_version", @out: false, min: 0, max: 1)]
            public string @PhpVersion { get; }

            [TerraformProperty(name: "python_version", @out: false, min: 0, max: 1)]
            public string @PythonVersion { get; }

            [TerraformProperty(name: "remote_debugging_enabled", @out: false, min: 0, max: 1)]
            public bool? @RemoteDebuggingEnabled { get; }

            [TerraformProperty(name: "remote_debugging_version", @out: true, min: 0, max: 1)]
            public string @RemoteDebuggingVersion { get; }

            [TerraformProperty(name: "scm_type", @out: false, min: 0, max: 1)]
            public string @ScmType { get; }

            [TerraformProperty(name: "use_32_bit_worker_process", @out: true, min: 0, max: 1)]
            public bool? @Use32BitWorkerProcess { get; }

            [TerraformProperty(name: "websockets_enabled", @out: true, min: 0, max: 1)]
            public bool? @WebsocketsEnabled { get; }
        }

        [TerraformStructure(category: "", typeName: "site_credential")]
        public sealed class site_credential: NTerraform.structure
        {
            public site_credential()
            {
                base._validate_();
            }

            [TerraformProperty(name: "password", @out: true, min: 0, max: 1)]
            public string @Password { get; }

            [TerraformProperty(name: "username", @out: true, min: 0, max: 1)]
            public string @Username { get; }
        }

        public azurerm_app_service(string @name,
                                   string @resourceGroupName,
                                   connection_string[] @connectionString = null,
                                   site_config[] @siteConfig = null,
                                   site_credential[] @siteCredential = null,
                                   source_control[] @sourceControl = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ConnectionString = @connectionString;
            @SiteConfig = @siteConfig;
            @SiteCredential = @siteCredential;
            @SourceControl = @sourceControl;
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "app_service_plan_id", @out: true, min: 0, max: 1)]
        public string @AppServicePlanId { get; }

        [TerraformProperty(name: "app_settings", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @AppSettings { get; }

        [TerraformProperty(name: "client_affinity_enabled", @out: true, min: 0, max: 1)]
        public bool? @ClientAffinityEnabled { get; }

        [TerraformProperty(name: "connection_string", @out: false, min: 0, max: 0)]
        public connection_string[] @ConnectionString { get; }

        [TerraformProperty(name: "default_site_hostname", @out: true, min: 0, max: 1)]
        public string @DefaultSiteHostname { get; }

        [TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [TerraformProperty(name: "https_only", @out: true, min: 0, max: 1)]
        public bool? @HttpsOnly { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "outbound_ip_addresses", @out: true, min: 0, max: 1)]
        public string @OutboundIpAddresses { get; }

        [TerraformProperty(name: "site_config", @out: false, min: 0, max: 1)]
        public site_config[] @SiteConfig { get; }

        [TerraformProperty(name: "site_credential", @out: false, min: 0, max: 0)]
        public site_credential[] @SiteCredential { get; }

        [TerraformProperty(name: "source_control", @out: false, min: 0, max: 0)]
        public source_control[] @SourceControl { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
