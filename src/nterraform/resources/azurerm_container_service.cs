using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_container_service")]
    public sealed class azurerm_container_service : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "agent_pool_profile")]
        public sealed class agent_pool_profile : nterraform.structure
        {
            public agent_pool_profile(string @dnsPrefix,
                                      string @name,
                                      string @vmSize,
                                      int? @count = null)
            {
                @DnsPrefix = @dnsPrefix;
                @Name = @name;
                @VmSize = @vmSize;
                @Count = @count;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "dns_prefix", @out: false, min: 1, max: 1)]
            public string @DnsPrefix { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "vm_size", @out: false, min: 1, max: 1)]
            public string @VmSize { get; }

            [nterraform.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public int? @Count { get; }

            [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
            public string @Fqdn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "master_profile")]
        public sealed class master_profile : nterraform.structure
        {
            public master_profile(string @dnsPrefix,
                                  int? @count = null)
            {
                @DnsPrefix = @dnsPrefix;
                @Count = @count;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "dns_prefix", @out: false, min: 1, max: 1)]
            public string @DnsPrefix { get; }

            [nterraform.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public int? @Count { get; }

            [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
            public string @Fqdn { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "linux_profile")]
        public sealed class linux_profile : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "ssh_key")]
            public sealed class ssh_key : nterraform.structure
            {
                public ssh_key(string @keyData)
                {
                    @KeyData = @keyData;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "key_data", @out: false, min: 1, max: 1)]
                public string @KeyData { get; }
            }

            public linux_profile(string @adminUsername,
                                 ssh_key[] @sshKey)
            {
                @AdminUsername = @adminUsername;
                @SshKey = @sshKey;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "admin_username", @out: false, min: 1, max: 1)]
            public string @AdminUsername { get; }

            [nterraform.TerraformProperty(name: "ssh_key", @out: false, min: 1, max: 1)]
            public ssh_key[] @SshKey { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "service_principal")]
        public sealed class service_principal : nterraform.structure
        {
            public service_principal(string @clientId,
                                     string @clientSecret)
            {
                @ClientId = @clientId;
                @ClientSecret = @clientSecret;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "client_id", @out: false, min: 1, max: 1)]
            public string @ClientId { get; }

            [nterraform.TerraformProperty(name: "client_secret", @out: false, min: 1, max: 1)]
            public string @ClientSecret { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "diagnostics_profile")]
        public sealed class diagnostics_profile : nterraform.structure
        {
            public diagnostics_profile(bool @enabled)
            {
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.TerraformProperty(name: "storage_uri", @out: true, min: 0, max: 1)]
            public string @StorageUri { get; }
        }

        public azurerm_container_service(agent_pool_profile[] @agentPoolProfile,
                                         diagnostics_profile[] @diagnosticsProfile,
                                         linux_profile[] @linuxProfile,
                                         string @location,
                                         master_profile[] @masterProfile,
                                         string @name,
                                         string @orchestrationPlatform,
                                         string @resourceGroupName,
                                         service_principal[] @servicePrincipal = null)
        {
            @AgentPoolProfile = @agentPoolProfile;
            @DiagnosticsProfile = @diagnosticsProfile;
            @LinuxProfile = @linuxProfile;
            @Location = @location;
            @MasterProfile = @masterProfile;
            @Name = @name;
            @OrchestrationPlatform = @orchestrationPlatform;
            @ResourceGroupName = @resourceGroupName;
            @ServicePrincipal = @servicePrincipal;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "agent_pool_profile", @out: false, min: 1, max: 1)]
        public agent_pool_profile[] @AgentPoolProfile { get; }

        [nterraform.TerraformProperty(name: "diagnostics_profile", @out: false, min: 1, max: 1)]
        public diagnostics_profile[] @DiagnosticsProfile { get; }

        [nterraform.TerraformProperty(name: "linux_profile", @out: false, min: 1, max: 1)]
        public linux_profile[] @LinuxProfile { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "master_profile", @out: false, min: 1, max: 1)]
        public master_profile[] @MasterProfile { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "orchestration_platform", @out: false, min: 1, max: 1)]
        public string @OrchestrationPlatform { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "service_principal", @out: false, min: 0, max: 1)]
        public service_principal[] @ServicePrincipal { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
