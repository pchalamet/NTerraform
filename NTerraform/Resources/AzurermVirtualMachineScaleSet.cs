using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_virtual_machine_scale_set : NTerraform.resource
    {
        public class storage_profile_data_disk
        {
            public storage_profile_data_disk(string @createOption,
                                             int @lun)
            {
                @CreateOption = @createOption;
                @Lun = @lun;
            }

            public string @CreateOption { get; }
            public int @Lun { get; }
            public string @Caching { get; }
            public int? @DiskSizeGb { get; }
            public string @ManagedDiskType { get; }
        }

        public class os_profile_secrets
        {
            public class vault_certificates
            {
                public vault_certificates(string @certificateUrl,
                                          string @certificateStore = null)
                {
                    @CertificateUrl = @certificateUrl;
                    @CertificateStore = @certificateStore;
                }

                public string @CertificateUrl { get; }
                public string @CertificateStore { get; }
            }

            public os_profile_secrets(string @sourceVaultId,
                                      vault_certificates[] @vaultCertificates = null)
            {
                @SourceVaultId = @sourceVaultId;
                @VaultCertificates = @vaultCertificates;
            }

            public string @SourceVaultId { get; }
            public vault_certificates[] @VaultCertificates { get; }
        }

        public class identity
        {
            public identity(string @type,
                            string[] @identityIds = null)
            {
                @Type = @type;
                @IdentityIds = @identityIds;
            }

            public string @Type { get; }
            public string[] @IdentityIds { get; }
            public string @PrincipalId { get; }
        }

        public class os_profile
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

            public string @AdminPassword { get; }
            public string @AdminUsername { get; }
            public string @ComputerNamePrefix { get; }
            public string @CustomData { get; }
        }

        public class os_profile_windows_config
        {
            public class winrm
            {
                public winrm(string @protocol,
                             string @certificateUrl = null)
                {
                    @Protocol = @protocol;
                    @CertificateUrl = @certificateUrl;
                }

                public string @Protocol { get; }
                public string @CertificateUrl { get; }
            }

            public class additional_unattend_config
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

                public string @Component { get; }
                public string @Content { get; }
                public string @Pass { get; }
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

            public additional_unattend_config[] @AdditionalUnattendConfig { get; }
            public bool? @EnableAutomaticUpgrades { get; }
            public bool? @ProvisionVmAgent { get; }
            public winrm[] @Winrm { get; }
        }

        public class network_profile
        {
            public class ip_configuration
            {
                public class public_ip_address_configuration
                {
                    public public_ip_address_configuration(string @domainNameLabel,
                                                           int @idleTimeout,
                                                           string @name)
                    {
                        @DomainNameLabel = @domainNameLabel;
                        @IdleTimeout = @idleTimeout;
                        @Name = @name;
                    }

                    public string @DomainNameLabel { get; }
                    public int @IdleTimeout { get; }
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

                public string @Name { get; }
                public string @SubnetId { get; }
                public string[] @ApplicationGatewayBackendAddressPoolIds { get; }
                public string[] @LoadBalancerBackendAddressPoolIds { get; }
                public string[] @LoadBalancerInboundNatRulesIds { get; }
                public bool? @Primary { get; }
                public public_ip_address_configuration[] @PublicIpAddressConfiguration { get; }
            }

            public class dns_settings
            {
                public dns_settings(string[] @dnsServers)
                {
                    @DnsServers = @dnsServers;
                }

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

            public ip_configuration[] @IpConfiguration { get; }
            public string @Name { get; }
            public bool @Primary { get; }
            public bool? @AcceleratedNetworking { get; }
            public dns_settings[] @DnsSettings { get; }
            public bool? @IpForwarding { get; }
            public string @NetworkSecurityGroupId { get; }
        }

        public class plan
        {
            public plan(string @name,
                        string @product,
                        string @publisher)
            {
                @Name = @name;
                @Product = @product;
                @Publisher = @publisher;
            }

            public string @Name { get; }
            public string @Product { get; }
            public string @Publisher { get; }
        }

        public class os_profile_linux_config
        {
            public class ssh_keys
            {
                public ssh_keys(string @path,
                                string @keyData = null)
                {
                    @Path = @path;
                    @KeyData = @keyData;
                }

                public string @Path { get; }
                public string @KeyData { get; }
            }

            public os_profile_linux_config(bool? @disablePasswordAuthentication = null,
                                           ssh_keys[] @sshKeys = null)
            {
                @DisablePasswordAuthentication = @disablePasswordAuthentication;
                @SshKeys = @sshKeys;
            }

            public bool? @DisablePasswordAuthentication { get; }
            public ssh_keys[] @SshKeys { get; }
        }

        public class sku
        {
            public sku(int @capacity,
                       string @name)
            {
                @Capacity = @capacity;
                @Name = @name;
            }

            public int @Capacity { get; }
            public string @Name { get; }
            public string @Tier { get; }
        }

        public class boot_diagnostics
        {
            public boot_diagnostics(string @storageUri,
                                    bool? @enabled = null)
            {
                @StorageUri = @storageUri;
                @Enabled = @enabled;
            }

            public string @StorageUri { get; }
            public bool? @Enabled { get; }
        }

        public class storage_profile_image_reference
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

            public string @Id { get; }
            public string @Offer { get; }
            public string @Publisher { get; }
            public string @Sku { get; }
            public string @Version { get; }
        }

        public class extension
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

            public string @Name { get; }
            public string @Publisher { get; }
            public string @Type { get; }
            public string @TypeHandlerVersion { get; }
            public bool? @AutoUpgradeMinorVersion { get; }
            public string @ProtectedSettings { get; }
            public string @Settings { get; }
        }

        public class storage_profile_os_disk
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

            public string @CreateOption { get; }
            public string @Caching { get; }
            public string @Image { get; }
            public string @ManagedDiskType { get; }
            public string @Name { get; }
            public string @OsType { get; }
            public string[] @VhdContainers { get; }
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

        public string @Location { get; }
        public string @Name { get; }
        public network_profile[] @NetworkProfile { get; }
        public os_profile[] @OsProfile { get; }
        public string @ResourceGroupName { get; }
        public sku[] @Sku { get; }
        public storage_profile_os_disk[] @StorageProfileOsDisk { get; }
        public string @UpgradePolicyMode { get; }
        public boot_diagnostics[] @BootDiagnostics { get; }
        public extension[] @Extension { get; }
        public identity[] @Identity { get; }
        public string @LicenseType { get; }
        public os_profile_linux_config[] @OsProfileLinuxConfig { get; }
        public os_profile_secrets[] @OsProfileSecrets { get; }
        public os_profile_windows_config[] @OsProfileWindowsConfig { get; }
        public bool? @Overprovision { get; }
        public plan[] @Plan { get; }
        public string @Priority { get; }
        public bool? @SinglePlacementGroup { get; }
        public storage_profile_data_disk[] @StorageProfileDataDisk { get; }
        public storage_profile_image_reference[] @StorageProfileImageReference { get; }
        public Dictionary<string,string> @Tags { get; }
        public string[] @Zones { get; }
    }

}
