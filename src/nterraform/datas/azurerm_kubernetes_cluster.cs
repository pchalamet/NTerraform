using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_kubernetes_cluster")]
    public sealed class azurerm_kubernetes_cluster : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "agent_pool_profile")]
        public sealed class agent_pool_profile : nterraform.Core.structure
        {
            public agent_pool_profile()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "count", @out: true, min: 0, max: 1)]
            public int? @Count { get; }

            [nterraform.Core.TerraformProperty(name: "dns_prefix", @out: true, min: 0, max: 1)]
            public string @DnsPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "os_disk_size_gb", @out: true, min: 0, max: 1)]
            public int? @OsDiskSizeGb { get; }

            [nterraform.Core.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
            public string @OsType { get; }

            [nterraform.Core.TerraformProperty(name: "vm_size", @out: true, min: 0, max: 1)]
            public string @VmSize { get; }

            [nterraform.Core.TerraformProperty(name: "vnet_subnet_id", @out: true, min: 0, max: 1)]
            public string @VnetSubnetId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "service_principal")]
        public sealed class service_principal : nterraform.Core.structure
        {
            public service_principal()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "client_id", @out: true, min: 0, max: 1)]
            public string @ClientId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "linux_profile")]
        public sealed class linux_profile : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "data", typeName: "ssh_key")]
            public sealed class ssh_key : nterraform.Core.structure
            {
                public ssh_key()
                {
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "key_data", @out: true, min: 0, max: 1)]
                public string @KeyData { get; }
            }

            public linux_profile(ssh_key[] @sshKey = null)
            {
                @SshKey = @sshKey;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "admin_username", @out: true, min: 0, max: 1)]
            public string @AdminUsername { get; }

            [nterraform.Core.TerraformProperty(name: "ssh_key", @out: false, min: 0, max: 0)]
            public ssh_key[] @SshKey { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "kube_config")]
        public sealed class kube_config : nterraform.Core.structure
        {
            public kube_config()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "client_certificate", @out: true, min: 0, max: 1)]
            public string @ClientCertificate { get; }

            [nterraform.Core.TerraformProperty(name: "client_key", @out: true, min: 0, max: 1)]
            public string @ClientKey { get; }

            [nterraform.Core.TerraformProperty(name: "cluster_ca_certificate", @out: true, min: 0, max: 1)]
            public string @ClusterCaCertificate { get; }

            [nterraform.Core.TerraformProperty(name: "host", @out: true, min: 0, max: 1)]
            public string @Host { get; }

            [nterraform.Core.TerraformProperty(name: "password", @out: true, min: 0, max: 1)]
            public string @Password { get; }

            [nterraform.Core.TerraformProperty(name: "username", @out: true, min: 0, max: 1)]
            public string @Username { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "network_profile")]
        public sealed class network_profile : nterraform.Core.structure
        {
            public network_profile()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "dns_service_ip", @out: true, min: 0, max: 1)]
            public string @DnsServiceIp { get; }

            [nterraform.Core.TerraformProperty(name: "docker_bridge_cidr", @out: true, min: 0, max: 1)]
            public string @DockerBridgeCidr { get; }

            [nterraform.Core.TerraformProperty(name: "network_plugin", @out: true, min: 0, max: 1)]
            public string @NetworkPlugin { get; }

            [nterraform.Core.TerraformProperty(name: "pod_cidr", @out: true, min: 0, max: 1)]
            public string @PodCidr { get; }

            [nterraform.Core.TerraformProperty(name: "service_cidr", @out: true, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "agent_pool_profile", @out: false, min: 0, max: 0)]
        public agent_pool_profile[] @AgentPoolProfile { get; }

        [nterraform.Core.TerraformProperty(name: "dns_prefix", @out: true, min: 0, max: 1)]
        public string @DnsPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "kube_config", @out: false, min: 0, max: 0)]
        public kube_config[] @KubeConfig { get; }

        [nterraform.Core.TerraformProperty(name: "kube_config_raw", @out: true, min: 0, max: 1)]
        public string @KubeConfigRaw { get; }

        [nterraform.Core.TerraformProperty(name: "kubernetes_version", @out: true, min: 0, max: 1)]
        public string @KubernetesVersion { get; }

        [nterraform.Core.TerraformProperty(name: "linux_profile", @out: false, min: 0, max: 0)]
        public linux_profile[] @LinuxProfile { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "network_profile", @out: false, min: 0, max: 0)]
        public network_profile[] @NetworkProfile { get; }

        [nterraform.Core.TerraformProperty(name: "node_resource_group", @out: true, min: 0, max: 1)]
        public string @NodeResourceGroup { get; }

        [nterraform.Core.TerraformProperty(name: "service_principal", @out: false, min: 0, max: 0)]
        public service_principal[] @ServicePrincipal { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
