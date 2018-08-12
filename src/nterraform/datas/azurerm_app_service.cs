using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_app_service")]
    public sealed class azurerm_app_service : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "source_control")]
        public sealed class source_control : nterraform.Core.structure
        {
            public source_control()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "branch", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Branch { get; }

            [nterraform.Core.TerraformProperty(name: "repo_url", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @RepoUrl { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "connection_string")]
        public sealed class connection_string : nterraform.Core.structure
        {
            public connection_string()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Name { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Type { get; }

            [nterraform.Core.TerraformProperty(name: "value", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Value { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "site_credential")]
        public sealed class site_credential : nterraform.Core.structure
        {
            public site_credential()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "password", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Password { get; }

            [nterraform.Core.TerraformProperty(name: "username", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Username { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "site_config")]
        public sealed class site_config : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "data", typeName: "ip_restriction")]
            public sealed class ip_restriction : nterraform.Core.structure
            {
                public ip_restriction(string @ipAddress,
                                      FSharpOption<string> @subnetMask = null)
                {
                    @IpAddress = @ipAddress;
                    @SubnetMask = @subnetMask;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "ip_address", @out: false, min: 1, max: 1)]
                public string @IpAddress { get; }

                [nterraform.Core.TerraformProperty(name: "subnet_mask", @out: false, min: 0, max: 1)]
                public FSharpOption<string> @SubnetMask { get; }
            }

            public site_config(FSharpOption<bool> @alwaysOn = null,
                               FSharpOption<FSharpList<string>> @defaultDocuments = null,
                               FSharpOption<string> @dotnetFrameworkVersion = null,
                               FSharpOption<bool> @http2Enabled = null,
                               FSharpOption<FSharpList<ip_restriction>> @ipRestriction = null,
                               FSharpOption<string> @javaContainer = null,
                               FSharpOption<string> @javaContainerVersion = null,
                               FSharpOption<string> @javaVersion = null,
                               FSharpOption<string> @phpVersion = null,
                               FSharpOption<string> @pythonVersion = null,
                               FSharpOption<bool> @remoteDebuggingEnabled = null,
                               FSharpOption<string> @scmType = null)
            {
                @AlwaysOn = @alwaysOn;
                @DefaultDocuments = @defaultDocuments ?? FSharpList<string>.Empty;
                @DotnetFrameworkVersion = @dotnetFrameworkVersion;
                @Http2Enabled = @http2Enabled;
                @IpRestriction = @ipRestriction ?? FSharpList<ip_restriction>.Empty;
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
            public FSharpOption<bool> @AlwaysOn { get; }

            [nterraform.Core.TerraformProperty(name: "default_documents", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @DefaultDocuments { get; }

            [nterraform.Core.TerraformProperty(name: "dotnet_framework_version", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @DotnetFrameworkVersion { get; }

            [nterraform.Core.TerraformProperty(name: "ftps_state", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @FtpsState { get; }

            [nterraform.Core.TerraformProperty(name: "http2_enabled", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @Http2Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "ip_restriction", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpList<ip_restriction>> @IpRestriction { get; }

            [nterraform.Core.TerraformProperty(name: "java_container", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @JavaContainer { get; }

            [nterraform.Core.TerraformProperty(name: "java_container_version", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @JavaContainerVersion { get; }

            [nterraform.Core.TerraformProperty(name: "java_version", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @JavaVersion { get; }

            [nterraform.Core.TerraformProperty(name: "linux_fx_version", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @LinuxFxVersion { get; }

            [nterraform.Core.TerraformProperty(name: "local_mysql_enabled", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @LocalMysqlEnabled { get; }

            [nterraform.Core.TerraformProperty(name: "managed_pipeline_mode", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ManagedPipelineMode { get; }

            [nterraform.Core.TerraformProperty(name: "min_tls_version", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @MinTlsVersion { get; }

            [nterraform.Core.TerraformProperty(name: "php_version", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @PhpVersion { get; }

            [nterraform.Core.TerraformProperty(name: "python_version", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @PythonVersion { get; }

            [nterraform.Core.TerraformProperty(name: "remote_debugging_enabled", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @RemoteDebuggingEnabled { get; }

            [nterraform.Core.TerraformProperty(name: "remote_debugging_version", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @RemoteDebuggingVersion { get; }

            [nterraform.Core.TerraformProperty(name: "scm_type", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @ScmType { get; }

            [nterraform.Core.TerraformProperty(name: "use_32_bit_worker_process", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @Use32BitWorkerProcess { get; }

            [nterraform.Core.TerraformProperty(name: "websockets_enabled", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @WebsocketsEnabled { get; }
        }

        public azurerm_app_service(string @name,
                                   string @resourceGroupName,
                                   FSharpOption<FSharpList<connection_string>> @connectionString = null,
                                   FSharpOption<FSharpList<site_config>> @siteConfig = null,
                                   FSharpOption<FSharpList<site_credential>> @siteCredential = null,
                                   FSharpOption<FSharpList<source_control>> @sourceControl = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ConnectionString = @connectionString ?? FSharpList<connection_string>.Empty;
            @SiteConfig = @siteConfig ?? FSharpList<site_config>.Empty;
            @SiteCredential = @siteCredential ?? FSharpList<site_credential>.Empty;
            @SourceControl = @sourceControl ?? FSharpList<source_control>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "app_service_plan_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AppServicePlanId { get; }

        [nterraform.Core.TerraformProperty(name: "app_settings", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @AppSettings { get; }

        [nterraform.Core.TerraformProperty(name: "client_affinity_enabled", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @ClientAffinityEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "connection_string", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<connection_string>> @ConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "default_site_hostname", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultSiteHostname { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "https_only", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @HttpsOnly { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "outbound_ip_addresses", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @OutboundIpAddresses { get; }

        [nterraform.Core.TerraformProperty(name: "site_config", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<site_config>> @SiteConfig { get; }

        [nterraform.Core.TerraformProperty(name: "site_credential", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<site_credential>> @SiteCredential { get; }

        [nterraform.Core.TerraformProperty(name: "source_control", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<source_control>> @SourceControl { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
