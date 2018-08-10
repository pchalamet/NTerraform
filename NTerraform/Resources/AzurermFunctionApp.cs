using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_function_app : NTerraform.resource
    {
        public class connection_string
        {
            public connection_string(string @name,
                                     string @type,
                                     string @value)
            {
                @Name = @name;
                @Type = @type;
                @Value = @value;
            }

            public string @Name { get; }
            public string @Type { get; }
            public string @Value { get; }
        }

        public class site_config
        {
            public site_config(bool? @alwaysOn = null,
                               bool? @use32BitWorkerProcess = null,
                               bool? @websocketsEnabled = null)
            {
                @AlwaysOn = @alwaysOn;
                @Use32BitWorkerProcess = @use32BitWorkerProcess;
                @WebsocketsEnabled = @websocketsEnabled;
            }

            public bool? @AlwaysOn { get; }
            public bool? @Use32BitWorkerProcess { get; }
            public bool? @WebsocketsEnabled { get; }
        }

        public class identity
        {
            public identity(string @type)
            {
                @Type = @type;
            }

            public string @Type { get; }
            public string @PrincipalId { get; }
            public string @TenantId { get; }
        }

        public class site_credential
        {
            public site_credential()
            {
            }

            public string @Password { get; }
            public string @Username { get; }
        }

        public azurerm_function_app(string @appServicePlanId,
                                    string @location,
                                    string @name,
                                    string @resourceGroupName,
                                    string @storageConnectionString,
                                    Dictionary<string,string> @appSettings = null,
                                    List<connection_string> @connectionString = null,
                                    bool? @enabled = null,
                                    bool? @httpsOnly = null,
                                    List<identity> @identity = null,
                                    List<site_config> @siteConfig = null,
                                    List<site_credential> @siteCredential = null,
                                    string @version = null)
        {
            @AppServicePlanId = @appServicePlanId;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageConnectionString = @storageConnectionString;
            @AppSettings = @appSettings;
            @ConnectionString = @connectionString;
            @Enabled = @enabled;
            @HttpsOnly = @httpsOnly;
            @Identity = @identity;
            @SiteConfig = @siteConfig;
            @SiteCredential = @siteCredential;
            @Version = @version;
        }

        public string @AppServicePlanId { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @StorageConnectionString { get; }
        public Dictionary<string,string> @AppSettings { get; }
        public bool? @ClientAffinityEnabled { get; }
        public List<connection_string> @ConnectionString { get; }
        public string @DefaultHostname { get; }
        public bool? @Enabled { get; }
        public bool? @HttpsOnly { get; }
        public List<identity> @Identity { get; }
        public string @OutboundIpAddresses { get; }
        public List<site_config> @SiteConfig { get; }
        public List<site_credential> @SiteCredential { get; }
        public Dictionary<string,string> @Tags { get; }
        public string @Version { get; }
    }

}
