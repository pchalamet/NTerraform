using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_kubernetes_cluster")]
    public sealed class azurerm_kubernetes_cluster : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "service_principal")]
        public sealed class service_principal
        {
            public service_principal()
            {
            }

            [TerraformProperty(name: "client_id", @out: true, min: 0, max: 1)]
            public string @ClientId { get; }
        }

        [TerraformStructure(category: "", typeName: "agent_pool_profile")]
        public sealed class agent_pool_profile
        {
            public agent_pool_profile()
            {
            }

            [TerraformProperty(name: "count", @out: true, min: 0, max: 1)]
            public int? @Count { get; }

            [TerraformProperty(name: "dns_prefix", @out: true, min: 0, max: 1)]
            public string @DnsPrefix { get; }

            [TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "os_disk_size_gb", @out: true, min: 0, max: 1)]
            public int? @OsDiskSizeGb { get; }

            [TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
            public string @OsType { get; }

            [TerraformProperty(name: "vm_size", @out: true, min: 0, max: 1)]
            public string @VmSize { get; }

            [TerraformProperty(name: "vnet_subnet_id", @out: true, min: 0, max: 1)]
            public string @VnetSubnetId { get; }
        }

        [TerraformStructure(category: "", typeName: "kube_config")]
        public sealed class kube_config
        {
            public kube_config()
            {
            }

            [TerraformProperty(name: "client_certificate", @out: true, min: 0, max: 1)]
            public string @ClientCertificate { get; }

            [TerraformProperty(name: "client_key", @out: true, min: 0, max: 1)]
            public string @ClientKey { get; }

            [TerraformProperty(name: "cluster_ca_certificate", @out: true, min: 0, max: 1)]
            public string @ClusterCaCertificate { get; }

            [TerraformProperty(name: "host", @out: true, min: 0, max: 1)]
            public string @Host { get; }

            [TerraformProperty(name: "password", @out: true, min: 0, max: 1)]
            public string @Password { get; }

            [TerraformProperty(name: "username", @out: true, min: 0, max: 1)]
            public string @Username { get; }
        }

        [TerraformStructure(category: "", typeName: "linux_profile")]
        public sealed class linux_profile
        {
            [TerraformStructure(category: "", typeName: "ssh_key")]
            public sealed class ssh_key
            {
                public ssh_key()
                {
                }

                [TerraformProperty(name: "key_data", @out: true, min: 0, max: 1)]
                public string @KeyData { get; }
            }

            public linux_profile(ssh_key[] @sshKey = null)
            {
                @SshKey = @sshKey;
            }

            [TerraformProperty(name: "admin_username", @out: true, min: 0, max: 1)]
            public string @AdminUsername { get; }

            [TerraformProperty(name: "ssh_key", @out: false, min: 0, max: 0)]
            public ssh_key[] @SshKey { get; }
        }

        [TerraformStructure(category: "", typeName: "network_profile")]
        public sealed class network_profile
        {
            public network_profile()
            {
            }

            [TerraformProperty(name: "dns_service_ip", @out: true, min: 0, max: 1)]
            public string @DnsServiceIp { get; }

            [TerraformProperty(name: "docker_bridge_cidr", @out: true, min: 0, max: 1)]
            public string @DockerBridgeCidr { get; }

            [TerraformProperty(name: "network_plugin", @out: true, min: 0, max: 1)]
            public string @NetworkPlugin { get; }

            [TerraformProperty(name: "pod_cidr", @out: true, min: 0, max: 1)]
            public string @PodCidr { get; }

            [TerraformProperty(name: "service_cidr", @out: true, min: 0, max: 1)]
            public string @ServiceCidr { get; }
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

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "agent_pool_profile", @out: false, min: 0, max: 0)]
        public agent_pool_profile[] @AgentPoolProfile { get; }

        [TerraformProperty(name: "dns_prefix", @out: true, min: 0, max: 1)]
        public string @DnsPrefix { get; }

        [TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [TerraformProperty(name: "kube_config", @out: false, min: 0, max: 0)]
        public kube_config[] @KubeConfig { get; }

        [TerraformProperty(name: "kube_config_raw", @out: true, min: 0, max: 1)]
        public string @KubeConfigRaw { get; }

        [TerraformProperty(name: "kubernetes_version", @out: true, min: 0, max: 1)]
        public string @KubernetesVersion { get; }

        [TerraformProperty(name: "linux_profile", @out: false, min: 0, max: 0)]
        public linux_profile[] @LinuxProfile { get; }

        [TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "network_profile", @out: false, min: 0, max: 0)]
        public network_profile[] @NetworkProfile { get; }

        [TerraformProperty(name: "node_resource_group", @out: true, min: 0, max: 1)]
        public string @NodeResourceGroup { get; }

        [TerraformProperty(name: "service_principal", @out: false, min: 0, max: 0)]
        public service_principal[] @ServicePrincipal { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
