using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_function_app")]
    public sealed class azurerm_function_app : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "site_credential")]
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
            public FSharpOption<string> @PrincipalId { get; }

            [nterraform.Core.TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @TenantId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "site_config")]
        public sealed class site_config : nterraform.Core.structure
        {
            public site_config(FSharpOption<bool> @alwaysOn = null,
                               FSharpOption<bool> @use32BitWorkerProcess = null,
                               FSharpOption<bool> @websocketsEnabled = null)
            {
                @AlwaysOn = @alwaysOn;
                @Use32BitWorkerProcess = @use32BitWorkerProcess;
                @WebsocketsEnabled = @websocketsEnabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "always_on", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @AlwaysOn { get; }

            [nterraform.Core.TerraformProperty(name: "use_32_bit_worker_process", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @Use32BitWorkerProcess { get; }

            [nterraform.Core.TerraformProperty(name: "websockets_enabled", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @WebsocketsEnabled { get; }
        }

        public azurerm_function_app(string @appServicePlanId,
                                    string @location,
                                    string @name,
                                    string @resourceGroupName,
                                    string @storageConnectionString,
                                    FSharpOption<FSharpMap<string,string>> @appSettings = null,
                                    FSharpOption<FSharpList<connection_string>> @connectionString = null,
                                    FSharpOption<bool> @enabled = null,
                                    FSharpOption<bool> @httpsOnly = null,
                                    FSharpOption<FSharpList<identity>> @identity = null,
                                    FSharpOption<FSharpList<site_config>> @siteConfig = null,
                                    FSharpOption<FSharpList<site_credential>> @siteCredential = null,
                                    FSharpOption<string> @version = null)
        {
            @AppServicePlanId = @appServicePlanId;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StorageConnectionString = @storageConnectionString;
            @AppSettings = @appSettings ?? MapModule.Empty<string,string>();
            @ConnectionString = @connectionString ?? FSharpList<connection_string>.Empty;
            @Enabled = @enabled;
            @HttpsOnly = @httpsOnly;
            @Identity = @identity ?? FSharpList<identity>.Empty;
            @SiteConfig = @siteConfig ?? FSharpList<site_config>.Empty;
            @SiteCredential = @siteCredential ?? FSharpList<site_credential>.Empty;
            @Version = @version;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "app_service_plan_id", @out: false, min: 1, max: 1)]
        public string @AppServicePlanId { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "storage_connection_string", @out: false, min: 1, max: 1)]
        public string @StorageConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "app_settings", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @AppSettings { get; }

        [nterraform.Core.TerraformProperty(name: "client_affinity_enabled", @out: true, min: 0, max: 1)]
        public FSharpOption<bool> @ClientAffinityEnabled { get; }

        [nterraform.Core.TerraformProperty(name: "connection_string", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<connection_string>> @ConnectionString { get; }

        [nterraform.Core.TerraformProperty(name: "default_hostname", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultHostname { get; }

        [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @Enabled { get; }

        [nterraform.Core.TerraformProperty(name: "https_only", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @HttpsOnly { get; }

        [nterraform.Core.TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<identity>> @Identity { get; }

        [nterraform.Core.TerraformProperty(name: "outbound_ip_addresses", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @OutboundIpAddresses { get; }

        [nterraform.Core.TerraformProperty(name: "site_config", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<site_config>> @SiteConfig { get; }

        [nterraform.Core.TerraformProperty(name: "site_credential", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<site_credential>> @SiteCredential { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Version { get; }
    }

}
