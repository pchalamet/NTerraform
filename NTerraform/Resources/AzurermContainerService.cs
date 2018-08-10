using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_container_service : NTerraform.resource
    {
        public class master_profile
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

        public class agent_pool_profile
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

        public class diagnostics_profile
        {
            public diagnostics_profile(bool @enabled)
            {
                @Enabled = @enabled;
            }

            public bool @Enabled { get; }
            public string @StorageUri { get; }
        }

        public class linux_profile
        {
            public class ssh_key
            {
                public ssh_key(string @keyData)
                {
                    @KeyData = @keyData;
                }

                public string @KeyData { get; }
            }

            public linux_profile(string @adminUsername,
                                 HashSet<ssh_key> @sshKey)
            {
                @AdminUsername = @adminUsername;
                @SshKey = @sshKey;
            }

            public string @AdminUsername { get; }
            public HashSet<ssh_key> @SshKey { get; }
        }

        public class service_principal
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

        public azurerm_container_service(HashSet<agent_pool_profile> @agentPoolProfile,
                                         HashSet<diagnostics_profile> @diagnosticsProfile,
                                         HashSet<linux_profile> @linuxProfile,
                                         string @location,
                                         HashSet<master_profile> @masterProfile,
                                         string @name,
                                         string @orchestrationPlatform,
                                         string @resourceGroupName,
                                         HashSet<service_principal> @servicePrincipal = null)
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

        public HashSet<agent_pool_profile> @AgentPoolProfile { get; }
        public HashSet<diagnostics_profile> @DiagnosticsProfile { get; }
        public HashSet<linux_profile> @LinuxProfile { get; }
        public string @Location { get; }
        public HashSet<master_profile> @MasterProfile { get; }
        public string @Name { get; }
        public string @OrchestrationPlatform { get; }
        public string @ResourceGroupName { get; }
        public HashSet<service_principal> @ServicePrincipal { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
