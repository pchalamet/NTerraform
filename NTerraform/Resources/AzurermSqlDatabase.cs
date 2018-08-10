using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_sql_database : NTerraform.resource
    {
        public class import
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
            }

            public string @AdministratorLogin { get; }
            public string @AdministratorLoginPassword { get; }
            public string @AuthenticationType { get; }
            public string @StorageKey { get; }
            public string @StorageKeyType { get; }
            public string @StorageUri { get; }
            public string @OperationMode { get; }
        }

        public azurerm_sql_database(string @location,
                                    string @name,
                                    string @resourceGroupName,
                                    string @serverName,
                                    string @createMode = null,
                                    List<import> @import = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
            @CreateMode = @createMode;
            @Import = @import;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @ServerName { get; }
        public string @Collation { get; }
        public string @CreateMode { get; }
        public string @CreationDate { get; }
        public string @DefaultSecondaryLocation { get; }
        public string @Edition { get; }
        public string @ElasticPoolName { get; }
        public string @Encryption { get; }
        public List<import> @Import { get; }
        public string @MaxSizeBytes { get; }
        public string @RequestedServiceObjectiveId { get; }
        public string @RequestedServiceObjectiveName { get; }
        public string @RestorePointInTime { get; }
        public string @SourceDatabaseDeletionDate { get; }
        public string @SourceDatabaseId { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
