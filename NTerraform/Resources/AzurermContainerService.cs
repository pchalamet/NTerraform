using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_container_service")]
    public sealed class azurerm_container_service : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "linux_profile")]
        public sealed class linux_profile
        {
            [TerraformStructure(category: "", typeName: "ssh_key")]
            public sealed class ssh_key
            {
                public ssh_key(string @keyData)
                {
                    @KeyData = @keyData;
                }

                [TerraformProperty(name: "key_data", @out: false, nested: false, min: 1, max: 1)]
                public string @KeyData { get; }
            }

            public linux_profile(string @adminUsername,
                                 ssh_key[] @sshKey)
            {
                @AdminUsername = @adminUsername;
                @SshKey = @sshKey;
            }

            [TerraformProperty(name: "admin_username", @out: false, nested: false, min: 1, max: 1)]
            public string @AdminUsername { get; }

            [TerraformProperty(name: "ssh_key", @out: false, nested: false, min: 1, max: 1)]
            public ssh_key[] @SshKey { get; }
        }

        [TerraformStructure(category: "", typeName: "diagnostics_profile")]
        public sealed class diagnostics_profile
        {
            public diagnostics_profile(bool @enabled)
            {
                @Enabled = @enabled;
            }

            [TerraformProperty(name: "enabled", @out: false, nested: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [TerraformProperty(name: "storage_uri", @out: true, nested: false, min: 0, max: 1)]
            public string @StorageUri { get; }
        }

        [TerraformStructure(category: "", typeName: "master_profile")]
        public sealed class master_profile
        {
            public master_profile(string @dnsPrefix,
                                  int? @count = null)
            {
                @DnsPrefix = @dnsPrefix;
                @Count = @count;
            }

            [TerraformProperty(name: "dns_prefix", @out: false, nested: false, min: 1, max: 1)]
            public string @DnsPrefix { get; }

            [TerraformProperty(name: "count", @out: false, nested: false, min: 0, max: 1)]
            public int? @Count { get; }

            [TerraformProperty(name: "fqdn", @out: true, nested: false, min: 0, max: 1)]
            public string @Fqdn { get; }
        }

        [TerraformStructure(category: "", typeName: "agent_pool_profile")]
        public sealed class agent_pool_profile
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
            }

            [TerraformProperty(name: "dns_prefix", @out: false, nested: false, min: 1, max: 1)]
            public string @DnsPrefix { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "vm_size", @out: false, nested: false, min: 1, max: 1)]
            public string @VmSize { get; }

            [TerraformProperty(name: "count", @out: false, nested: false, min: 0, max: 1)]
            public int? @Count { get; }

            [TerraformProperty(name: "fqdn", @out: true, nested: false, min: 0, max: 1)]
            public string @Fqdn { get; }
        }

        [TerraformStructure(category: "", typeName: "service_principal")]
        public sealed class service_principal
        {
            public service_principal(string @clientId,
                                     string @clientSecret)
            {
                @ClientId = @clientId;
                @ClientSecret = @clientSecret;
            }

            [TerraformProperty(name: "client_id", @out: false, nested: false, min: 1, max: 1)]
            public string @ClientId { get; }

            [TerraformProperty(name: "client_secret", @out: false, nested: false, min: 1, max: 1)]
            public string @ClientSecret { get; }
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
        }

        [TerraformProperty(name: "agent_pool_profile", @out: false, nested: true, min: 1, max: 1)]
        public agent_pool_profile[] @AgentPoolProfile { get; }

        [TerraformProperty(name: "diagnostics_profile", @out: false, nested: true, min: 1, max: 1)]
        public diagnostics_profile[] @DiagnosticsProfile { get; }

        [TerraformProperty(name: "linux_profile", @out: false, nested: true, min: 1, max: 1)]
        public linux_profile[] @LinuxProfile { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "master_profile", @out: false, nested: true, min: 1, max: 1)]
        public master_profile[] @MasterProfile { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "orchestration_platform", @out: false, nested: true, min: 1, max: 1)]
        public string @OrchestrationPlatform { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "service_principal", @out: false, nested: true, min: 0, max: 1)]
        public service_principal[] @ServicePrincipal { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
