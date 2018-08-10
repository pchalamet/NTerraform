using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_relay_namespace : NTerraform.resource
    {
        public class sku
        {
            public sku(string @name)
            {
                @Name = @name;
            }

            public string @Name { get; }
        }

        public azurerm_relay_namespace(string @location,
                                       string @name,
                                       string @resourceGroupName,
                                       List<sku> @sku)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public List<sku> @Sku { get; }
        public string @MetricId { get; }
        public string @PrimaryConnectionString { get; }
        public string @PrimaryKey { get; }
        public string @SecondaryConnectionString { get; }
        public string @SecondaryKey { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
