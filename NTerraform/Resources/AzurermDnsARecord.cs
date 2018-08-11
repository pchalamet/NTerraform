using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_dns_a_record : NTerraform.resource
    {
        public azurerm_dns_a_record(string @name,
                                    string[] @records,
                                    string @resourceGroupName,
                                    int @ttl,
                                    string @zoneName)
        {
            @Name = @name;
            @Records = @records;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
        }

        public string @Name { get; }
        public string[] @Records { get; }
        public string @ResourceGroupName { get; }
        public int @Ttl { get; }
        public string @ZoneName { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
