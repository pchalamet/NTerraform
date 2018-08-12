using System.Collections.Generic;

namespace nterraform.datas.azurerm
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_scheduler_job_collection")]
    public sealed class azurerm_scheduler_job_collection : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "quota")]
        public sealed class quota : nterraform.Core.structure
        {
            public quota()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "max_job_count", @out: true, min: 0, max: 1)]
            public int? @MaxJobCount { get; }

            [nterraform.Core.TerraformProperty(name: "max_recurrence_frequency", @out: true, min: 0, max: 1)]
            public string @MaxRecurrenceFrequency { get; }

            [nterraform.Core.TerraformProperty(name: "max_recurrence_interval", @out: true, min: 0, max: 1)]
            public int? @MaxRecurrenceInterval { get; }

            [nterraform.Core.TerraformProperty(name: "max_retry_interval", @out: true, min: 0, max: 1)]
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

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "quota", @out: false, min: 0, max: 0)]
        public quota[] @Quota { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: true, min: 0, max: 1)]
        public string @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
