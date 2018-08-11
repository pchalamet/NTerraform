using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_storage_account : NTerraform.data
    {
        public sealed class custom_domain
        {
            public custom_domain()
            {
            }

            public string @Name { get; }
        }

        public azurerm_storage_account(string @name,
                                       string @resourceGroupName,
                                       custom_domain[] @customDomain = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @CustomDomain = @customDomain;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @AccessTier { get; }
        public string @AccountEncryptionSource { get; }
        public string @AccountKind { get; }
        public string @AccountReplicationType { get; }
        public string @AccountTier { get; }
        public custom_domain[] @CustomDomain { get; }
        public bool? @EnableBlobEncryption { get; }
        public bool? @EnableFileEncryption { get; }
        public bool? @EnableHttpsTrafficOnly { get; }
        public string @Location { get; }
        public string @PrimaryAccessKey { get; }
        public string @PrimaryBlobConnectionString { get; }
        public string @PrimaryBlobEndpoint { get; }
        public string @PrimaryConnectionString { get; }
        public string @PrimaryFileEndpoint { get; }
        public string @PrimaryLocation { get; }
        public string @PrimaryQueueEndpoint { get; }
        public string @PrimaryTableEndpoint { get; }
        public string @SecondaryAccessKey { get; }
        public string @SecondaryBlobConnectionString { get; }
        public string @SecondaryBlobEndpoint { get; }
        public string @SecondaryConnectionString { get; }
        public string @SecondaryLocation { get; }
        public string @SecondaryQueueEndpoint { get; }
        public string @SecondaryTableEndpoint { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
