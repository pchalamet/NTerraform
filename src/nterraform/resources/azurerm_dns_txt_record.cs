using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_dns_txt_record")]
    public sealed class azurerm_dns_txt_record : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "record")]
        public sealed class record : nterraform.structure
        {
            public record(string @value)
            {
                @Value = @value;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "record", @out: false, min: 1, max: 0)]
        public record[] @Record { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "ttl", @out: false, min: 1, max: 1)]
        public int @Ttl { get; }

        [nterraform.TerraformProperty(name: "zone_name", @out: false, min: 1, max: 1)]
        public string @ZoneName { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
