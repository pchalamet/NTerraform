using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_container_service : NTerraform.resource
    {
        public sealed class master_profile
        {
            public master_profile(string @dnsPrefix,
                                  int? @count = null)
            {
                @DnsPrefix = @dnsPrefix;
                @Count = @count;
            }

            public string @DnsPrefix { get; }
            public int? @Count { get; }
            public string @Fqdn { get; }
        }

        public sealed class diagnostics_profile
        {
            public diagnostics_profile(bool @enabled)
            {
                @Enabled = @enabled;
            }

            public bool @Enabled { get; }
            public string @StorageUri { get; }
        }

        public sealed class linux_profile
        {
            public sealed class ssh_key
            {
                public ssh_key(string @keyData)
                {
                    @KeyData = @keyData;
                }

                public string @KeyData { get; }
            }

            public linux_profile(string @adminUsername,
                                 ssh_key[] @sshKey)
            {
                @AdminUsername = @adminUsername;
                @SshKey = @sshKey;
            }

            public string @AdminUsername { get; }
            public ssh_key[] @SshKey { get; }
        }

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

            public string @DnsPrefix { get; }
            public string @Name { get; }
            public string @VmSize { get; }
            public int? @Count { get; }
            public string @Fqdn { get; }
        }

        public sealed class service_principal
        {
            public service_principal(string @clientId,
                                     string @clientSecret)
            {
                @ClientId = @clientId;
                @ClientSecret = @clientSecret;
            }

            public string @ClientId { get; }
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

        public agent_pool_profile[] @AgentPoolProfile { get; }
        public diagnostics_profile[] @DiagnosticsProfile { get; }
        public linux_profile[] @LinuxProfile { get; }
        public string @Location { get; }
        public master_profile[] @MasterProfile { get; }
        public string @Name { get; }
        public string @OrchestrationPlatform { get; }
        public string @ResourceGroupName { get; }
        public service_principal[] @ServicePrincipal { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
