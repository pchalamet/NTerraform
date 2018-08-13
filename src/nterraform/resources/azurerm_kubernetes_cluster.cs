using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_kubernetes_cluster")]
    public sealed class azurerm_kubernetes_cluster : nterraform.resource
    {
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

            [nterraform.TerraformProperty(name: "ssh_key", @out: false, min: 1, max: 0)]
            public ssh_key[] @SshKey { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "kube_config")]
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

        [nterraform.TerraformStructure(category: "resource", typeName: "network_profile")]
        public sealed class network_profile : nterraform.structure
        {
            public network_profile(string @networkPlugin)
            {
                @NetworkPlugin = @networkPlugin;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "network_plugin", @out: false, min: 1, max: 1)]
            public string @NetworkPlugin { get; }

            [nterraform.TerraformProperty(name: "dns_service_ip", @out: true, min: 0, max: 1)]
            public string @DnsServiceIp { get; }

            [nterraform.TerraformProperty(name: "docker_bridge_cidr", @out: true, min: 0, max: 1)]
            public string @DockerBridgeCidr { get; }

            [nterraform.TerraformProperty(name: "pod_cidr", @out: true, min: 0, max: 1)]
            public string @PodCidr { get; }

            [nterraform.TerraformProperty(name: "service_cidr", @out: true, min: 0, max: 1)]
            public string @ServiceCidr { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "agent_pool_profile")]
        public sealed class agent_pool_profile : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "vm_size", @out: false, min: 1, max: 1)]
            public string @VmSize { get; }

            [nterraform.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public int? @Count { get; }

            [nterraform.TerraformProperty(name: "dns_prefix", @out: true, min: 0, max: 1)]
            public string @DnsPrefix { get; }

            [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
            public string @Fqdn { get; }

            [nterraform.TerraformProperty(name: "os_disk_size_gb", @out: false, min: 0, max: 1)]
            public int? @OsDiskSizeGb { get; }

            [nterraform.TerraformProperty(name: "os_type", @out: false, min: 0, max: 1)]
            public string @OsType { get; }

            [nterraform.TerraformProperty(name: "vnet_subnet_id", @out: false, min: 0, max: 1)]
            public string @VnetSubnetId { get; }
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "agent_pool_profile", @out: false, min: 1, max: 1)]
        public agent_pool_profile[] @AgentPoolProfile { get; }

        [nterraform.TerraformProperty(name: "dns_prefix", @out: false, min: 1, max: 1)]
        public string @DnsPrefix { get; }

        [nterraform.TerraformProperty(name: "linux_profile", @out: false, min: 1, max: 1)]
        public linux_profile[] @LinuxProfile { get; }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "service_principal", @out: false, min: 1, max: 1)]
        public service_principal[] @ServicePrincipal { get; }

        [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.TerraformProperty(name: "kube_config", @out: false, min: 0, max: 1)]
        public kube_config[] @KubeConfig { get; }

        [nterraform.TerraformProperty(name: "kube_config_raw", @out: true, min: 0, max: 1)]
        public string @KubeConfigRaw { get; }

        [nterraform.TerraformProperty(name: "kubernetes_version", @out: true, min: 0, max: 1)]
        public string @KubernetesVersion { get; }

        [nterraform.TerraformProperty(name: "network_profile", @out: false, min: 0, max: 1)]
        public network_profile[] @NetworkProfile { get; }

        [nterraform.TerraformProperty(name: "node_resource_group", @out: true, min: 0, max: 1)]
        public string @NodeResourceGroup { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
