using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_kubernetes_cluster")]
    public sealed class azurerm_kubernetes_cluster : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "linux_profile")]
        public sealed class linux_profile : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "data", typeName: "ssh_key")]
            public sealed class ssh_key : nterraform.structure
            {
                public ssh_key()
                {
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "key_data", @out: true, min: 0, max: 1)]
                public string @KeyData { get; }
            }

            public linux_profile(ssh_key[] @sshKey = null)
            {
                @SshKey = @sshKey;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "admin_username", @out: true, min: 0, max: 1)]
            public string @AdminUsername { get; }

            [nterraform.TerraformProperty(name: "ssh_key", @out: false, min: 0, max: 0)]
            public ssh_key[] @SshKey { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "agent_pool_profile")]
        public sealed class agent_pool_profile : nterraform.structure
        {
            public agent_pool_profile()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "count", @out: true, min: 0, max: 1)]
            public int? @Count { get; }

            [nterraform.TerraformProperty(name: "dns_prefix", @out: true, min: 0, max: 1)]
            public string @DnsPrefix { get; }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "os_disk_size_gb", @out: true, min: 0, max: 1)]
            public int? @OsDiskSizeGb { get; }

            [nterraform.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
            public string @OsType { get; }

            [nterraform.TerraformProperty(name: "vm_size", @out: true, min: 0, max: 1)]
            public string @VmSize { get; }

            [nterraform.TerraformProperty(name: "vnet_subnet_id", @out: true, min: 0, max: 1)]
            public string @VnetSubnetId { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "service_principal")]
        public sealed class service_principal : nterraform.structure
        {
            public service_principal()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "client_id", @out: true, min: 0, max: 1)]
            public string @ClientId { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "network_profile")]
        public sealed class network_profile : nterraform.structure
        {
            public network_profile()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "dns_service_ip", @out: true, min: 0, max: 1)]
            public string @DnsServiceIp { get; }

            [nterraform.TerraformProperty(name: "docker_bridge_cidr", @out: true, min: 0, max: 1)]
            public string @DockerBridgeCidr { get; }

            [nterraform.TerraformProperty(name: "network_plugin", @out: true, min: 0, max: 1)]
            public string @NetworkPlugin { get; }

            [nterraform.TerraformProperty(name: "pod_cidr", @out: true, min: 0, max: 1)]
            public string @PodCidr { get; }

            [nterraform.TerraformProperty(name: "service_cidr", @out: true, min: 0, max: 1)]
            public string @ServiceCidr { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "kube_config")]
        public sealed class kube_config : nterraform.structure
        {
            public kube_config()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "client_certificate", @out: true, min: 0, max: 1)]
            public string @ClientCertificate { get; }

            [nterraform.TerraformProperty(name: "client_key", @out: true, min: 0, max: 1)]
            public string @ClientKey { get; }

            [nterraform.TerraformProperty(name: "cluster_ca_certificate", @out: true, min: 0, max: 1)]
            public string @ClusterCaCertificate { get; }

            [nterraform.TerraformProperty(name: "host", @out: true, min: 0, max: 1)]
            public string @Host { get; }

            [nterraform.TerraformProperty(name: "password", @out: true, min: 0, max: 1)]
            public string @Password { get; }

            [nterraform.TerraformProperty(name: "username", @out: true, min: 0, max: 1)]
            public string @Username { get; }
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "agent_pool_profile", @out: false, min: 0, max: 0)]
        public agent_pool_profile[] @AgentPoolProfile { get; }

        [nterraform.TerraformProperty(name: "dns_prefix", @out: true, min: 0, max: 1)]
        public string @DnsPrefix { get; }

        [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.TerraformProperty(name: "kube_config", @out: false, min: 0, max: 0)]
        public kube_config[] @KubeConfig { get; }

        [nterraform.TerraformProperty(name: "kube_config_raw", @out: true, min: 0, max: 1)]
        public string @KubeConfigRaw { get; }

        [nterraform.TerraformProperty(name: "kubernetes_version", @out: true, min: 0, max: 1)]
        public string @KubernetesVersion { get; }

        [nterraform.TerraformProperty(name: "linux_profile", @out: false, min: 0, max: 0)]
        public linux_profile[] @LinuxProfile { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "network_profile", @out: false, min: 0, max: 0)]
        public network_profile[] @NetworkProfile { get; }

        [nterraform.TerraformProperty(name: "node_resource_group", @out: true, min: 0, max: 1)]
        public string @NodeResourceGroup { get; }

        [nterraform.TerraformProperty(name: "service_principal", @out: false, min: 0, max: 0)]
        public service_principal[] @ServicePrincipal { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
