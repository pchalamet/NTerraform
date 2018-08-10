using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_dns_mx_record : NTerraform.resource
    {
        public class record
        {
            public record(string @exchange,
                          string @preference)
            {
                @Exchange = @exchange;
                @Preference = @preference;
            }

            public string @Exchange { get; }
            public string @Preference { get; }
        }

        public azurerm_dns_mx_record(string @name,
                                     HashSet<record> @record,
                                     string @resourceGroupName,
                                     int @ttl,
                                     string @zoneName)
        {
            @Name = @name;
            @Record = @record;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
        }

        public string @Name { get; }
        public HashSet<record> @Record { get; }
        public string @ResourceGroupName { get; }
        public int @Ttl { get; }
        public string @ZoneName { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
