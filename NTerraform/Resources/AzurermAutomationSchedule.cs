using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_automation_schedule")]
    public sealed class azurerm_automation_schedule : NTerraform.resource
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

        [TerraformProperty(name: "frequency", @out: false, min: 1, max: 1)]
        public string @Frequency { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "account_name", @out: true, min: 0, max: 1)]
        public string @AccountName { get; }

        [TerraformProperty(name: "automation_account_name", @out: true, min: 0, max: 1)]
        public string @AutomationAccountName { get; }

        [TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [TerraformProperty(name: "expiry_time", @out: true, min: 0, max: 1)]
        public string @ExpiryTime { get; }

        [TerraformProperty(name: "interval", @out: true, min: 0, max: 1)]
        public int? @Interval { get; }

        [TerraformProperty(name: "start_time", @out: true, min: 0, max: 1)]
        public string @StartTime { get; }

        [TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
        public string @Timezone { get; }
    }

}
