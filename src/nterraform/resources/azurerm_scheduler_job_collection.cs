using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_scheduler_job_collection")]
    public sealed class azurerm_scheduler_job_collection : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "quota")]
        public sealed class quota : nterraform.Core.structure
        {
            public quota(string @maxRecurrenceFrequency,
                         FSharpOption<int> @maxJobCount = null,
                         FSharpOption<int> @maxRecurrenceInterval = null)
            {
                @MaxRecurrenceFrequency = @maxRecurrenceFrequency;
                @MaxJobCount = @maxJobCount;
                @MaxRecurrenceInterval = @maxRecurrenceInterval;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "max_recurrence_frequency", @out: false, min: 1, max: 1)]
            public string @MaxRecurrenceFrequency { get; }

            [nterraform.Core.TerraformProperty(name: "max_job_count", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @MaxJobCount { get; }

            [nterraform.Core.TerraformProperty(name: "max_recurrence_interval", @out: false, min: 0, max: 1)]
            public FSharpOption<int> @MaxRecurrenceInterval { get; }

            [nterraform.Core.TerraformProperty(name: "max_retry_interval", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @MaxRetryInterval { get; }
        }

        public azurerm_scheduler_job_collection(string @location,
                                                string @name,
                                                string @resourceGroupName,
                                                string @sku,
                                                FSharpOption<FSharpList<quota>> @quota = null,
                                                FSharpOption<string> @state = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Quota = @quota ?? FSharpList<quota>.Empty;
            @State = @state;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "quota", @out: false, min: 0, max: 1)]
        public FSharpOption<FSharpList<quota>> @Quota { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @State { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
