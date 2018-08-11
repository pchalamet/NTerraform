using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_dns_caa_record : NTerraform.resource
    {
        public class record
        {
            public record(int @flags,
                          string @tag,
                          string @value)
            {
                @Flags = @flags;
                @Tag = @tag;
                @Value = @value;
            }

            public int @Flags { get; }
            public string @Tag { get; }
            public string @Value { get; }
        }

        public azurerm_dns_caa_record(string @name,
                                      record[] @record,
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
        public record[] @Record { get; }
        public string @ResourceGroupName { get; }
        public int @Ttl { get; }
        public string @ZoneName { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
