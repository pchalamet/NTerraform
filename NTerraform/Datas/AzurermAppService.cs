using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_app_service : NTerraform.data
    {
        public sealed class site_config
        {
            public sealed class ip_restriction
            {
                public ip_restriction(string @ipAddress,
                                      string @subnetMask = null)
                {
                    @IpAddress = @ipAddress;
                    @SubnetMask = @subnetMask;
                }

                public string @IpAddress { get; }
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
            }

            public bool? @AlwaysOn { get; }
            public string[] @DefaultDocuments { get; }
            public string @DotnetFrameworkVersion { get; }
            public string @FtpsState { get; }
            public bool? @Http2Enabled { get; }
            public ip_restriction[] @IpRestriction { get; }
            public string @JavaContainer { get; }
            public string @JavaContainerVersion { get; }
            public string @JavaVersion { get; }
            public string @LinuxFxVersion { get; }
            public bool? @LocalMysqlEnabled { get; }
            public string @ManagedPipelineMode { get; }
            public string @MinTlsVersion { get; }
            public string @PhpVersion { get; }
            public string @PythonVersion { get; }
            public bool? @RemoteDebuggingEnabled { get; }
            public string @RemoteDebuggingVersion { get; }
            public string @ScmType { get; }
            public bool? @Use32BitWorkerProcess { get; }
            public bool? @WebsocketsEnabled { get; }
        }

        public sealed class source_control
        {
            public source_control()
            {
            }

            public string @Branch { get; }
            public string @RepoUrl { get; }
        }

        public sealed class connection_string
        {
            public connection_string()
            {
            }

            public string @Name { get; }
            public string @Type { get; }
            public string @Value { get; }
        }

        public sealed class site_credential
        {
            public site_credential()
            {
            }

            public string @Password { get; }
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
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @AppServicePlanId { get; }
        public Dictionary<string,string> @AppSettings { get; }
        public bool? @ClientAffinityEnabled { get; }
        public connection_string[] @ConnectionString { get; }
        public string @DefaultSiteHostname { get; }
        public bool? @Enabled { get; }
        public bool? @HttpsOnly { get; }
        public string @Location { get; }
        public string @OutboundIpAddresses { get; }
        public site_config[] @SiteConfig { get; }
        public site_credential[] @SiteCredential { get; }
        public source_control[] @SourceControl { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
