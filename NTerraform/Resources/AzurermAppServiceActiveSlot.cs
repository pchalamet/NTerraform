using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_app_service_active_slot")]
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

        [TerraformProperty(name: "app_service_name", @out: false, nested: true, min: 1, max: 1)]
        public string @AppServiceName { get; }

        [TerraformProperty(name: "app_service_slot_name", @out: false, nested: true, min: 1, max: 1)]
        public string @AppServiceSlotName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }
    }

}
