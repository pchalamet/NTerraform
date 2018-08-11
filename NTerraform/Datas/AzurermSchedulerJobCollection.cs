using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_scheduler_job_collection")]
    public sealed class azurerm_scheduler_job_collection : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "quota")]
        public sealed class quota
        {
            public quota()
            {
            }

            [TerraformProperty(name: "max_job_count", @out: true, nested: false, min: 0, max: 1)]
            public int? @MaxJobCount { get; }

            [TerraformProperty(name: "max_recurrence_frequency", @out: true, nested: false, min: 0, max: 1)]
            public string @MaxRecurrenceFrequency { get; }

            [TerraformProperty(name: "max_recurrence_interval", @out: true, nested: false, min: 0, max: 1)]
            public int? @MaxRecurrenceInterval { get; }

            [TerraformProperty(name: "max_retry_interval", @out: true, nested: false, min: 0, max: 1)]
            public int? @MaxRetryInterval { get; }
        }

        public azurerm_scheduler_job_collection(string @name,
                                                string @resourceGroupName,
                                                quota[] @quota = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Quota = @quota;
        }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "location", @out: true, nested: true, min: 0, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "quota", @out: false, nested: true, min: 0, max: 0)]
        public quota[] @Quota { get; }

        [TerraformProperty(name: "sku", @out: true, nested: true, min: 0, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "state", @out: true, nested: true, min: 0, max: 1)]
        public string @State { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
