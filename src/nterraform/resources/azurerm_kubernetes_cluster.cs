using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_kubernetes_cluster")]
    public sealed class azurerm_kubernetes_cluster : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "service_principal")]
        public sealed class service_principal : nterraform.Core.structure
        {
            public service_principal(string @clientId,
                                     string @clientSecret)
            {
                @ClientId = @clientId;
                @ClientSecret = @clientSecret;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "client_id", @out: false, min: 1, max: 1)]
            public string @ClientId { get; }

            [nterraform.Core.TerraformProperty(name: "client_secret", @out: false, min: 1, max: 1)]
            public string @ClientSecret { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "kube_config")]
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

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "network_profile")]
        public sealed class network_profile : nterraform.Core.structure
        {
            public network_profile(string @networkPlugin)
            {
                @NetworkPlugin = @networkPlugin;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "network_plugin", @out: false, min: 1, max: 1)]
            public string @NetworkPlugin { get; }

            [nterraform.Core.TerraformProperty(name: "dns_service_ip", @out: true, min: 0, max: 1)]
            public string @DnsServiceIp { get; }

            [nterraform.Core.TerraformProperty(name: "docker_bridge_cidr", @out: true, min: 0, max: 1)]
            public string @DockerBridgeCidr { get; }

            [nterraform.Core.TerraformProperty(name: "pod_cidr", @out: true, min: 0, max: 1)]
            public string @PodCidr { get; }

            [nterraform.Core.TerraformProperty(name: "service_cidr", @out: true, min: 0, max: 1)]
            public string @ServiceCidr { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "agent_pool_profile")]
        public sealed class agent_pool_profile : nterraform.Core.structure
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

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "vm_size", @out: false, min: 1, max: 1)]
            public string @VmSize { get; }

            [nterraform.Core.TerraformProperty(name: "count", @out: false, min: 0, max: 1)]
            public int? @Count { get; }

            [nterraform.Core.TerraformProperty(name: "dns_prefix", @out: true, min: 0, max: 1)]
            public string @DnsPrefix { get; }

            [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
            public string @Fqdn { get; }

            [nterraform.Core.TerraformProperty(name: "os_disk_size_gb", @out: false, min: 0, max: 1)]
            public int? @OsDiskSizeGb { get; }

            [nterraform.Core.TerraformProperty(name: "os_type", @out: false, min: 0, max: 1)]
            public string @OsType { get; }

            [nterraform.Core.TerraformProperty(name: "vnet_subnet_id", @out: false, min: 0, max: 1)]
            public string @VnetSubnetId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "linux_profile")]
        public sealed class linux_profile : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ssh_key")]
            public sealed class ssh_key : nterraform.Core.structure
            {
                public ssh_key(string @keyData)
                {
                    @KeyData = @keyData;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "key_data", @out: false, min: 1, max: 1)]
                public string @KeyData { get; }
            }

            public linux_profile(string @adminUsername,
                                 ssh_key[] @sshKey)
            {
                @AdminUsername = @adminUsername;
                @SshKey = @sshKey;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "admin_username", @out: false, min: 1, max: 1)]
            public string @AdminUsername { get; }

            [nterraform.Core.TerraformProperty(name: "ssh_key", @out: false, min: 1, max: 0)]
            public ssh_key[] @SshKey { get; }
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

        [nterraform.Core.TerraformProperty(name: "agent_pool_profile", @out: false, min: 1, max: 1)]
        public agent_pool_profile[] @AgentPoolProfile { get; }

        [nterraform.Core.TerraformProperty(name: "dns_prefix", @out: false, min: 1, max: 1)]
        public string @DnsPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "linux_profile", @out: false, min: 1, max: 1)]
        public linux_profile[] @LinuxProfile { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "service_principal", @out: false, min: 1, max: 1)]
        public service_principal[] @ServicePrincipal { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "kube_config", @out: false, min: 0, max: 1)]
        public kube_config[] @KubeConfig { get; }

        [nterraform.Core.TerraformProperty(name: "kube_config_raw", @out: true, min: 0, max: 1)]
        public string @KubeConfigRaw { get; }

        [nterraform.Core.TerraformProperty(name: "kubernetes_version", @out: true, min: 0, max: 1)]
        public string @KubernetesVersion { get; }

        [nterraform.Core.TerraformProperty(name: "network_profile", @out: false, min: 0, max: 1)]
        public network_profile[] @NetworkProfile { get; }

        [nterraform.Core.TerraformProperty(name: "node_resource_group", @out: true, min: 0, max: 1)]
        public string @NodeResourceGroup { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
