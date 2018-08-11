using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_servicebus_namespace : NTerraform.resource
    {
        public azurerm_servicebus_namespace(string @location,
                                            string @name,
                                            string @resourceGroupName,
                                            string @sku,
                                            int? @capacity = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Capacity = @capacity;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Sku { get; }
        public int? @Capacity { get; }
        public string @DefaultPrimaryConnectionString { get; }
        public string @DefaultPrimaryKey { get; }
        public string @DefaultSecondaryConnectionString { get; }
        public string @DefaultSecondaryKey { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
