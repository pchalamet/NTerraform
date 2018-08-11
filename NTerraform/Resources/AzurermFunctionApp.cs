using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_function_app")]
    public sealed class azurerm_function_app : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "connection_string")]
        public sealed class connection_string: NTerraform.structure
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

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
            public string @Value { get; }
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

        [TerraformStructure(category: "", typeName: "identity")]
        public sealed class identity: NTerraform.structure
        {
            public identity(string @type)
            {
                @Type = @type;
                base._validate_();
            }

            [TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public string @PrincipalId { get; }

            [TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
            public string @TenantId { get; }
        }

        [TerraformStructure(category: "", typeName: "site_config")]
        public sealed class site_config: NTerraform.structure
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

            [TerraformProperty(name: "always_on", @out: false, min: 0, max: 1)]
            public bool? @AlwaysOn { get; }

            [TerraformProperty(name: "use_32_bit_worker_process", @out: false, min: 0, max: 1)]
            public bool? @Use32BitWorkerProcess { get; }

            [TerraformProperty(name: "websockets_enabled", @out: false, min: 0, max: 1)]
            public bool? @WebsocketsEnabled { get; }
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

        [TerraformProperty(name: "app_service_plan_id", @out: false, min: 1, max: 1)]
        public string @AppServicePlanId { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "storage_connection_string", @out: false, min: 1, max: 1)]
        public string @StorageConnectionString { get; }

        [TerraformProperty(name: "app_settings", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @AppSettings { get; }

        [TerraformProperty(name: "client_affinity_enabled", @out: true, min: 0, max: 1)]
        public bool? @ClientAffinityEnabled { get; }

        [TerraformProperty(name: "connection_string", @out: false, min: 0, max: 0)]
        public connection_string[] @ConnectionString { get; }

        [TerraformProperty(name: "default_hostname", @out: true, min: 0, max: 1)]
        public string @DefaultHostname { get; }

        [TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public bool? @Enabled { get; }

        [TerraformProperty(name: "https_only", @out: false, min: 0, max: 1)]
        public bool? @HttpsOnly { get; }

        [TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public identity[] @Identity { get; }

        [TerraformProperty(name: "outbound_ip_addresses", @out: true, min: 0, max: 1)]
        public string @OutboundIpAddresses { get; }

        [TerraformProperty(name: "site_config", @out: false, min: 0, max: 1)]
        public site_config[] @SiteConfig { get; }

        [TerraformProperty(name: "site_credential", @out: false, min: 0, max: 1)]
        public site_credential[] @SiteCredential { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
        public string @Version { get; }
    }

}
