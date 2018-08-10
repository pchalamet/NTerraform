using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_dns_cname_record : NTerraform.resource
    {
        public azurerm_dns_cname_record(string @name,
                                        string @record,
                                        string @resourceGroupName,
                                        int @ttl,
                                        string @zoneName,
                                        string @records = null)
        {
            @Name = @name;
            @Record = @record;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
            @Records = @records;
        }

        public string @Name { get; }
        public string @Record { get; }
        public string @ResourceGroupName { get; }
        public int @Ttl { get; }
        public string @ZoneName { get; }
        public string @Records { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
