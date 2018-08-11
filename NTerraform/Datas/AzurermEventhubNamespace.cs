using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_eventhub_namespace : NTerraform.data
    {
        public azurerm_eventhub_namespace(string @name,
                                          string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public bool? @AutoInflateEnabled { get; }
        public int? @Capacity { get; }
        public string @DefaultPrimaryConnectionString { get; }
        public string @DefaultPrimaryKey { get; }
        public string @DefaultSecondaryConnectionString { get; }
        public string @DefaultSecondaryKey { get; }
        public string @Location { get; }
        public int? @MaximumThroughputUnits { get; }
        public string @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
