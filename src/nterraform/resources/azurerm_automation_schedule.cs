using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_automation_schedule")]
    public sealed class azurerm_automation_schedule : nterraform.Core.resource
    {
        public azurerm_automation_schedule(string @frequency,
                                           string @name,
                                           string @resourceGroupName,
                                           FSharpOption<string> @description = null,
                                           FSharpOption<string> @timezone = null)
        {
            @Frequency = @frequency;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Description = @description;
            @Timezone = @timezone;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "frequency", @out: false, min: 1, max: 1)]
        public string @Frequency { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "account_name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AccountName { get; }

        [nterraform.Core.TerraformProperty(name: "automation_account_name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @AutomationAccountName { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Description { get; }

        [nterraform.Core.TerraformProperty(name: "expiry_time", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ExpiryTime { get; }

        [nterraform.Core.TerraformProperty(name: "interval", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @Interval { get; }

        [nterraform.Core.TerraformProperty(name: "start_time", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @StartTime { get; }

        [nterraform.Core.TerraformProperty(name: "timezone", @out: false, min: 0, max: 1)]
        public FSharpOption<string> @Timezone { get; }
    }

}
