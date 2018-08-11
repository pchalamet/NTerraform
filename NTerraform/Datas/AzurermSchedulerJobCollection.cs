using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_scheduler_job_collection : NTerraform.data
    {
        public sealed class quota
        {
            public quota()
            {
            }

            public int? @MaxJobCount { get; }
            public string @MaxRecurrenceFrequency { get; }
            public int? @MaxRecurrenceInterval { get; }
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

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Location { get; }
        public quota[] @Quota { get; }
        public string @Sku { get; }
        public string @State { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
