using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_dns_a_record : NTerraform.resource
    {
        public azurerm_dns_a_record(string @name,
                                    HashSet<string> @records,
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
        public HashSet<string> @Records { get; }
        public string @ResourceGroupName { get; }
        public int @Ttl { get; }
        public string @ZoneName { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
