using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_sql_database")]
    public sealed class azurerm_sql_database : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "import")]
        public sealed class import : nterraform.Core.structure
        {
            public import(string @administratorLogin,
                          string @administratorLoginPassword,
                          string @authenticationType,
                          string @storageKey,
                          string @storageKeyType,
                          string @storageUri,
                          FSharpOption<string> @operationMode = null)
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

            [nterraform.Core.TerraformProperty(name: "administrator_login", @out: false, min: 1, max: 1)]
            public string @AdministratorLogin { get; }

            [nterraform.Core.TerraformProperty(name: "administrator_login_password", @out: false, min: 1, max: 1)]
            public string @AdministratorLoginPassword { get; }

            [nterraform.Core.TerraformProperty(name: "authentication_type", @out: false, min: 1, max: 1)]
            public string @AuthenticationType { get; }

            [nterraform.Core.TerraformProperty(name: "storage_key", @out: false, min: 1, max: 1)]
            public string @StorageKey { get; }

            [nterraform.Core.TerraformProperty(name: "storage_key_type", @out: false, min: 1, max: 1)]
            public string @StorageKeyType { get; }

            [nterraform.Core.TerraformProperty(name: "storage_uri", @out: false, min: 1, max: 1)]
            public string @StorageUri { get; }

            [nterraform.Core.TerraformProperty(name: "operation_mode", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @OperationMode { get; }
        }

        public azurerm_sql_database(string @location,
                                    string @name,
                                    string @resourceGroupName,
                                    string @serverName,
                                    FSharpOption<string> @createMode = null,
                                    FSharpOption<FSharpList<import>> @import = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
            @CreateMode = @createMode;
            @Import = @import ?? FSharpList<import>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [nterraform.Core.TerraformProperty(name: "collation", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Collation { get; }

        [nterraform.Core.TerraformProperty(name: "create_mode", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @CreateMode { get; }

        [nterraform.Core.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @CreationDate { get; }

        [nterraform.Core.TerraformProperty(name: "default_secondary_location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DefaultSecondaryLocation { get; }

        [nterraform.Core.TerraformProperty(name: "edition", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Edition { get; }

        [nterraform.Core.TerraformProperty(name: "elastic_pool_name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ElasticPoolName { get; }

        [nterraform.Core.TerraformProperty(name: "encryption", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Encryption { get; }

        [nterraform.Core.TerraformProperty(name: "import", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<import>> @Import { get; }

        [nterraform.Core.TerraformProperty(name: "max_size_bytes", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @MaxSizeBytes { get; }

        [nterraform.Core.TerraformProperty(name: "requested_service_objective_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @RequestedServiceObjectiveId { get; }

        [nterraform.Core.TerraformProperty(name: "requested_service_objective_name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @RequestedServiceObjectiveName { get; }

        [nterraform.Core.TerraformProperty(name: "restore_point_in_time", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @RestorePointInTime { get; }

        [nterraform.Core.TerraformProperty(name: "source_database_deletion_date", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SourceDatabaseDeletionDate { get; }

        [nterraform.Core.TerraformProperty(name: "source_database_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @SourceDatabaseId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
