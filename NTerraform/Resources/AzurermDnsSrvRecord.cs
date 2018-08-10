using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_dns_srv_record : NTerraform.resource
    {
        public class record
        {
            public record(int @port,
                          int @priority,
                          string @target,
                          int @weight)
            {
                @Port = @port;
                @Priority = @priority;
                @Target = @target;
                @Weight = @weight;
            }

            public int @Port { get; }
            public int @Priority { get; }
            public string @Target { get; }
            public int @Weight { get; }
        }

        public azurerm_dns_srv_record(string @name,
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
