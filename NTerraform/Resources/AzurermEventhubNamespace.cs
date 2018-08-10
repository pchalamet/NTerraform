using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_eventhub_namespace : NTerraform.resource
    {
        public azurerm_eventhub_namespace(string @location,
                                          string @name,
                                          string @resourceGroupName,
                                          string @sku,
                                          bool? @autoInflateEnabled = null,
                                          int? @capacity = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @AutoInflateEnabled = @autoInflateEnabled;
            @Capacity = @capacity;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Sku { get; }
        public bool? @AutoInflateEnabled { get; }
        public int? @Capacity { get; }
        public string @DefaultPrimaryConnectionString { get; }
        public string @DefaultPrimaryKey { get; }
        public string @DefaultSecondaryConnectionString { get; }
        public string @DefaultSecondaryKey { get; }
        public int? @MaximumThroughputUnits { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
