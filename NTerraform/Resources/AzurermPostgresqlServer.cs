using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_postgresql_server")]
    public sealed class azurerm_postgresql_server : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "sku")]
        public sealed class sku
        {
            public sku(int @capacity,
                       string @family,
                       string @name,
                       string @tier)
            {
                @Capacity = @capacity;
                @Family = @family;
                @Name = @name;
                @Tier = @tier;
            }

            [TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public int @Capacity { get; }

            [TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
            public string @Family { get; }

            [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [TerraformProperty(name: "tier", @out: false, min: 1, max: 1)]
            public string @Tier { get; }
        }

        [TerraformStructure(category: "", typeName: "storage_profile")]
        public sealed class storage_profile
        {
            public storage_profile(int @storageMb,
                                   int? @backupRetentionDays = null,
                                   string @geoRedundantBackup = null)
            {
                @StorageMb = @storageMb;
                @BackupRetentionDays = @backupRetentionDays;
                @GeoRedundantBackup = @geoRedundantBackup;
            }

            [TerraformProperty(name: "storage_mb", @out: false, min: 1, max: 1)]
            public int @StorageMb { get; }

            [TerraformProperty(name: "backup_retention_days", @out: false, min: 0, max: 1)]
            public int? @BackupRetentionDays { get; }

            [TerraformProperty(name: "geo_redundant_backup", @out: false, min: 0, max: 1)]
            public string @GeoRedundantBackup { get; }
        }

        public azurerm_postgresql_server(string @administratorLogin,
                                         string @administratorLoginPassword,
                                         string @location,
                                         string @name,
                                         string @resourceGroupName,
                                         sku[] @sku,
                                         string @sslEnforcement,
                                         storage_profile[] @storageProfile,
                                         string @version)
        {
            @AdministratorLogin = @administratorLogin;
            @AdministratorLoginPassword = @administratorLoginPassword;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @SslEnforcement = @sslEnforcement;
            @StorageProfile = @storageProfile;
            @Version = @version;
        }

        [TerraformProperty(name: "administrator_login", @out: false, min: 1, max: 1)]
        public string @AdministratorLogin { get; }

        [TerraformProperty(name: "administrator_login_password", @out: false, min: 1, max: 1)]
        public string @AdministratorLoginPassword { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [TerraformProperty(name: "ssl_enforcement", @out: false, min: 1, max: 1)]
        public string @SslEnforcement { get; }

        [TerraformProperty(name: "storage_profile", @out: false, min: 1, max: 1)]
        public storage_profile[] @StorageProfile { get; }

        [TerraformProperty(name: "version", @out: false, min: 1, max: 1)]
        public string @Version { get; }

        [TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
