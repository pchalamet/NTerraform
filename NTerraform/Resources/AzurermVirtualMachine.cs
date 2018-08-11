using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine")]
    public sealed class azurerm_virtual_machine : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "storage_image_reference")]
        public sealed class storage_image_reference
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

            [TerraformProperty(name: "id", @out: false, nested: false, min: 0, max: 1)]
            public string @Id { get; }

            [TerraformProperty(name: "offer", @out: false, nested: false, min: 0, max: 1)]
            public string @Offer { get; }

            [TerraformProperty(name: "publisher", @out: false, nested: false, min: 0, max: 1)]
            public string @Publisher { get; }

            [TerraformProperty(name: "sku", @out: false, nested: false, min: 0, max: 1)]
            public string @Sku { get; }

            [TerraformProperty(name: "version", @out: true, nested: false, min: 0, max: 1)]
            public string @Version { get; }
        }

        [TerraformStructure(category: "", typeName: "boot_diagnostics")]
        public sealed class boot_diagnostics
        {
            public boot_diagnostics(bool @enabled,
                                    string @storageUri)
            {
                @Enabled = @enabled;
                @StorageUri = @storageUri;
            }

            [TerraformProperty(name: "enabled", @out: false, nested: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [TerraformProperty(name: "storage_uri", @out: false, nested: false, min: 1, max: 1)]
            public string @StorageUri { get; }
        }

        [TerraformStructure(category: "", typeName: "os_profile")]
        public sealed class os_profile
        {
            public os_profile(string @adminUsername,
                              string @computerName,
                              string @adminPassword = null)
            {
                @AdminUsername = @adminUsername;
                @ComputerName = @computerName;
                @AdminPassword = @adminPassword;
            }

            [TerraformProperty(name: "admin_username", @out: false, nested: false, min: 1, max: 1)]
            public string @AdminUsername { get; }

            [TerraformProperty(name: "computer_name", @out: false, nested: false, min: 1, max: 1)]
            public string @ComputerName { get; }

            [TerraformProperty(name: "admin_password", @out: false, nested: false, min: 0, max: 1)]
            public string @AdminPassword { get; }

            [TerraformProperty(name: "custom_data", @out: true, nested: false, min: 0, max: 1)]
            public string @CustomData { get; }
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

            [TerraformProperty(name: "type", @out: false, nested: false, min: 1, max: 1)]
            public string @Type { get; }

            [TerraformProperty(name: "identity_ids", @out: false, nested: false, min: 0, max: 1)]
            public string[] @IdentityIds { get; }

            [TerraformProperty(name: "principal_id", @out: true, nested: false, min: 0, max: 1)]
            public string @PrincipalId { get; }
        }

        [TerraformStructure(category: "", typeName: "storage_os_disk")]
        public sealed class storage_os_disk
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

            [TerraformProperty(name: "create_option", @out: false, nested: false, min: 1, max: 1)]
            public string @CreateOption { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "caching", @out: true, nested: false, min: 0, max: 1)]
            public string @Caching { get; }

            [TerraformProperty(name: "disk_size_gb", @out: true, nested: false, min: 0, max: 1)]
            public int? @DiskSizeGb { get; }

            [TerraformProperty(name: "image_uri", @out: false, nested: false, min: 0, max: 1)]
            public string @ImageUri { get; }

            [TerraformProperty(name: "managed_disk_id", @out: true, nested: false, min: 0, max: 1)]
            public string @ManagedDiskId { get; }

            [TerraformProperty(name: "managed_disk_type", @out: true, nested: false, min: 0, max: 1)]
            public string @ManagedDiskType { get; }

            [TerraformProperty(name: "os_type", @out: true, nested: false, min: 0, max: 1)]
            public string @OsType { get; }

            [TerraformProperty(name: "vhd_uri", @out: false, nested: false, min: 0, max: 1)]
            public string @VhdUri { get; }

            [TerraformProperty(name: "write_accelerator_enabled", @out: false, nested: false, min: 0, max: 1)]
            public bool? @WriteAcceleratorEnabled { get; }
        }

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

                [TerraformProperty(name: "protocol", @out: false, nested: false, min: 1, max: 1)]
                public string @Protocol { get; }

                [TerraformProperty(name: "certificate_url", @out: false, nested: false, min: 0, max: 1)]
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

                [TerraformProperty(name: "component", @out: false, nested: false, min: 1, max: 1)]
                public string @Component { get; }

                [TerraformProperty(name: "content", @out: false, nested: false, min: 1, max: 1)]
                public string @Content { get; }

                [TerraformProperty(name: "pass", @out: false, nested: false, min: 1, max: 1)]
                public string @Pass { get; }

                [TerraformProperty(name: "setting_name", @out: false, nested: false, min: 1, max: 1)]
                public string @SettingName { get; }
            }

            public os_profile_windows_config(additional_unattend_config[] @additionalUnattendConfig = null,
                                             bool? @enableAutomaticUpgrades = null,
                                             bool? @provisionVmAgent = null,
                                             string @timezone = null,
                                             winrm[] @winrm = null)
            {
                @AdditionalUnattendConfig = @additionalUnattendConfig;
                @EnableAutomaticUpgrades = @enableAutomaticUpgrades;
                @ProvisionVmAgent = @provisionVmAgent;
                @Timezone = @timezone;
                @Winrm = @winrm;
            }

            [TerraformProperty(name: "additional_unattend_config", @out: false, nested: false, min: 0, max: 0)]
            public additional_unattend_config[] @AdditionalUnattendConfig { get; }

            [TerraformProperty(name: "enable_automatic_upgrades", @out: false, nested: false, min: 0, max: 1)]
            public bool? @EnableAutomaticUpgrades { get; }

            [TerraformProperty(name: "provision_vm_agent", @out: false, nested: false, min: 0, max: 1)]
            public bool? @ProvisionVmAgent { get; }

            [TerraformProperty(name: "timezone", @out: false, nested: false, min: 0, max: 1)]
            public string @Timezone { get; }

            [TerraformProperty(name: "winrm", @out: false, nested: false, min: 0, max: 0)]
            public winrm[] @Winrm { get; }
        }

        [TerraformStructure(category: "", typeName: "os_profile_linux_config")]
        public sealed class os_profile_linux_config
        {
            [TerraformStructure(category: "", typeName: "ssh_keys")]
            public sealed class ssh_keys
            {
                public ssh_keys(string @keyData,
                                string @path)
                {
                    @KeyData = @keyData;
                    @Path = @path;
                }

                [TerraformProperty(name: "key_data", @out: false, nested: false, min: 1, max: 1)]
                public string @KeyData { get; }

                [TerraformProperty(name: "path", @out: false, nested: false, min: 1, max: 1)]
                public string @Path { get; }
            }

            public os_profile_linux_config(bool @disablePasswordAuthentication,
                                           ssh_keys[] @sshKeys = null)
            {
                @DisablePasswordAuthentication = @disablePasswordAuthentication;
                @SshKeys = @sshKeys;
            }

            [TerraformProperty(name: "disable_password_authentication", @out: false, nested: false, min: 1, max: 1)]
            public bool @DisablePasswordAuthentication { get; }

            [TerraformProperty(name: "ssh_keys", @out: false, nested: false, min: 0, max: 0)]
            public ssh_keys[] @SshKeys { get; }
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

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "product", @out: false, nested: false, min: 1, max: 1)]
            public string @Product { get; }

            [TerraformProperty(name: "publisher", @out: false, nested: false, min: 1, max: 1)]
            public string @Publisher { get; }
        }

        [TerraformStructure(category: "", typeName: "storage_data_disk")]
        public sealed class storage_data_disk
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

            [TerraformProperty(name: "create_option", @out: false, nested: false, min: 1, max: 1)]
            public string @CreateOption { get; }

            [TerraformProperty(name: "lun", @out: false, nested: false, min: 1, max: 1)]
            public int @Lun { get; }

            [TerraformProperty(name: "name", @out: false, nested: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "caching", @out: true, nested: false, min: 0, max: 1)]
            public string @Caching { get; }

            [TerraformProperty(name: "disk_size_gb", @out: true, nested: false, min: 0, max: 1)]
            public int? @DiskSizeGb { get; }

            [TerraformProperty(name: "managed_disk_id", @out: true, nested: false, min: 0, max: 1)]
            public string @ManagedDiskId { get; }

            [TerraformProperty(name: "managed_disk_type", @out: true, nested: false, min: 0, max: 1)]
            public string @ManagedDiskType { get; }

            [TerraformProperty(name: "vhd_uri", @out: false, nested: false, min: 0, max: 1)]
            public string @VhdUri { get; }

            [TerraformProperty(name: "write_accelerator_enabled", @out: false, nested: false, min: 0, max: 1)]
            public bool? @WriteAcceleratorEnabled { get; }
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

                [TerraformProperty(name: "certificate_url", @out: false, nested: false, min: 1, max: 1)]
                public string @CertificateUrl { get; }

                [TerraformProperty(name: "certificate_store", @out: false, nested: false, min: 0, max: 1)]
                public string @CertificateStore { get; }
            }

            public os_profile_secrets(string @sourceVaultId,
                                      vault_certificates[] @vaultCertificates = null)
            {
                @SourceVaultId = @sourceVaultId;
                @VaultCertificates = @vaultCertificates;
            }

            [TerraformProperty(name: "source_vault_id", @out: false, nested: false, min: 1, max: 1)]
            public string @SourceVaultId { get; }

            [TerraformProperty(name: "vault_certificates", @out: false, nested: false, min: 0, max: 0)]
            public vault_certificates[] @VaultCertificates { get; }
        }

        public azurerm_virtual_machine(string @location,
                                       string @name,
                                       string[] @networkInterfaceIds,
                                       string @resourceGroupName,
                                       storage_os_disk[] @storageOsDisk,
                                       string @vmSize,
                                       boot_diagnostics[] @bootDiagnostics = null,
                                       bool? @deleteDataDisksOnTermination = null,
                                       bool? @deleteOsDiskOnTermination = null,
                                       identity[] @identity = null,
                                       os_profile[] @osProfile = null,
                                       os_profile_linux_config[] @osProfileLinuxConfig = null,
                                       os_profile_secrets[] @osProfileSecrets = null,
                                       os_profile_windows_config[] @osProfileWindowsConfig = null,
                                       plan[] @plan = null,
                                       string @primaryNetworkInterfaceId = null,
                                       storage_data_disk[] @storageDataDisk = null,
                                       storage_image_reference[] @storageImageReference = null,
                                       string[] @zones = null)
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

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "network_interface_ids", @out: false, nested: true, min: 1, max: 1)]
        public string[] @NetworkInterfaceIds { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "storage_os_disk", @out: false, nested: true, min: 1, max: 1)]
        public storage_os_disk[] @StorageOsDisk { get; }

        [TerraformProperty(name: "vm_size", @out: false, nested: true, min: 1, max: 1)]
        public string @VmSize { get; }

        [TerraformProperty(name: "availability_set_id", @out: true, nested: true, min: 0, max: 1)]
        public string @AvailabilitySetId { get; }

        [TerraformProperty(name: "boot_diagnostics", @out: false, nested: true, min: 0, max: 1)]
        public boot_diagnostics[] @BootDiagnostics { get; }

        [TerraformProperty(name: "delete_data_disks_on_termination", @out: false, nested: true, min: 0, max: 1)]
        public bool? @DeleteDataDisksOnTermination { get; }

        [TerraformProperty(name: "delete_os_disk_on_termination", @out: false, nested: true, min: 0, max: 1)]
        public bool? @DeleteOsDiskOnTermination { get; }

        [TerraformProperty(name: "identity", @out: false, nested: true, min: 0, max: 1)]
        public identity[] @Identity { get; }

        [TerraformProperty(name: "license_type", @out: true, nested: true, min: 0, max: 1)]
        public string @LicenseType { get; }

        [TerraformProperty(name: "os_profile", @out: false, nested: true, min: 0, max: 1)]
        public os_profile[] @OsProfile { get; }

        [TerraformProperty(name: "os_profile_linux_config", @out: false, nested: true, min: 0, max: 1)]
        public os_profile_linux_config[] @OsProfileLinuxConfig { get; }

        [TerraformProperty(name: "os_profile_secrets", @out: false, nested: true, min: 0, max: 0)]
        public os_profile_secrets[] @OsProfileSecrets { get; }

        [TerraformProperty(name: "os_profile_windows_config", @out: false, nested: true, min: 0, max: 1)]
        public os_profile_windows_config[] @OsProfileWindowsConfig { get; }

        [TerraformProperty(name: "plan", @out: false, nested: true, min: 0, max: 1)]
        public plan[] @Plan { get; }

        [TerraformProperty(name: "primary_network_interface_id", @out: false, nested: true, min: 0, max: 1)]
        public string @PrimaryNetworkInterfaceId { get; }

        [TerraformProperty(name: "storage_data_disk", @out: false, nested: true, min: 0, max: 0)]
        public storage_data_disk[] @StorageDataDisk { get; }

        [TerraformProperty(name: "storage_image_reference", @out: false, nested: true, min: 0, max: 1)]
        public storage_image_reference[] @StorageImageReference { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [TerraformProperty(name: "zones", @out: false, nested: true, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
