using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_scheduler_job_collection")]
    public sealed class azurerm_scheduler_job_collection : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "quota")]
        public sealed class quota : nterraform.structure
        {
            public quota(string @maxRecurrenceFrequency,
                         int? @maxJobCount = null,
                         int? @maxRecurrenceInterval = null)
            {
                @MaxRecurrenceFrequency = @maxRecurrenceFrequency;
                @MaxJobCount = @maxJobCount;
                @MaxRecurrenceInterval = @maxRecurrenceInterval;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "max_recurrence_frequency", @out: false, min: 1, max: 1)]
            public string @MaxRecurrenceFrequency { get; }

            [nterraform.TerraformProperty(name: "max_job_count", @out: false, min: 0, max: 1)]
            public int? @MaxJobCount { get; }

            [nterraform.TerraformProperty(name: "max_recurrence_interval", @out: false, min: 0, max: 1)]
            public int? @MaxRecurrenceInterval { get; }

            [nterraform.TerraformProperty(name: "max_retry_interval", @out: true, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "quota", @out: false, min: 0, max: 1)]
        public quota[] @Quota { get; }

        [nterraform.TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
