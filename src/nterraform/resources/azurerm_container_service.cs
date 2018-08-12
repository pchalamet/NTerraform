using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_container_service")]
    public sealed class azurerm_container_service : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "agent_pool_profile")]
        public sealed class agent_pool_profile : nterraform.Core.structure
        {
            public agent_pool_profile(string @dnsPrefix,
                                      string @name,
                                      string @vmSize,
                                      FSharpOption<int> @count = null)
            {
                @DnsPrefix = @dnsPrefix;
                @Name = @name;
                @VmSize = @vmSize;
                @Count = @count;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "dns_prefix", @out: false, min: 1, max: 1)]
            public string @DnsPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "vm_size", @out: false, min: 1, max: 1)]
            public string @VmSize { get; }

            [nterraform.Core.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @Count { get; }

            [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Fqdn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "master_profile")]
        public sealed class master_profile : nterraform.Core.structure
        {
            public master_profile(string @dnsPrefix,
                                  FSharpOption<int> @count = null)
            {
                @DnsPrefix = @dnsPrefix;
                @Count = @count;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "dns_prefix", @out: false, min: 1, max: 1)]
            public string @DnsPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @Count { get; }

            [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Fqdn { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "linux_profile")]
        public sealed class linux_profile : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ssh_key")]
            public sealed class ssh_key : nterraform.Core.structure
            {
                public ssh_key(string @keyData)
                {
                    @KeyData = @keyData;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "key_data", @out: false, min: 1, max: 1)]
                public string @KeyData { get; }
            }

            public linux_profile(string @adminUsername,
                                 FSharpList<ssh_key> @sshKey)
            {
                @AdminUsername = @adminUsername;
                @SshKey = @sshKey;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "admin_username", @out: false, min: 1, max: 1)]
            public string @AdminUsername { get; }

            [nterraform.Core.TerraformProperty(name: "ssh_key", @out: false, min: 1, max: 1)]
            public FSharpList<ssh_key> @SshKey { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "service_principal")]
        public sealed class service_principal : nterraform.Core.structure
        {
            public service_principal(string @clientId,
                                     string @clientSecret)
            {
                @ClientId = @clientId;
                @ClientSecret = @clientSecret;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "client_id", @out: false, min: 1, max: 1)]
            public string @ClientId { get; }

            [nterraform.Core.TerraformProperty(name: "client_secret", @out: false, min: 1, max: 1)]
            public string @ClientSecret { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "diagnostics_profile")]
        public sealed class diagnostics_profile : nterraform.Core.structure
        {
            public diagnostics_profile(bool @enabled)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.Core.TerraformProperty(name: "storage_uri", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @StorageUri { get; }
        }

        public azurerm_container_service(FSharpList<agent_pool_profile> @agentPoolProfile,
                                         FSharpList<diagnostics_profile> @diagnosticsProfile,
                                         FSharpList<linux_profile> @linuxProfile,
                                         string @location,
                                         FSharpList<master_profile> @masterProfile,
                                         string @name,
                                         string @orchestrationPlatform,
                                         string @resourceGroupName,
                                         FSharpOption<FSharpList<service_principal>> @servicePrincipal = null)
        {
            @AgentPoolProfile = @agentPoolProfile;
            @DiagnosticsProfile = @diagnosticsProfile;
            @LinuxProfile = @linuxProfile;
            @Location = @location;
            @MasterProfile = @masterProfile;
            @Name = @name;
            @OrchestrationPlatform = @orchestrationPlatform;
            @ResourceGroupName = @resourceGroupName;
            @ServicePrincipal = @servicePrincipal ?? FSharpList<service_principal>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "agent_pool_profile", @out: false, min: 1, max: 1)]
        public FSharpList<agent_pool_profile> @AgentPoolProfile { get; }

        [nterraform.Core.TerraformProperty(name: "diagnostics_profile", @out: false, min: 1, max: 1)]
        public FSharpList<diagnostics_profile> @DiagnosticsProfile { get; }

        [nterraform.Core.TerraformProperty(name: "linux_profile", @out: false, min: 1, max: 1)]
        public FSharpList<linux_profile> @LinuxProfile { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "master_profile", @out: false, min: 1, max: 1)]
        public FSharpList<master_profile> @MasterProfile { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "orchestration_platform", @out: false, min: 1, max: 1)]
        public string @OrchestrationPlatform { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "service_principal", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<service_principal>> @ServicePrincipal { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
