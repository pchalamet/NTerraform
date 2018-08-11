using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_scheduler_job_collection")]
    public sealed class azurerm_scheduler_job_collection : NTerraform.resource
    {
        [TerraformStructure(category: "", typeName: "quota")]
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

            [TerraformProperty(name: "max_recurrence_frequency", @out: false, min: 1, max: 1)]
            public string @MaxRecurrenceFrequency { get; }

            [TerraformProperty(name: "max_job_count", @out: false, min: 0, max: 1)]
            public int? @MaxJobCount { get; }

            [TerraformProperty(name: "max_recurrence_interval", @out: false, min: 0, max: 1)]
            public int? @MaxRecurrenceInterval { get; }

            [TerraformProperty(name: "max_retry_interval", @out: true, min: 0, max: 1)]
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

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "quota", @out: false, min: 0, max: 1)]
        public quota[] @Quota { get; }

        [TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
        public string @State { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
