using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_dns_txt_record : NTerraform.resource
    {
        public sealed class record
        {
            public record(string @value)
            {
                @Value = @value;
            }

            public string @Value { get; }
        }

        public azurerm_dns_txt_record(string @name,
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
