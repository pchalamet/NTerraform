using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_mysql_server")]
    public sealed class azurerm_mysql_server : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "storage_profile")]
        public sealed class storage_profile : nterraform.Core.structure
        {
            public storage_profile(int @storageMb,
                                   int? @backupRetentionDays = null,
                                   string @geoRedundantBackup = null)
            {
                @StorageMb = @storageMb;
                @BackupRetentionDays = @backupRetentionDays;
                @GeoRedundantBackup = @geoRedundantBackup;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "storage_mb", @out: false, min: 1, max: 1)]
            public int @StorageMb { get; }

            [nterraform.Core.TerraformProperty(name: "backup_retention_days", @out: false, min: 0, max: 1)]
            public int? @BackupRetentionDays { get; }

            [nterraform.Core.TerraformProperty(name: "geo_redundant_backup", @out: false, min: 0, max: 1)]
            public string @GeoRedundantBackup { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
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
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "capacity", @out: false, min: 1, max: 1)]
            public int @Capacity { get; }

            [nterraform.Core.TerraformProperty(name: "family", @out: false, min: 1, max: 1)]
            public string @Family { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "tier", @out: false, min: 1, max: 1)]
            public string @Tier { get; }
        }

        public azurerm_mysql_server(string @administratorLogin,
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "administrator_login", @out: false, min: 1, max: 1)]
        public string @AdministratorLogin { get; }

        [nterraform.Core.TerraformProperty(name: "administrator_login_password", @out: false, min: 1, max: 1)]
        public string @AdministratorLoginPassword { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public sku[] @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "ssl_enforcement", @out: false, min: 1, max: 1)]
        public string @SslEnforcement { get; }

        [nterraform.Core.TerraformProperty(name: "storage_profile", @out: false, min: 1, max: 1)]
        public storage_profile[] @StorageProfile { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 1, max: 1)]
        public string @Version { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
