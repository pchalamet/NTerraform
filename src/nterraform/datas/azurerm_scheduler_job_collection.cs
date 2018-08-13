using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_scheduler_job_collection")]
    public sealed class azurerm_scheduler_job_collection : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "quota")]
        public sealed class quota : nterraform.structure
        {
            public quota()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "max_job_count", @out: true, min: 0, max: 1)]
            public int? @MaxJobCount { get; }

            [nterraform.TerraformProperty(name: "max_recurrence_frequency", @out: true, min: 0, max: 1)]
            public string @MaxRecurrenceFrequency { get; }

            [nterraform.TerraformProperty(name: "max_recurrence_interval", @out: true, min: 0, max: 1)]
            public int? @MaxRecurrenceInterval { get; }

            [nterraform.TerraformProperty(name: "max_retry_interval", @out: true, min: 0, max: 1)]
            public int? @MaxRetryInterval { get; }
        }

        public azurerm_scheduler_job_collection(string @name,
                                                string @resourceGroupName,
                                                quota[] @quota = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Quota = @quota;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "quota", @out: false, min: 0, max: 0)]
        public quota[] @Quota { get; }

        [nterraform.TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
