using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_automation_schedule : NTerraform.resource
    {
        public azurerm_automation_schedule(string @frequency,
                                           string @name,
                                           string @resourceGroupName,
                                           string @description = null,
                                           string @timezone = null)
        {
            @Frequency = @frequency;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Description = @description;
            @Timezone = @timezone;
        }

        public string @Frequency { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @AccountName { get; }
        public string @AutomationAccountName { get; }
        public string @Description { get; }
        public string @ExpiryTime { get; }
        public int? @Interval { get; }
        public string @StartTime { get; }
        public string @Timezone { get; }
    }

}
