using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_logic_app_trigger_recurrence : NTerraform.resource
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
        }

        public string @Frequency { get; }
        public int @Interval { get; }
        public string @LogicAppId { get; }
        public string @Name { get; }
    }

}
