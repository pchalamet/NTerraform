using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_function_app")]
    public sealed class azurerm_function_app : nterraform.resource
    {
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

        [nterraform.TerraformStructure(category: "resource", typeName: "site_config")]
        public sealed class site_config : nterraform.structure
        {
            public site_config(bool? @alwaysOn = null,
                               bool? @use32BitWorkerProcess = null,
                               bool? @websocketsEnabled = null)
            {
                @AlwaysOn = @alwaysOn;
                @Use32BitWorkerProcess = @use32BitWorkerProcess;
                @WebsocketsEnabled = @websocketsEnabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "always_on", @out: false, min: 0, max: 1)]
            public bool? @AlwaysOn { get; }

            [nterraform.TerraformProperty(name: "use_32_bit_worker_process", @out: false, min: 0, max: 1)]
            public bool? @Use32BitWorkerProcess { get; }

            [nterraform.TerraformProperty(name: "websockets_enabled", @out: false, min: 0, max: 1)]
            public bool? @WebsocketsEnabled { get; }
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

        public azurerm_function_app(string @appServicePlanId,
                                    string @location,
                                    string @name,
                                    string @resourceGroupName,
                                    string @storageConnectionString,
                                    Dictionary<string,string> @appSettings = null,
                                    connection_string[] @connectionString = null,
                                    bool? @enabled = null,
                                    bool? @httpsOnly = null,
                                    identity[] @identity = null,
                                    site_config[] @siteConfig = null,
                                    site_credential[] @siteCredential = null,
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

        [nterraform.TerraformProperty(name: "storage_connection_string", @out: false, min: 1, max: 1)]
        public string @StorageConnectionString { get; }

        [nterraform.TerraformProperty(name: "app_settings", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @AppSettings { get; }

        [nterraform.TerraformProperty(name: "client_affinity_enabled", @out: true, min: 0, max: 1)]
        public bool? @ClientAffinityEnabled { get; }

        [nterraform.TerraformProperty(name: "connection_string", @out: false, min: 0, max: 0)]
        public connection_string[] @ConnectionString { get; }

        [nterraform.TerraformProperty(name: "default_hostname", @out: true, min: 0, max: 1)]
        public string @DefaultHostname { get; }

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

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
        public string @Version { get; }
    }

}
