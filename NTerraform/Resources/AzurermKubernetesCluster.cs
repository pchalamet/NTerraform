using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_kubernetes_cluster : NTerraform.resource
    {
        public sealed class agent_pool_profile
        {
            public agent_pool_profile(string @name,
                                      string @vmSize,
                                      int? @count = null,
                                      int? @osDiskSizeGb = null,
                                      string @osType = null,
                                      string @vnetSubnetId = null)
            {
                @Name = @name;
                @VmSize = @vmSize;
                @Count = @count;
                @OsDiskSizeGb = @osDiskSizeGb;
                @OsType = @osType;
                @VnetSubnetId = @vnetSubnetId;
            }

            public string @Name { get; }
            public string @VmSize { get; }
            public int? @Count { get; }
            public string @DnsPrefix { get; }
            public string @Fqdn { get; }
            public int? @OsDiskSizeGb { get; }
            public string @OsType { get; }
            public string @VnetSubnetId { get; }
        }

        public sealed class kube_config
        {
            public kube_config()
            {
            }

            public string @ClientCertificate { get; }
            public string @ClientKey { get; }
            public string @ClusterCaCertificate { get; }
            public string @Host { get; }
            public string @Password { get; }
            public string @Username { get; }
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

        public sealed class network_profile
        {
            public network_profile(string @networkPlugin)
            {
                @NetworkPlugin = @networkPlugin;
            }

            public string @NetworkPlugin { get; }
            public string @DnsServiceIp { get; }
            public string @DockerBridgeCidr { get; }
            public string @PodCidr { get; }
            public string @ServiceCidr { get; }
        }

        public azurerm_kubernetes_cluster(agent_pool_profile[] @agentPoolProfile,
                                          string @dnsPrefix,
                                          linux_profile[] @linuxProfile,
                                          string @location,
                                          string @name,
                                          string @resourceGroupName,
                                          service_principal[] @servicePrincipal,
                                          kube_config[] @kubeConfig = null,
                                          network_profile[] @networkProfile = null)
        {
            @AgentPoolProfile = @agentPoolProfile;
            @DnsPrefix = @dnsPrefix;
            @LinuxProfile = @linuxProfile;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServicePrincipal = @servicePrincipal;
            @KubeConfig = @kubeConfig;
            @NetworkProfile = @networkProfile;
        }

        public agent_pool_profile[] @AgentPoolProfile { get; }
        public string @DnsPrefix { get; }
        public linux_profile[] @LinuxProfile { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public service_principal[] @ServicePrincipal { get; }
        public string @Fqdn { get; }
        public kube_config[] @KubeConfig { get; }
        public string @KubeConfigRaw { get; }
        public string @KubernetesVersion { get; }
        public network_profile[] @NetworkProfile { get; }
        public string @NodeResourceGroup { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
