using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_virtual_machine : NTerraform.resource
    {
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

        public class storage_data_disk
        {
            public storage_data_disk(string @createOption,
                                     int @lun,
                                     string @name,
                                     string @vhdUri = null,
                                     bool? @writeAcceleratorEnabled = null)
            {
                @CreateOption = @createOption;
                @Lun = @lun;
                @Name = @name;
                @VhdUri = @vhdUri;
                @WriteAcceleratorEnabled = @writeAcceleratorEnabled;
            }

            public string @CreateOption { get; }
            public int @Lun { get; }
            public string @Name { get; }
            public string @Caching { get; }
            public int? @DiskSizeGb { get; }
            public string @ManagedDiskId { get; }
            public string @ManagedDiskType { get; }
            public string @VhdUri { get; }
            public bool? @WriteAcceleratorEnabled { get; }
        }

        public class os_profile
        {
            public os_profile(string @adminUsername,
                              string @computerName,
                              string @adminPassword = null)
            {
                @AdminUsername = @adminUsername;
                @ComputerName = @computerName;
                @AdminPassword = @adminPassword;
            }

            public string @AdminUsername { get; }
            public string @ComputerName { get; }
            public string @AdminPassword { get; }
            public string @CustomData { get; }
        }

        public class os_profile_linux_config
        {
            public class ssh_keys
            {
                public ssh_keys(string @keyData,
                                string @path)
                {
                    @KeyData = @keyData;
                    @Path = @path;
                }

                public string @KeyData { get; }
                public string @Path { get; }
            }

            public os_profile_linux_config(bool @disablePasswordAuthentication,
                                           List<ssh_keys> @sshKeys = null)
            {
                @DisablePasswordAuthentication = @disablePasswordAuthentication;
                @SshKeys = @sshKeys;
            }

            public bool @DisablePasswordAuthentication { get; }
            public List<ssh_keys> @SshKeys { get; }
        }

        public class identity
        {
            public identity(string @type,
                            List<string> @identityIds = null)
            {
                @Type = @type;
                @IdentityIds = @identityIds;
            }

            public string @Type { get; }
            public List<string> @IdentityIds { get; }
            public string @PrincipalId { get; }
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
                                      List<vault_certificates> @vaultCertificates = null)
            {
                @SourceVaultId = @sourceVaultId;
                @VaultCertificates = @vaultCertificates;
            }

            public string @SourceVaultId { get; }
            public List<vault_certificates> @VaultCertificates { get; }
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

            public os_profile_windows_config(List<additional_unattend_config> @additionalUnattendConfig = null,
                                             bool? @enableAutomaticUpgrades = null,
                                             bool? @provisionVmAgent = null,
                                             string @timezone = null,
                                             List<winrm> @winrm = null)
            {
                @AdditionalUnattendConfig = @additionalUnattendConfig;
                @EnableAutomaticUpgrades = @enableAutomaticUpgrades;
                @ProvisionVmAgent = @provisionVmAgent;
                @Timezone = @timezone;
                @Winrm = @winrm;
            }

            public List<additional_unattend_config> @AdditionalUnattendConfig { get; }
            public bool? @EnableAutomaticUpgrades { get; }
            public bool? @ProvisionVmAgent { get; }
            public string @Timezone { get; }
            public List<winrm> @Winrm { get; }
        }

        public class boot_diagnostics
        {
            public boot_diagnostics(bool @enabled,
                                    string @storageUri)
            {
                @Enabled = @enabled;
                @StorageUri = @storageUri;
            }

            public bool @Enabled { get; }
            public string @StorageUri { get; }
        }

        public class storage_image_reference
        {
            public storage_image_reference(string @id = null,
                                           string @offer = null,
                                           string @publisher = null,
                                           string @sku = null)
            {
                @Id = @id;
                @Offer = @offer;
                @Publisher = @publisher;
                @Sku = @sku;
            }

            public string @Id { get; }
            public string @Offer { get; }
            public string @Publisher { get; }
            public string @Sku { get; }
            public string @Version { get; }
        }

        public class storage_os_disk
        {
            public storage_os_disk(string @createOption,
                                   string @name,
                                   string @imageUri = null,
                                   string @vhdUri = null,
                                   bool? @writeAcceleratorEnabled = null)
            {
                @CreateOption = @createOption;
                @Name = @name;
                @ImageUri = @imageUri;
                @VhdUri = @vhdUri;
                @WriteAcceleratorEnabled = @writeAcceleratorEnabled;
            }

            public string @CreateOption { get; }
            public string @Name { get; }
            public string @Caching { get; }
            public int? @DiskSizeGb { get; }
            public string @ImageUri { get; }
            public string @ManagedDiskId { get; }
            public string @ManagedDiskType { get; }
            public string @OsType { get; }
            public string @VhdUri { get; }
            public bool? @WriteAcceleratorEnabled { get; }
        }

        public azurerm_virtual_machine(string @location,
                                       string @name,
                                       List<string> @networkInterfaceIds,
                                       string @resourceGroupName,
                                       List<storage_os_disk> @storageOsDisk,
                                       string @vmSize,
                                       List<boot_diagnostics> @bootDiagnostics = null,
                                       bool? @deleteDataDisksOnTermination = null,
                                       bool? @deleteOsDiskOnTermination = null,
                                       List<identity> @identity = null,
                                       HashSet<os_profile> @osProfile = null,
                                       HashSet<os_profile_linux_config> @osProfileLinuxConfig = null,
                                       List<os_profile_secrets> @osProfileSecrets = null,
                                       HashSet<os_profile_windows_config> @osProfileWindowsConfig = null,
                                       List<plan> @plan = null,
                                       string @primaryNetworkInterfaceId = null,
                                       List<storage_data_disk> @storageDataDisk = null,
                                       HashSet<storage_image_reference> @storageImageReference = null,
                                       List<string> @zones = null)
        {
            @Location = @location;
            @Name = @name;
            @NetworkInterfaceIds = @networkInterfaceIds;
            @ResourceGroupName = @resourceGroupName;
            @StorageOsDisk = @storageOsDisk;
            @VmSize = @vmSize;
            @BootDiagnostics = @bootDiagnostics;
            @DeleteDataDisksOnTermination = @deleteDataDisksOnTermination;
            @DeleteOsDiskOnTermination = @deleteOsDiskOnTermination;
            @Identity = @identity;
            @OsProfile = @osProfile;
            @OsProfileLinuxConfig = @osProfileLinuxConfig;
            @OsProfileSecrets = @osProfileSecrets;
            @OsProfileWindowsConfig = @osProfileWindowsConfig;
            @Plan = @plan;
            @PrimaryNetworkInterfaceId = @primaryNetworkInterfaceId;
            @StorageDataDisk = @storageDataDisk;
            @StorageImageReference = @storageImageReference;
            @Zones = @zones;
        }

        public string @Location { get; }
        public string @Name { get; }
        public List<string> @NetworkInterfaceIds { get; }
        public string @ResourceGroupName { get; }
        public List<storage_os_disk> @StorageOsDisk { get; }
        public string @VmSize { get; }
        public string @AvailabilitySetId { get; }
        public List<boot_diagnostics> @BootDiagnostics { get; }
        public bool? @DeleteDataDisksOnTermination { get; }
        public bool? @DeleteOsDiskOnTermination { get; }
        public List<identity> @Identity { get; }
        public string @LicenseType { get; }
        public HashSet<os_profile> @OsProfile { get; }
        public HashSet<os_profile_linux_config> @OsProfileLinuxConfig { get; }
        public List<os_profile_secrets> @OsProfileSecrets { get; }
        public HashSet<os_profile_windows_config> @OsProfileWindowsConfig { get; }
        public List<plan> @Plan { get; }
        public string @PrimaryNetworkInterfaceId { get; }
        public List<storage_data_disk> @StorageDataDisk { get; }
        public HashSet<storage_image_reference> @StorageImageReference { get; }
        public Dictionary<string,string> @Tags { get; }
        public List<string> @Zones { get; }
    }

}
