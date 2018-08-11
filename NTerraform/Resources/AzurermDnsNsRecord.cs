using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_dns_ns_record : NTerraform.resource
    {
        public sealed class record
        {
            public record(string @nsdname)
            {
                @Nsdname = @nsdname;
            }

            public string @Nsdname { get; }
        }

        public azurerm_dns_ns_record(string @name,
                                     string @resourceGroupName,
                                     int @ttl,
                                     string @zoneName,
                                     record[] @record = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Ttl = @ttl;
            @ZoneName = @zoneName;
            @Record = @record;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public int @Ttl { get; }
        public string @ZoneName { get; }
        public record[] @Record { get; }
        public string[] @Records { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
