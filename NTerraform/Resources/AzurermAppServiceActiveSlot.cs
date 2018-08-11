using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_app_service_active_slot : NTerraform.resource
    {
        public azurerm_app_service_active_slot(string @appServiceName,
                                               string @appServiceSlotName,
                                               string @resourceGroupName)
        {
            @AppServiceName = @appServiceName;
            @AppServiceSlotName = @appServiceSlotName;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @AppServiceName { get; }
        public string @AppServiceSlotName { get; }
        public string @ResourceGroupName { get; }
    }

}
