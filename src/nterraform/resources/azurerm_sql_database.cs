using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_sql_database")]
    public sealed class azurerm_sql_database : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "import")]
        public sealed class import : nterraform.structure
        {
            public import(string @administratorLogin,
                          string @administratorLoginPassword,
                          string @authenticationType,
                          string @storageKey,
                          string @storageKeyType,
                          string @storageUri,
                          string @operationMode = null)
            {
                @AdministratorLogin = @administratorLogin;
                @AdministratorLoginPassword = @administratorLoginPassword;
                @AuthenticationType = @authenticationType;
                @StorageKey = @storageKey;
                @StorageKeyType = @storageKeyType;
                @StorageUri = @storageUri;
                @OperationMode = @operationMode;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "administrator_login", @out: false, min: 1, max: 1)]
            public string @AdministratorLogin { get; }

            [nterraform.TerraformProperty(name: "administrator_login_password", @out: false, min: 1, max: 1)]
            public string @AdministratorLoginPassword { get; }

            [nterraform.TerraformProperty(name: "authentication_type", @out: false, min: 1, max: 1)]
            public string @AuthenticationType { get; }

            [nterraform.TerraformProperty(name: "storage_key", @out: false, min: 1, max: 1)]
            public string @StorageKey { get; }

            [nterraform.TerraformProperty(name: "storage_key_type", @out: false, min: 1, max: 1)]
            public string @StorageKeyType { get; }

            [nterraform.TerraformProperty(name: "storage_uri", @out: false, min: 1, max: 1)]
            public string @StorageUri { get; }

            [nterraform.TerraformProperty(name: "operation_mode", @out: false, min: 0, max: 1)]
            public string @OperationMode { get; }
        }

        public azurerm_sql_database(string @location,
                                    string @name,
                                    string @resourceGroupName,
                                    string @serverName,
                                    string @createMode = null,
                                    import[] @import = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
            @CreateMode = @createMode;
            @Import = @import;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [nterraform.TerraformProperty(name: "collation", @out: true, min: 0, max: 1)]
        public string @Collation { get; }

        [nterraform.TerraformProperty(name: "create_mode", @out: false, min: 0, max: 1)]
        public string @CreateMode { get; }

        [nterraform.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.TerraformProperty(name: "default_secondary_location", @out: true, min: 0, max: 1)]
        public string @DefaultSecondaryLocation { get; }

        [nterraform.TerraformProperty(name: "edition", @out: true, min: 0, max: 1)]
        public string @Edition { get; }

        [nterraform.TerraformProperty(name: "elastic_pool_name", @out: true, min: 0, max: 1)]
        public string @ElasticPoolName { get; }

        [nterraform.TerraformProperty(name: "encryption", @out: true, min: 0, max: 1)]
        public string @Encryption { get; }

        [nterraform.TerraformProperty(name: "import", @out: false, min: 0, max: 1)]
        public import[] @Import { get; }

        [nterraform.TerraformProperty(name: "max_size_bytes", @out: true, min: 0, max: 1)]
        public string @MaxSizeBytes { get; }

        [nterraform.TerraformProperty(name: "requested_service_objective_id", @out: true, min: 0, max: 1)]
        public string @RequestedServiceObjectiveId { get; }

        [nterraform.TerraformProperty(name: "requested_service_objective_name", @out: true, min: 0, max: 1)]
        public string @RequestedServiceObjectiveName { get; }

        [nterraform.TerraformProperty(name: "restore_point_in_time", @out: true, min: 0, max: 1)]
        public string @RestorePointInTime { get; }

        [nterraform.TerraformProperty(name: "source_database_deletion_date", @out: true, min: 0, max: 1)]
        public string @SourceDatabaseDeletionDate { get; }

        [nterraform.TerraformProperty(name: "source_database_id", @out: true, min: 0, max: 1)]
        public string @SourceDatabaseId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
