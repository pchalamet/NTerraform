using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine")]
    public sealed class azurerm_virtual_machine : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "os_profile")]
        public sealed class os_profile : nterraform.structure
        {
            public os_profile(string @adminUsername,
                              string @computerName,
                              string @adminPassword = null)
            {
                @AdminUsername = @adminUsername;
                @ComputerName = @computerName;
                @AdminPassword = @adminPassword;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "admin_username", @out: false, min: 1, max: 1)]
            public string @AdminUsername { get; }

            [nterraform.TerraformProperty(name: "computer_name", @out: false, min: 1, max: 1)]
            public string @ComputerName { get; }

            [nterraform.TerraformProperty(name: "admin_password", @out: false, min: 0, max: 1)]
            public string @AdminPassword { get; }

            [nterraform.TerraformProperty(name: "custom_data", @out: true, min: 0, max: 1)]
            public string @CustomData { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "plan")]
        public sealed class plan : nterraform.structure
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

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "product", @out: false, min: 1, max: 1)]
            public string @Product { get; }

            [nterraform.TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
            public string @Publisher { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "storage_os_disk")]
        public sealed class storage_os_disk : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "create_option", @out: false, min: 1, max: 1)]
            public string @CreateOption { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "caching", @out: true, min: 0, max: 1)]
            public string @Caching { get; }

            [nterraform.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
            public int? @DiskSizeGb { get; }

            [nterraform.TerraformProperty(name: "image_uri", @out: false, min: 0, max: 1)]
            public string @ImageUri { get; }

            [nterraform.TerraformProperty(name: "managed_disk_id", @out: true, min: 0, max: 1)]
            public string @ManagedDiskId { get; }

            [nterraform.TerraformProperty(name: "managed_disk_type", @out: true, min: 0, max: 1)]
            public string @ManagedDiskType { get; }

            [nterraform.TerraformProperty(name: "os_type", @out: true, min: 0, max: 1)]
            public string @OsType { get; }

            [nterraform.TerraformProperty(name: "vhd_uri", @out: false, min: 0, max: 1)]
            public string @VhdUri { get; }

            [nterraform.TerraformProperty(name: "write_accelerator_enabled", @out: false, min: 0, max: 1)]
            public bool? @WriteAcceleratorEnabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "os_profile_windows_config")]
        public sealed class os_profile_windows_config : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "winrm")]
            public sealed class winrm : nterraform.structure
            {
                public winrm(string @protocol,
                             string @certificateUrl = null)
                {
                    @Protocol = @protocol;
                    @CertificateUrl = @certificateUrl;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "protocol", @out: false, min: 1, max: 1)]
                public string @Protocol { get; }

                [nterraform.TerraformProperty(name: "certificate_url", @out: false, min: 0, max: 1)]
                public string @CertificateUrl { get; }
            }

            [nterraform.TerraformStructure(category: "resource", typeName: "additional_unattend_config")]
            public sealed class additional_unattend_config : nterraform.structure
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

                [nterraform.TerraformProperty(name: "component", @out: false, min: 1, max: 1)]
                public string @Component { get; }

                [nterraform.TerraformProperty(name: "content", @out: false, min: 1, max: 1)]
                public string @Content { get; }

                [nterraform.TerraformProperty(name: "pass", @out: false, min: 1, max: 1)]
                public string @Pass { get; }

                [nterraform.TerraformProperty(name: "setting_name", @out: false, min: 1, max: 1)]
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "additional_unattend_config", @out: false, min: 0, max: 0)]
            public additional_unattend_config[] @AdditionalUnattendConfig { get; }

            [nterraform.TerraformProperty(name: "enable_automatic_upgrades", @out: false, min: 0, max: 1)]
            public bool? @EnableAutomaticUpgrades { get; }

            [nterraform.TerraformProperty(name: "provision_vm_agent", @out: false, min: 0, max: 1)]
            public bool? @ProvisionVmAgent { get; }

            [nterraform.TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
            public string @Timezone { get; }

            [nterraform.TerraformProperty(name: "winrm", @out: false, min: 0, max: 0)]
            public winrm[] @Winrm { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "os_profile_linux_config")]
        public sealed class os_profile_linux_config : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "ssh_keys")]
            public sealed class ssh_keys : nterraform.structure
            {
                public ssh_keys(string @keyData,
                                string @path)
                {
                    @KeyData = @keyData;
                    @Path = @path;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "key_data", @out: false, min: 1, max: 1)]
                public string @KeyData { get; }

                [nterraform.TerraformProperty(name: "path", @out: false, min: 1, max: 1)]
                public string @Path { get; }
            }

            public os_profile_linux_config(bool @disablePasswordAuthentication,
                                           ssh_keys[] @sshKeys = null)
            {
                @DisablePasswordAuthentication = @disablePasswordAuthentication;
                @SshKeys = @sshKeys;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "disable_password_authentication", @out: false, min: 1, max: 1)]
            public bool @DisablePasswordAuthentication { get; }

            [nterraform.TerraformProperty(name: "ssh_keys", @out: false, min: 0, max: 0)]
            public ssh_keys[] @SshKeys { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "storage_image_reference")]
        public sealed class storage_image_reference : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "id", @out: false, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "offer", @out: false, min: 0, max: 1)]
            public string @Offer { get; }

            [nterraform.TerraformProperty(name: "publisher", @out: false, min: 0, max: 1)]
            public string @Publisher { get; }

            [nterraform.TerraformProperty(name: "sku", @out: false, min: 0, max: 1)]
            public string @Sku { get; }

            [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
            public string @Version { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "storage_data_disk")]
        public sealed class storage_data_disk : nterraform.structure
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
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "create_option", @out: false, min: 1, max: 1)]
            public string @CreateOption { get; }

            [nterraform.TerraformProperty(name: "lun", @out: false, min: 1, max: 1)]
            public int @Lun { get; }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "caching", @out: true, min: 0, max: 1)]
            public string @Caching { get; }

            [nterraform.TerraformProperty(name: "disk_size_gb", @out: true, min: 0, max: 1)]
            public int? @DiskSizeGb { get; }

            [nterraform.TerraformProperty(name: "managed_disk_id", @out: true, min: 0, max: 1)]
            public string @ManagedDiskId { get; }

            [nterraform.TerraformProperty(name: "managed_disk_type", @out: true, min: 0, max: 1)]
            public string @ManagedDiskType { get; }

            [nterraform.TerraformProperty(name: "vhd_uri", @out: false, min: 0, max: 1)]
            public string @VhdUri { get; }

            [nterraform.TerraformProperty(name: "write_accelerator_enabled", @out: false, min: 0, max: 1)]
            public bool? @WriteAcceleratorEnabled { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "boot_diagnostics")]
        public sealed class boot_diagnostics : nterraform.structure
        {
            public boot_diagnostics(bool @enabled,
                                    string @storageUri)
            {
                @Enabled = @enabled;
                @StorageUri = @storageUri;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "enabled", @out: false, min: 1, max: 1)]
            public bool @Enabled { get; }

            [nterraform.TerraformProperty(name: "storage_uri", @out: false, min: 1, max: 1)]
            public string @StorageUri { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "identity")]
        public sealed class identity : nterraform.structure
        {
            public identity(string @type,
                            string[] @identityIds = null)
            {
                @Type = @type;
                @IdentityIds = @identityIds;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
            public string @Type { get; }

            [nterraform.TerraformProperty(name: "identity_ids", @out: false, min: 0, max: 1)]
            public string[] @IdentityIds { get; }

            [nterraform.TerraformProperty(name: "principal_id", @out: true, min: 0, max: 1)]
            public string @PrincipalId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "os_profile_secrets")]
        public sealed class os_profile_secrets : nterraform.structure
        {
            [nterraform.TerraformStructure(category: "resource", typeName: "vault_certificates")]
            public sealed class vault_certificates : nterraform.structure
            {
                public vault_certificates(string @certificateUrl,
                                          string @certificateStore = null)
                {
                    @CertificateUrl = @certificateUrl;
                    @CertificateStore = @certificateStore;
                    base._validate_();
                }

                [nterraform.TerraformProperty(name: "certificate_url", @out: false, min: 1, max: 1)]
                public string @CertificateUrl { get; }

                [nterraform.TerraformProperty(name: "certificate_store", @out: false, min: 0, max: 1)]
                public string @CertificateStore { get; }
            }

            public os_profile_secrets(string @sourceVaultId,
                                      vault_certificates[] @vaultCertificates = null)
            {
                @SourceVaultId = @sourceVaultId;
                @VaultCertificates = @vaultCertificates;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "source_vault_id", @out: false, min: 1, max: 1)]
            public string @SourceVaultId { get; }

            [nterraform.TerraformProperty(name: "vault_certificates", @out: false, min: 0, max: 0)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "network_interface_ids", @out: false, min: 1, max: 1)]
        public string[] @NetworkInterfaceIds { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "storage_os_disk", @out: false, min: 1, max: 1)]
        public storage_os_disk[] @StorageOsDisk { get; }

        [nterraform.TerraformProperty(name: "vm_size", @out: false, min: 1, max: 1)]
        public string @VmSize { get; }

        [nterraform.TerraformProperty(name: "availability_set_id", @out: true, min: 0, max: 1)]
        public string @AvailabilitySetId { get; }

        [nterraform.TerraformProperty(name: "boot_diagnostics", @out: false, min: 0, max: 1)]
        public boot_diagnostics[] @BootDiagnostics { get; }

        [nterraform.TerraformProperty(name: "delete_data_disks_on_termination", @out: false, min: 0, max: 1)]
        public bool? @DeleteDataDisksOnTermination { get; }

        [nterraform.TerraformProperty(name: "delete_os_disk_on_termination", @out: false, min: 0, max: 1)]
        public bool? @DeleteOsDiskOnTermination { get; }

        [nterraform.TerraformProperty(name: "identity", @out: false, min: 0, max: 1)]
        public identity[] @Identity { get; }

        [nterraform.TerraformProperty(name: "license_type", @out: true, min: 0, max: 1)]
        public string @LicenseType { get; }

        [nterraform.TerraformProperty(name: "os_profile", @out: false, min: 0, max: 1)]
        public os_profile[] @OsProfile { get; }

        [nterraform.TerraformProperty(name: "os_profile_linux_config", @out: false, min: 0, max: 1)]
        public os_profile_linux_config[] @OsProfileLinuxConfig { get; }

        [nterraform.TerraformProperty(name: "os_profile_secrets", @out: false, min: 0, max: 0)]
        public os_profile_secrets[] @OsProfileSecrets { get; }

        [nterraform.TerraformProperty(name: "os_profile_windows_config", @out: false, min: 0, max: 1)]
        public os_profile_windows_config[] @OsProfileWindowsConfig { get; }

        [nterraform.TerraformProperty(name: "plan", @out: false, min: 0, max: 1)]
        public plan[] @Plan { get; }

        [nterraform.TerraformProperty(name: "primary_network_interface_id", @out: false, min: 0, max: 1)]
        public string @PrimaryNetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "storage_data_disk", @out: false, min: 0, max: 0)]
        public storage_data_disk[] @StorageDataDisk { get; }

        [nterraform.TerraformProperty(name: "storage_image_reference", @out: false, min: 0, max: 1)]
        public storage_image_reference[] @StorageImageReference { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "zones", @out: false, min: 0, max: 1)]
        public string[] @Zones { get; }
    }

}
