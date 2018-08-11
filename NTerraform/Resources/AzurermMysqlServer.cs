using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_mysql_server : NTerraform.resource
    {
        public class sku
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

            public int @Capacity { get; }
            public string @Family { get; }
            public string @Name { get; }
            public string @Tier { get; }
        }

        public class storage_profile
        {
            public storage_profile(int @storageMb,
                                   int? @backupRetentionDays = null,
                                   string @geoRedundantBackup = null)
            {
                @StorageMb = @storageMb;
                @BackupRetentionDays = @backupRetentionDays;
                @GeoRedundantBackup = @geoRedundantBackup;
            }

            public int @StorageMb { get; }
            public int? @BackupRetentionDays { get; }
            public string @GeoRedundantBackup { get; }
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
        }

        public string @AdministratorLogin { get; }
        public string @AdministratorLoginPassword { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public sku[] @Sku { get; }
        public string @SslEnforcement { get; }
        public storage_profile[] @StorageProfile { get; }
        public string @Version { get; }
        public string @Fqdn { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
