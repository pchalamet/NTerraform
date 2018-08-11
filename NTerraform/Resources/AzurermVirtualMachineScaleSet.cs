using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine_scale_set")]
    public sealed class azurerm_virtual_machine_scale_set : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "os_profile_windows_config")]
        public sealed class os_profile_windows_config
        {
            [TerraformStructure(category: "", typeName: "winrm")]
            public sealed class winrm
            {
                public winrm(string @protocol,
                             string @certificateUrl = null)
                {
                    @Protocol = @protocol;
                    @CertificateUrl = @certificateUrl;
                }

                [TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
                public string @Protocol { get; }

                [TerraformProperty(name: "certificate_url", @out: false, min: 0, max: 1)]
                public string @CertificateUrl { get; }
            }

            [TerraformStructure(category: "", typeName: "additional_unattend_config")]
            public sealed class additional_unattend_config
            {
                public additional_unattend_config(string @component,
                                                  string @content,
                                                  string @pass,
                                                  string @settingName)
                {
                    @Component = @component;
                    @Content = @content;
                    @Pass = @pass;
                    @SettingName = @settingName;
                }

                [TerraformProperty(name: "component", @out: false, min: 1, max: 1)]
                public string @Component { get; }

                [TerraformProperty(name: "content", @out: false, min: 1, max: 1)]
                public string @Content { get; }

                [TerraformProperty(name: "pass", @out: false, min: 1, max: 1)]
                public string @Pass { get; }

                [TerraformProperty(name: "setting_name", @out: false, min: 1, max: 1)]
                public string @SettingName { get; }
            }

            public os_profile_windows_config(additional_unattend_config[] @additionalUnattendConfig = null,
                                             bool? @enableAutomaticUpgrades = null,
                                             bool? @provisionVmAgent = null,
                                             winrm[] @winrm = null)
            {
                @AdditionalUnattendConfig = @additionalUnattendConfig;
                @EnableAutomaticUpgrades = @enableAutomaticUpgrades;
                @ProvisionVmAgent = @provisionVmAgent;
                @Winrm = @winrm;
            }

            [TerraformProperty(name: "additional_unattend_config", @out: false, min: 0, max: 0)]
            public additional_unattend_config[] @AdditionalUnattendConfig { get; }

            [TerraformProperty(name: "enable_automatic_upgrades", @out: false, min: 0, max: 1)]
            public bool? @EnableAutomaticUpgrades { get; }

            [TerraformProperty(name: "provision_vm_agent", @out: false, min: 0, max: 1)]
            public bool? @ProvisionVmAgent { get; }

            [TerraformProperty(name: "winrm", @out: false, min: 0, max: 0)]
            public winrm[] @Winrm { get; }
        }

        [TerraformStructure(category: "", typeName: "identity")]
        public sealed class identity
        {
            public identity(string @type,
                            string[] @identityIds = null)
            {
                @Type = @type;
                @IdentityIds = @identityIds;
            }

            [TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [TerraformProperty(name: "identity_ids", @out: false, min: 0, max: 1)]
            public string[] @IdentityIds { get; }

            [TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public string @PrincipalId { get; }
        }

        [TerraformStructure(category: "", typeName: "network_profile")]
        public sealed class network_profile
        {
            [TerraformStructure(category: "", typeName: "ip_configuration")]
            public sealed class ip_configuration
            {
                [TerraformStructure(category: "", typeName: "public_ip_address_configuration")]
                public sealed class public_ip_address_configuration
                {
                    public public_ip_address_configuration(string @domainNameLabel,
                                                           int @idleTimeout,
                                                           string @name)
                    {
                        @DomainNameLabel = @domainNameLabel;
                        @IdleTimeout = @idleTimeout;
                        @Name = @name;
                    }

                    [TerraformProperty(name: "domain_name_label", @out: false, min: 1, max: 1)]
                    public string @DomainNameLabel { get; }

                    [TerraformProperty(name: "idle_timeout", @out: false, min: 1, max: 1)]
                    public int @IdleTimeout { get; }

                    [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                    public string @Name { get; }
                }

                public ip_configuration(string @name,
                                        string @subnetId,
                                        string[] @applicationGatewayBackendAddressPoolIds = null,
                                        string[] @loadBalancerBackendAddressPoolIds = null,
                                        bool? @primary = null,
                                        public_ip_address_configuration[] @publicIpAddressConfiguration = null)
                {
                    @Name = @name;
                    @SubnetId = @subnetId;
                    @ApplicationGatewayBackendAddressPoolIds = @applicationGatewayBackendAddressPoolIds;
                    @LoadBalancerBackendAddressPoolIds = @loadBalancerBackendAddressPoolIds;
                    @Primary = @primary;
                    @PublicIpAddressConfiguration = @publicIpAddressConfiguration;
                }

                [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
                public string @SubnetId { get; }

                [TerraformProperty(name: "application_gateway_backend_address_pool_ids", @out: false, min: 0, max: 1)]
                public string[] @ApplicationGatewayBackendAddressPoolIds { get; }

                [TerraformProperty(name: "load_balancer_backend_address_pool_ids", @out: false, min: 0, max: 1)]
                public string[] @LoadBalancerBackendAddressPoolIds { get; }

                [TerraformProperty(name: "load_balancer_inbound_nat_rules_ids", @out: true, min: 0, max: 1)]
                public string[] @LoadBalancerInboundNatRulesIds { get; }

                [TerraformProperty(name: "primary", @out: false, min: 0, max: 1)]
                public bool? @Primary { get; }

                [TerraformProperty(name: "public_ip_address_configuration", @out: false, min: 0, max: 1)]
                public public_ip_address_configuration[] @PublicIpAddressConfiguration { get; }
            }

            [TerraformStructure(category: "", typeName: "dns_settings")]
            public sealed class dns_settings
            {
                public dns_settings(string[] @dnsServers)
                {
                    @DnsServers = @dnsServers;
                }

                [TerraformProperty(name: "dns_servers", @out: false, min: 1, max: 1)]
                public string[] @DnsServers { get; }
            }

            public network_profile(ip_configuration[] @ipConfiguration,
                                   string @name,
                                   bool @primary,
                                   bool? @acceleratedNetworking = null,
                                   dns_settings[] @dnsSettings = null,
                                   bool? @ipForwarding = null,
                                   string @networkSecurityGroupId = null)
            {
                @IpConfiguration = @ipConfiguration;
                @Name = @name;
                @Primary = @primary;
                @AcceleratedNetworking = @acceleratedNetworking;
                @DnsSettings = @dnsSettings;
                @IpForwarding = @ipForwarding;
                @NetworkSecurityGroupId = @networkSecurityGroupId;
            }

            [TerraformProperty(name: "ip_configuration", @out: false, min: 1, max: 0)]
            public ip_configuration[] @IpConfiguration { get; }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "primary", @out: false, min: 1, max: 1)]
            public bool @Primary { get; }

            [TerraformProperty(name: "accelerated_networking", @out: false, min: 0, max: 1)]
            public bool? @AcceleratedNetworking { get; }

            [TerraformProperty(name: "dns_settings", @out: false, min: 0, max: 1)]
            public dns_settings[] @DnsSettings { get; }

            [TerraformProperty(name: "ip_forwarding", @out: false, min: 0, max: 1)]
            public bool? @IpForwarding { get; }

            [TerraformProperty(name: "network_security_group_id", @out: false, min: 0, max: 1)]
            public string @NetworkSecurityGroupId { get; }
        }

        [TerraformStructure(category: "", typeName: "os_profile_linux_config")]
        public sealed class os_profile_linux_config
        {
            [TerraformStructure(category: "", typeName: "ssh_keys")]
            public sealed class ssh_keys
            {
                public ssh_keys(string @path,
                                string @keyData = null)
                {
                    @Path = @path;
                    @KeyData = @keyData;
                }

                [TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
                public string @Path { get; }

                [TerraformProperty(name: "key_data", @out: false, min: 0, max: 1)]
                public string @KeyData { get; }
            }

            public os_profile_linux_config(bool? @disablePasswordAuthentication = null,
                                           ssh_keys[] @sshKeys = null)
            {
                @DisablePasswordAuthentication = @disablePasswordAuthentication;
                @SshKeys = @sshKeys;
            }

            [TerraformProperty(name: "disable_password_authentication", @out: false, min: 0, max: 1)]
            public bool? @DisablePasswordAuthentication { get; }

            [TerraformProperty(name: "ssh_keys", @out: false, min: 0, max: 0)]
            public ssh_keys[] @SshKeys { get; }
        }

        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku(int @capacity,
                       string @name)
            {
                @Capacity = @capacity;
                @Name = @name;
            }

            [TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public int @Capacity { get; }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "tier", @out: true, min: 0, max: 1)]
            public string @Tier { get; }
        }

        [TerraformStructure(category: "", typeName: "os_profile_secrets")]
        public sealed class os_profile_secrets
        {
            [TerraformStructure(category: "", typeName: "vault_certificates")]
            public sealed class vault_certificates
            {
                public vault_certificates(string @certificateUrl,
                                          string @certificateStore = null)
                {
                    @CertificateUrl = @certificateUrl;
                    @CertificateStore = @certificateStore;
                }

                [TerraformProperty(name: "certificate_url", @out: false, min: 1, max: 1)]
                public string @CertificateUrl { get; }

                [TerraformProperty(name: "certificate_store", @out: false, min: 0, max: 1)]
                public string @CertificateStore { get; }
            }

            public os_profile_secrets(string @sourceVaultId,
                                      vault_certificates[] @vaultCertificates = null)
            {
                @SourceVaultId = @sourceVaultId;
                @VaultCertificates = @vaultCertificates;
            }

            [TerraformProperty(name: "source_vault_id", @out: false, min: 1, max: 1)]
            public string @SourceVaultId { get; }

            [TerraformProperty(name: "vault_certificates", @out: false, min: 0, max: 0)]
            public vault_certificates[] @VaultCertificates { get; }
        }

        [TerraformStructure(category: "", typeName: "plan")]
        public sealed class plan
        {
            public plan(string @name,
                        string @product,
                        string @publisher)
            {
                @Name = @name;
                @Product = @product;
                @Publisher = @publisher;
            }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "product", @out: false, min: 1, max: 1)]
            public string @Product { get; }

            [TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
            public string @Publisher { get; }
        }

        [TerraformStructure(category: "", typeName: "os_profile")]
        public sealed class os_profile
        {
            public os_profile(string @adminPassword,
                              string @adminUsername,
                              string @computerNamePrefix,
                              string @customData = null)
            {
                @AdminPassword = @adminPassword;
                @AdminUsername = @adminUsername;
                @ComputerNamePrefix = @computerNamePrefix;
                @CustomData = @customData;
            }

            [TerraformProperty(name: "admin_password", @out: false, min: 1, max: 1)]
            public string @AdminPassword { get; }

            [TerraformProperty(name: "admin_username", @out: false, min: 1, max: 1)]
            public string @AdminUsername { get; }

            [TerraformProperty(name: "computer_name_prefix", @out: false, min: 1, max: 1)]
            public string @ComputerNamePrefix { get; }

            [TerraformProperty(name: "custom_data", @out: false, min: 0, max: 1)]
            public string @CustomData { get; }
        }

        [TerraformStructure(category: "", typeName: "boot_diagnostics")]
        public sealed class boot_diagnostics
        {
            public boot_diagnostics(string @storageUri,
                                    bool? @enabled = null)
            {
                @StorageUri = @storageUri;
                @Enabled = @enabled;
            }

            [TerraformProperty(name: "storage_uri", @out: false, min: 1, max: 1)]
            public string @StorageUri { get; }

            [TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public bool? @Enabled { get; }
        }

        [TerraformStructure(category: "", typeName: "storage_profile_image_reference")]
        public sealed class storage_profile_image_reference
        {
            public storage_profile_image_reference(string @id = null,
                                                   string @offer = null,
                                                   string @publisher = null,
                                                   string @sku = null,
                                                   string @version = null)
            {
                @Id = @id;
                @Offer = @offer;
                @Publisher = @publisher;
                @Sku = @sku;
                @Version = @version;
            }

            [TerraformProperty(name: "id", @out: false, min: 0, max: 1)]
            public string @Id { get; }

            [TerraformProperty(name: "offer", @out: false, min: 0, max: 1)]
            public string @Offer { get; }

            [TerraformProperty(name: "publisher", @out: false, min: 0, max: 1)]
            public string @Publisher { get; }

            [TerraformProperty(name: "sku", @out: false, min: 0, max: 1)]
            public string @Sku { get; }

            [TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
            public string @Version { get; }
        }

        [TerraformStructure(category: "", typeName: "extension")]
        public sealed class extension
        {
            public extension(string @name,
                             string @publisher,
                             string @type,
                             string @typeHandlerVersion,
                             bool? @autoUpgradeMinorVersion = null,
                             string @protectedSettings = null,
                             string @settings = null)
            {
                @Name = @name;
                @Publisher = @publisher;
                @Type = @type;
                @TypeHandlerVersion = @typeHandlerVersion;
                @AutoUpgradeMinorVersion = @autoUpgradeMinorVersion;
                @ProtectedSettings = @protectedSettings;
                @Settings = @settings;
            }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
            public string @Publisher { get; }

            [TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [TerraformProperty(name: "type_handler_version", @out: false, min: 1, max: 1)]
            public string @TypeHandlerVersion { get; }

            [TerraformProperty(name: "auto_upgrade_minor_version", @out: false, min: 0, max: 1)]
            public bool? @AutoUpgradeMinorVersion { get; }

            [TerraformProperty(name: "protected_settings", @out: false, min: 0, max: 1)]
            public string @ProtectedSettings { get; }

            [TerraformProperty(name: "settings", @out: false, min: 0, max: 1)]
            public string @Settings { get; }
        }

        [TerraformStructure(category: "", typeName: "storage_profile_os_disk")]
        public sealed class storage_profile_os_disk
        {
            public storage_profile_os_disk(string @createOption,
                                           string @image = null,
                                           string @name = null,
                                           string @osType = null,
                                           string[] @vhdContainers = null)
            {
                @CreateOption = @createOption;
                @Image = @image;
                @Name = @name;
                @OsType = @osType;
                @VhdContainers = @vhdContainers;
            }

            [TerraformProperty(name: "create_option", @out: false, min: 1, max: 1)]
            public string @CreateOption { get; }

            [TerraformProperty(name: "caching", @out: true, min: 0, max: 1)]
            public string @Caching { get; }

            [TerraformProperty(name: "image", @out: false, min: 0, max: 1)]
            public string @Image { get; }

            [TerraformProperty(name: "managed_disk_type", @out: true, min: 0, max: 1)]
            public string @ManagedDiskType { get; }

            [TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "os_type", @out: false, min: 0, max: 1)]
            public string @OsType { get; }

            [TerraformProperty(name: "vhd_containers", @out: false, min: 0, max: 1)]
            public string[] @VhdContainers { get; }
        }

        [TerraformStructure(category: "", typeName: "storage_profile_data_disk")]
        public sealed class storage_profile_data_disk
        {
            public storage_profile_data_disk(string @createOption,
                                             int @lun)
            {
                @CreateOption = @createOption;
                @Lun = @lun;
            }

            [TerraformProperty(name: "create_option", @out: false, min: 1, max: 1)]
            public string @CreateOption { get; }

            [TerraformProperty(name: "lun", @out: false, min: 1, max: 1)]
            public int @Lun { get; }

            [TerraformProperty(name: "caching", @out: true, min: 0, max: 1)]
            public string @Caching { get; }

            [TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
            public int? @DiskSizeGb { get; }

            [TerraformProperty(name: "managed_disk_type", @out: true, min: 0, max: 1)]
            public string @ManagedDiskType { get; }
        }

        public azurerm_virtual_machine_scale_set(string @location,
                                                 string @name,
                                                 network_profile[] @networkProfile,
                                                 os_profile[] @osProfile,
                                                 string @resourceGroupName,
                                                 sku[] @sku,
                                                 storage_profile_os_disk[] @storageProfileOsDisk,
                                                 string @upgradePolicyMode,
                                                 boot_diagnostics[] @bootDiagnostics = null,
                                                 extension[] @extension = null,
                                                 identity[] @identity = null,
                                                 os_profile_linux_config[] @osProfileLinuxConfig = null,
                                                 os_profile_secrets[] @osProfileSecrets = null,
                                                 os_profile_windows_config[] @osProfileWindowsConfig = null,
                                                 bool? @overprovision = null,
                                                 plan[] @plan = null,
                                                 string @priority = null,
                                                 bool? @singlePlacementGroup = null,
                                                 storage_profile_data_disk[] @storageProfileDataDisk = null,
                                                 storage_profile_image_reference[] @storageProfileImageReference = null,
                                                 string[] @zones = null)
        {
            @Location = @location;
            @Name = @name;
            @NetworkProfile = @networkProfile;
            @OsProfile = @osProfile;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @StorageProfileOsDisk = @storageProfileOsDisk;
            @UpgradePolicyMode = @upgradePolicyMode;
            @BootDiagnostics = @bootDiagnostics;
            @Extension = @extension;
            @Identity = @identity;
            @OsProfileLinuxConfig = @osProfileLinuxConfig;
            @OsProfileSecrets = @osProfileSecrets;
            @OsProfileWindowsConfig = @osProfileWindowsConfig;
            @Overprovision = @overprovision;
            @Plan = @plan;
            @Priority = @priority;
            @SinglePlacementGroup = @singlePlacementGroup;
            @StorageProfileDataDisk = @storageProfileDataDisk;
            @StorageProfileImageReference = @storageProfileImageReference;
            @Zones = @zones;
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "network_profile", @out: false, min: 1, max: 0)]
        public network_profile[] @NetworkProfile { get; }

        [TerraformProperty(name: "os_profile", @out: false, min: 1, max: 1)]
        public os_profile[] @OsProfile { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "storage_profile_os_disk", @out: false, min: 1, max: 1)]
        public storage_profile_os_disk[] @StorageProfileOsDisk { get; }

        [TerraformProperty(name: "upgrade_policy_mode", @out: false, min: 1, max: 1)]
        public string @UpgradePolicyMode { get; }

        [TerraformProperty(name: "boot_diagnostics", @out: false, min: 0, max: 1)]
        public boot_diagnostics[] @BootDiagnostics { get; }

        [TerraformProperty(name: "extension", @out: false, min: 0, max: 0)]
        public extension[] @Extension { get; }

        [TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public identity[] @Identity { get; }

        [TerraformProperty(name: "license_type", @out: true, min: 0, max: 1)]
        public string @LicenseType { get; }

        [TerraformProperty(name: "os_profile_linux_config", @out: false, min: 0, max: 1)]
        public os_profile_linux_config[] @OsProfileLinuxConfig { get; }

        [TerraformProperty(name: "os_profile_secrets", @out: false, min: 0, max: 0)]
        public os_profile_secrets[] @OsProfileSecrets { get; }

        [TerraformProperty(name: "os_profile_windows_config", @out: false, min: 0, max: 1)]
        public os_profile_windows_config[] @OsProfileWindowsConfig { get; }

        [TerraformProperty(name: "overprovision", @out: false, min: 0, max: 1)]
        public bool? @Overprovision { get; }

        [TerraformProperty(name: "plan", @out: false, min: 0, max: 1)]
        public plan[] @Plan { get; }

        [TerraformProperty(name: "priority", @out: false, min: 0, max: 1)]
        public string @Priority { get; }

        [TerraformProperty(name: "single_placement_group", @out: false, min: 0, max: 1)]
        public bool? @SinglePlacementGroup { get; }

        [TerraformProperty(name: "storage_profile_data_disk", @out: false, min: 0, max: 0)]
        public storage_profile_data_disk[] @StorageProfileDataDisk { get; }

        [TerraformProperty(name: "storage_profile_image_reference", @out: false, min: 0, max: 1)]
        public storage_profile_image_reference[] @StorageProfileImageReference { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "zones", @out: false, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
