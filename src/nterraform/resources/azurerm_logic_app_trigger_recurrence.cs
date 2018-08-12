using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_logic_app_trigger_recurrence")]
    public sealed class azurerm_logic_app_trigger_recurrence : nterraform.Core.resource
    {
        public azurerm_logic_app_trigger_recurrence(string @frequency,
                                                    int @interval,
                                                    string @logicAppId,
                                                    string @name)
        {
            @Frequency = @frequency;
            @Interval = @interval;
            @LogicAppId = @logicAppId;
            @Name = @name;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "frequency", @out: false, min: 1, max: 1)]
        public string @Frequency { get; }

        [nterraform.Core.TerraformProperty(name: "interval", @out: false, min: 1, max: 1)]
        public int @Interval { get; }

        [nterraform.Core.TerraformProperty(name: "logic_app_id", @out: false, min: 1, max: 1)]
        public string @LogicAppId { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }
    }

}
