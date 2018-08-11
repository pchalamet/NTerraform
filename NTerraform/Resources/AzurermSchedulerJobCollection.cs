using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_scheduler_job_collection : NTerraform.resource
    {
        public sealed class quota
        {
            public quota(string @maxRecurrenceFrequency,
                         int? @maxJobCount = null,
                         int? @maxRecurrenceInterval = null)
            {
                @MaxRecurrenceFrequency = @maxRecurrenceFrequency;
                @MaxJobCount = @maxJobCount;
                @MaxRecurrenceInterval = @maxRecurrenceInterval;
            }

            public string @MaxRecurrenceFrequency { get; }
            public int? @MaxJobCount { get; }
            public int? @MaxRecurrenceInterval { get; }
            public int? @MaxRetryInterval { get; }
        }

        public azurerm_scheduler_job_collection(string @location,
                                                string @name,
                                                string @resourceGroupName,
                                                string @sku,
                                                quota[] @quota = null,
                                                string @state = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Quota = @quota;
            @State = @state;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Sku { get; }
        public quota[] @Quota { get; }
        public string @State { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
