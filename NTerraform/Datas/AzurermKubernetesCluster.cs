using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_kubernetes_cluster : NTerraform.data
    {
        public class service_principal
        {
            public service_principal()
            {
            }

            public string @ClientId { get; }
        }

        public class network_profile
        {
            public network_profile()
            {
            }

            public string @DnsServiceIp { get; }
            public string @DockerBridgeCidr { get; }
            public string @NetworkPlugin { get; }
            public string @PodCidr { get; }
            public string @ServiceCidr { get; }
        }

        public class kube_config
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

        public class linux_profile
        {
            public class ssh_key
            {
                public ssh_key()
                {
                }

                public string @KeyData { get; }
            }

            public linux_profile(ssh_key[] @sshKey = null)
            {
                @SshKey = @sshKey;
            }

            public string @AdminUsername { get; }
            public ssh_key[] @SshKey { get; }
        }

        public class agent_pool_profile
        {
            public agent_pool_profile()
            {
            }

            public int? @Count { get; }
            public string @DnsPrefix { get; }
            public string @Name { get; }
            public int? @OsDiskSizeGb { get; }
            public string @OsType { get; }
            public string @VmSize { get; }
            public string @VnetSubnetId { get; }
        }

        public azurerm_kubernetes_cluster(string @name,
                                          string @resourceGroupName,
                                          agent_pool_profile[] @agentPoolProfile = null,
                                          kube_config[] @kubeConfig = null,
                                          linux_profile[] @linuxProfile = null,
                                          network_profile[] @networkProfile = null,
                                          service_principal[] @servicePrincipal = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @AgentPoolProfile = @agentPoolProfile;
            @KubeConfig = @kubeConfig;
            @LinuxProfile = @linuxProfile;
            @NetworkProfile = @networkProfile;
            @ServicePrincipal = @servicePrincipal;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public agent_pool_profile[] @AgentPoolProfile { get; }
        public string @DnsPrefix { get; }
        public string @Fqdn { get; }
        public kube_config[] @KubeConfig { get; }
        public string @KubeConfigRaw { get; }
        public string @KubernetesVersion { get; }
        public linux_profile[] @LinuxProfile { get; }
        public string @Location { get; }
        public network_profile[] @NetworkProfile { get; }
        public string @NodeResourceGroup { get; }
        public service_principal[] @ServicePrincipal { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
