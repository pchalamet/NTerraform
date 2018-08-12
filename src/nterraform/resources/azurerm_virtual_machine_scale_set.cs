using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine_scale_set")]
    public sealed class azurerm_virtual_machine_scale_set : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_profile_data_disk")]
        public sealed class storage_profile_data_disk : nterraform.Core.structure
        {
            public storage_profile_data_disk(string @createOption,
                                             int @lun)
            {
                @CreateOption = @createOption;
                @Lun = @lun;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "create_option", @out: false, min: 1, max: 1)]
            public string @CreateOption { get; }

            [nterraform.Core.TerraformProperty(name: "lun", @out: false, min: 1, max: 1)]
            public int @Lun { get; }

            [nterraform.Core.TerraformProperty(name: "caching", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Caching { get; }

            [nterraform.Core.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @DiskSizeGb { get; }

            [nterraform.Core.TerraformProperty(name: "managed_disk_type", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ManagedDiskType { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "os_profile")]
        public sealed class os_profile : nterraform.Core.structure
        {
            public os_profile(string @adminPassword,
                              string @adminUsername,
                              string @computerNamePrefix,
                              FSharpOption<string> @customData = null)
            {
                @AdminPassword = @adminPassword;
                @AdminUsername = @adminUsername;
                @ComputerNamePrefix = @computerNamePrefix;
                @CustomData = @customData;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "admin_password", @out: false, min: 1, max: 1)]
            public string @AdminPassword { get; }

            [nterraform.Core.TerraformProperty(name: "admin_username", @out: false, min: 1, max: 1)]
            public string @AdminUsername { get; }

            [nterraform.Core.TerraformProperty(name: "computer_name_prefix", @out: false, min: 1, max: 1)]
            public string @ComputerNamePrefix { get; }

            [nterraform.Core.TerraformProperty(name: "custom_data", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @CustomData { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "os_profile_secrets")]
        public sealed class os_profile_secrets : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "vault_certificates")]
            public sealed class vault_certificates : nterraform.Core.structure
            {
                public vault_certificates(string @certificateUrl,
                                          FSharpOption<string> @certificateStore = null)
                {
                    @CertificateUrl = @certificateUrl;
                    @CertificateStore = @certificateStore;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "certificate_url", @out: false, min: 1, max: 1)]
                public string @CertificateUrl { get; }

                [nterraform.Core.TerraformProperty(name: "certificate_store", @out: false, min: 0, max: 1)]
                public FSharpOption<string> @CertificateStore { get; }
            }

            public os_profile_secrets(string @sourceVaultId,
                                      FSharpOption<FSharpList<vault_certificates>> @vaultCertificates = null)
            {
                @SourceVaultId = @sourceVaultId;
                @VaultCertificates = @vaultCertificates ?? FSharpList<vault_certificates>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "source_vault_id", @out: false, min: 1, max: 1)]
            public string @SourceVaultId { get; }

            [nterraform.Core.TerraformProperty(name: "vault_certificates", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpList<vault_certificates>> @VaultCertificates { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "os_profile_windows_config")]
        public sealed class os_profile_windows_config : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "winrm")]
            public sealed class winrm : nterraform.Core.structure
            {
                public winrm(string @protocol,
                             FSharpOption<string> @certificateUrl = null)
                {
                    @Protocol = @protocol;
                    @CertificateUrl = @certificateUrl;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
                public string @Protocol { get; }

                [nterraform.Core.TerraformProperty(name: "certificate_url", @out: false, min: 0, max: 1)]
                public FSharpOption<string> @CertificateUrl { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "additional_unattend_config")]
            public sealed class additional_unattend_config : nterraform.Core.structure
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
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "component", @out: false, min: 1, max: 1)]
                public string @Component { get; }

                [nterraform.Core.TerraformProperty(name: "content", @out: false, min: 1, max: 1)]
                public string @Content { get; }

                [nterraform.Core.TerraformProperty(name: "pass", @out: false, min: 1, max: 1)]
                public string @Pass { get; }

                [nterraform.Core.TerraformProperty(name: "setting_name", @out: false, min: 1, max: 1)]
                public string @SettingName { get; }
            }

            public os_profile_windows_config(FSharpOption<FSharpList<additional_unattend_config>> @additionalUnattendConfig = null,
                                             FSharpOption<bool> @enableAutomaticUpgrades = null,
                                             FSharpOption<bool> @provisionVmAgent = null,
                                             FSharpOption<FSharpList<winrm>> @winrm = null)
            {
                @AdditionalUnattendConfig = @additionalUnattendConfig ?? FSharpList<additional_unattend_config>.Empty;
                @EnableAutomaticUpgrades = @enableAutomaticUpgrades;
                @ProvisionVmAgent = @provisionVmAgent;
                @Winrm = @winrm ?? FSharpList<winrm>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "additional_unattend_config", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpList<additional_unattend_config>> @AdditionalUnattendConfig { get; }

            [nterraform.Core.TerraformProperty(name: "enable_automatic_upgrades", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @EnableAutomaticUpgrades { get; }

            [nterraform.Core.TerraformProperty(name: "provision_vm_agent", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @ProvisionVmAgent { get; }

            [nterraform.Core.TerraformProperty(name: "winrm", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpList<winrm>> @Winrm { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "plan")]
        public sealed class plan : nterraform.Core.structure
        {
            public plan(string @name,
                        string @product,
                        string @publisher)
            {
                @Name = @name;
                @Product = @product;
                @Publisher = @publisher;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "product", @out: false, min: 1, max: 1)]
            public string @Product { get; }

            [nterraform.Core.TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
            public string @Publisher { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "network_profile")]
        public sealed class network_profile : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "dns_settings")]
            public sealed class dns_settings : nterraform.Core.structure
            {
                public dns_settings(FSharpList<string> @dnsServers)
                {
                    @DnsServers = @dnsServers;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "dns_servers", @out: false, min: 1, max: 1)]
                public FSharpList<string> @DnsServers { get; }
            }

            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ip_configuration")]
            public sealed class ip_configuration : nterraform.Core.structure
            {
                [nterraform.Core.TerraformStructure(category: "resource", typeName: "public_ip_address_configuration")]
                public sealed class public_ip_address_configuration : nterraform.Core.structure
                {
                    public public_ip_address_configuration(string @domainNameLabel,
                                                           int @idleTimeout,
                                                           string @name)
                    {
                        @DomainNameLabel = @domainNameLabel;
                        @IdleTimeout = @idleTimeout;
                        @Name = @name;
                        base._validate_();
                    }

                    [nterraform.Core.TerraformProperty(name: "domain_name_label", @out: false, min: 1, max: 1)]
                    public string @DomainNameLabel { get; }

                    [nterraform.Core.TerraformProperty(name: "idle_timeout", @out: false, min: 1, max: 1)]
                    public int @IdleTimeout { get; }

                    [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                    public string @Name { get; }
                }

                public ip_configuration(string @name,
                                        string @subnetId,
                                        FSharpOption<FSharpList<string>> @applicationGatewayBackendAddressPoolIds = null,
                                        FSharpOption<FSharpList<string>> @loadBalancerBackendAddressPoolIds = null,
                                        FSharpOption<bool> @primary = null,
                                        FSharpOption<FSharpList<public_ip_address_configuration>> @publicIpAddressConfiguration = null)
                {
                    @Name = @name;
                    @SubnetId = @subnetId;
                    @ApplicationGatewayBackendAddressPoolIds = @applicationGatewayBackendAddressPoolIds ?? FSharpList<string>.Empty;
                    @LoadBalancerBackendAddressPoolIds = @loadBalancerBackendAddressPoolIds ?? FSharpList<string>.Empty;
                    @Primary = @primary;
                    @PublicIpAddressConfiguration = @publicIpAddressConfiguration ?? FSharpList<public_ip_address_configuration>.Empty;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
                public string @Name { get; }

                [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
                public string @SubnetId { get; }

                [nterraform.Core.TerraformProperty(name: "application_gateway_backend_address_pool_ids", @out: false, min: 0, max: 1)]
                public FSharpOption<FSharpList<string>> @ApplicationGatewayBackendAddressPoolIds { get; }

                [nterraform.Core.TerraformProperty(name: "load_balancer_backend_address_pool_ids", @out: false, min: 0, max: 1)]
                public FSharpOption<FSharpList<string>> @LoadBalancerBackendAddressPoolIds { get; }

                [nterraform.Core.TerraformProperty(name: "load_balancer_inbound_nat_rules_ids", @out: true, min: 0, max: 1)]
                public FSharpOption<FSharpList<string>> @LoadBalancerInboundNatRulesIds { get; }

                [nterraform.Core.TerraformProperty(name: "primary", @out: false, min: 0, max: 1)]
                public FSharpOption<bool> @Primary { get; }

                [nterraform.Core.TerraformProperty(name: "public_ip_address_configuration", @out: false, min: 0, max: 1)]
                public FSharpOption<FSharpList<public_ip_address_configuration>> @PublicIpAddressConfiguration { get; }
            }

            public network_profile(FSharpList<ip_configuration> @ipConfiguration,
                                   string @name,
                                   bool @primary,
                                   FSharpOption<bool> @acceleratedNetworking = null,
                                   FSharpOption<FSharpList<dns_settings>> @dnsSettings = null,
                                   FSharpOption<bool> @ipForwarding = null,
                                   FSharpOption<string> @networkSecurityGroupId = null)
            {
                @IpConfiguration = @ipConfiguration;
                @Name = @name;
                @Primary = @primary;
                @AcceleratedNetworking = @acceleratedNetworking;
                @DnsSettings = @dnsSettings ?? FSharpList<dns_settings>.Empty;
                @IpForwarding = @ipForwarding;
                @NetworkSecurityGroupId = @networkSecurityGroupId;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "ip_configuration", @out: false, min: 1, max: 0)]
            public FSharpList<ip_configuration> @IpConfiguration { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "primary", @out: false, min: 1, max: 1)]
            public bool @Primary { get; }

            [nterraform.Core.TerraformProperty(name: "accelerated_networking", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @AcceleratedNetworking { get; }

            [nterraform.Core.TerraformProperty(name: "dns_settings", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<dns_settings>> @DnsSettings { get; }

            [nterraform.Core.TerraformProperty(name: "ip_forwarding", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @IpForwarding { get; }

            [nterraform.Core.TerraformProperty(name: "network_security_group_id", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @NetworkSecurityGroupId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
        {
            public sku(int @capacity,
                       string @name)
            {
                @Capacity = @capacity;
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public int @Capacity { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "tier", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Tier { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "identity")]
        public sealed class identity : nterraform.Core.structure
        {
            public identity(string @type,
                            FSharpOption<FSharpList<string>> @identityIds = null)
            {
                @Type = @type;
                @IdentityIds = @identityIds ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "identity_ids", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @IdentityIds { get; }

            [nterraform.Core.TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @PrincipalId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_profile_os_disk")]
        public sealed class storage_profile_os_disk : nterraform.Core.structure
        {
            public storage_profile_os_disk(string @createOption,
                                           FSharpOption<string> @image = null,
                                           FSharpOption<string> @name = null,
                                           FSharpOption<string> @osType = null,
                                           FSharpOption<FSharpList<string>> @vhdContainers = null)
            {
                @CreateOption = @createOption;
                @Image = @image;
                @Name = @name;
                @OsType = @osType;
                @VhdContainers = @vhdContainers ?? FSharpList<string>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "create_option", @out: false, min: 1, max: 1)]
            public string @CreateOption { get; }

            [nterraform.Core.TerraformProperty(name: "caching", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Caching { get; }

            [nterraform.Core.TerraformProperty(name: "image", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Image { get; }

            [nterraform.Core.TerraformProperty(name: "managed_disk_type", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @ManagedDiskType { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Name { get; }

            [nterraform.Core.TerraformProperty(name: "os_type", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @OsType { get; }

            [nterraform.Core.TerraformProperty(name: "vhd_containers", @out: false, min: 0, max: 1)]
            public FSharpOption<FSharpList<string>> @VhdContainers { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_profile_image_reference")]
        public sealed class storage_profile_image_reference : nterraform.Core.structure
        {
            public storage_profile_image_reference(FSharpOption<string> @id = null,
                                                   FSharpOption<string> @offer = null,
                                                   FSharpOption<string> @publisher = null,
                                                   FSharpOption<string> @sku = null,
                                                   FSharpOption<string> @version = null)
            {
                @Id = @id;
                @Offer = @offer;
                @Publisher = @publisher;
                @Sku = @sku;
                @Version = @version;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "id", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Id { get; }

            [nterraform.Core.TerraformProperty(name: "offer", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Offer { get; }

            [nterraform.Core.TerraformProperty(name: "publisher", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Publisher { get; }

            [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Sku { get; }

            [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Version { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "extension")]
        public sealed class extension : nterraform.Core.structure
        {
            public extension(string @name,
                             string @publisher,
                             string @type,
                             string @typeHandlerVersion,
                             FSharpOption<bool> @autoUpgradeMinorVersion = null,
                             FSharpOption<string> @protectedSettings = null,
                             FSharpOption<string> @settings = null)
            {
                @Name = @name;
                @Publisher = @publisher;
                @Type = @type;
                @TypeHandlerVersion = @typeHandlerVersion;
                @AutoUpgradeMinorVersion = @autoUpgradeMinorVersion;
                @ProtectedSettings = @protectedSettings;
                @Settings = @settings;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
            public string @Publisher { get; }

            [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.Core.TerraformProperty(name: "type_handler_version", @out: false, min: 1, max: 1)]
            public string @TypeHandlerVersion { get; }

            [nterraform.Core.TerraformProperty(name: "auto_upgrade_minor_version", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @AutoUpgradeMinorVersion { get; }

            [nterraform.Core.TerraformProperty(name: "protected_settings", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @ProtectedSettings { get; }

            [nterraform.Core.TerraformProperty(name: "settings", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Settings { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "os_profile_linux_config")]
        public sealed class os_profile_linux_config : nterraform.Core.structure
        {
            [nterraform.Core.TerraformStructure(category: "resource", typeName: "ssh_keys")]
            public sealed class ssh_keys : nterraform.Core.structure
            {
                public ssh_keys(string @path,
                                FSharpOption<string> @keyData = null)
                {
                    @Path = @path;
                    @KeyData = @keyData;
                    base._validate_();
                }

                [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
                public string @Path { get; }

                [nterraform.Core.TerraformProperty(name: "key_data", @out: false, min: 0, max: 1)]
                public FSharpOption<string> @KeyData { get; }
            }

            public os_profile_linux_config(FSharpOption<bool> @disablePasswordAuthentication = null,
                                           FSharpOption<FSharpList<ssh_keys>> @sshKeys = null)
            {
                @DisablePasswordAuthentication = @disablePasswordAuthentication;
                @SshKeys = @sshKeys ?? FSharpList<ssh_keys>.Empty;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "disable_password_authentication", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @DisablePasswordAuthentication { get; }

            [nterraform.Core.TerraformProperty(name: "ssh_keys", @out: false, min: 0, max: 0)]
            public FSharpOption<FSharpList<ssh_keys>> @SshKeys { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "boot_diagnostics")]
        public sealed class boot_diagnostics : nterraform.Core.structure
        {
            public boot_diagnostics(string @storageUri,
                                    FSharpOption<bool> @enabled = null)
            {
                @StorageUri = @storageUri;
                @Enabled = @enabled;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "storage_uri", @out: false, min: 1, max: 1)]
            public string @StorageUri { get; }

            [nterraform.Core.TerraformProperty(name: "enabled", @out: false, min: 0, max: 1)]
            public FSharpOption<bool> @Enabled { get; }
        }

        public azurerm_virtual_machine_scale_set(string @location,
                                                 string @name,
                                                 FSharpList<network_profile> @networkProfile,
                                                 FSharpList<os_profile> @osProfile,
                                                 string @resourceGroupName,
                                                 FSharpList<sku> @sku,
                                                 FSharpList<storage_profile_os_disk> @storageProfileOsDisk,
                                                 string @upgradePolicyMode,
                                                 FSharpOption<FSharpList<boot_diagnostics>> @bootDiagnostics = null,
                                                 FSharpOption<FSharpList<extension>> @extension = null,
                                                 FSharpOption<FSharpList<identity>> @identity = null,
                                                 FSharpOption<FSharpList<os_profile_linux_config>> @osProfileLinuxConfig = null,
                                                 FSharpOption<FSharpList<os_profile_secrets>> @osProfileSecrets = null,
                                                 FSharpOption<FSharpList<os_profile_windows_config>> @osProfileWindowsConfig = null,
                                                 FSharpOption<bool> @overprovision = null,
                                                 FSharpOption<FSharpList<plan>> @plan = null,
                                                 FSharpOption<string> @priority = null,
                                                 FSharpOption<bool> @singlePlacementGroup = null,
                                                 FSharpOption<FSharpList<storage_profile_data_disk>> @storageProfileDataDisk = null,
                                                 FSharpOption<FSharpList<storage_profile_image_reference>> @storageProfileImageReference = null,
                                                 FSharpOption<FSharpList<string>> @zones = null)
        {
            @Location = @location;
            @Name = @name;
            @NetworkProfile = @networkProfile;
            @OsProfile = @osProfile;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @StorageProfileOsDisk = @storageProfileOsDisk;
            @UpgradePolicyMode = @upgradePolicyMode;
            @BootDiagnostics = @bootDiagnostics ?? FSharpList<boot_diagnostics>.Empty;
            @Extension = @extension ?? FSharpList<extension>.Empty;
            @Identity = @identity ?? FSharpList<identity>.Empty;
            @OsProfileLinuxConfig = @osProfileLinuxConfig ?? FSharpList<os_profile_linux_config>.Empty;
            @OsProfileSecrets = @osProfileSecrets ?? FSharpList<os_profile_secrets>.Empty;
            @OsProfileWindowsConfig = @osProfileWindowsConfig ?? FSharpList<os_profile_windows_config>.Empty;
            @Overprovision = @overprovision;
            @Plan = @plan ?? FSharpList<plan>.Empty;
            @Priority = @priority;
            @SinglePlacementGroup = @singlePlacementGroup;
            @StorageProfileDataDisk = @storageProfileDataDisk ?? FSharpList<storage_profile_data_disk>.Empty;
            @StorageProfileImageReference = @storageProfileImageReference ?? FSharpList<storage_profile_image_reference>.Empty;
            @Zones = @zones ?? FSharpList<string>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "network_profile", @out: false, min: 1, max: 0)]
        public FSharpList<network_profile> @NetworkProfile { get; }

        [nterraform.Core.TerraformProperty(name: "os_profile", @out: false, min: 1, max: 1)]
        public FSharpList<os_profile> @OsProfile { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public FSharpList<sku> @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "storage_profile_os_disk", @out: false, min: 1, max: 1)]
        public FSharpList<storage_profile_os_disk> @StorageProfileOsDisk { get; }

        [nterraform.Core.TerraformProperty(name: "upgrade_policy_mode", @out: false, min: 1, max: 1)]
        public string @UpgradePolicyMode { get; }

        [nterraform.Core.TerraformProperty(name: "boot_diagnostics", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<boot_diagnostics>> @BootDiagnostics { get; }

        [nterraform.Core.TerraformProperty(name: "extension", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<extension>> @Extension { get; }

        [nterraform.Core.TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<identity>> @Identity { get; }

        [nterraform.Core.TerraformProperty(name: "license_type", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @LicenseType { get; }

        [nterraform.Core.TerraformProperty(name: "os_profile_linux_config", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<os_profile_linux_config>> @OsProfileLinuxConfig { get; }

        [nterraform.Core.TerraformProperty(name: "os_profile_secrets", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<os_profile_secrets>> @OsProfileSecrets { get; }

        [nterraform.Core.TerraformProperty(name: "os_profile_windows_config", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<os_profile_windows_config>> @OsProfileWindowsConfig { get; }

        [nterraform.Core.TerraformProperty(name: "overprovision", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @Overprovision { get; }

        [nterraform.Core.TerraformProperty(name: "plan", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<plan>> @Plan { get; }

        [nterraform.Core.TerraformProperty(name: "priority", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Priority { get; }

        [nterraform.Core.TerraformProperty(name: "single_placement_group", @out: false, min: 0, max: 1)]
        public FSharpOption<bool> @SinglePlacementGroup { get; }

        [nterraform.Core.TerraformProperty(name: "storage_profile_data_disk", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<storage_profile_data_disk>> @StorageProfileDataDisk { get; }

        [nterraform.Core.TerraformProperty(name: "storage_profile_image_reference", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<storage_profile_image_reference>> @StorageProfileImageReference { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "zones", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<string>> @Zones { get; }
    }

}
