using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_app_service_active_slot")]
    public sealed class azurerm_app_service_active_slot : nterraform.resource
    {
        public azurerm_app_service_active_slot(string @appServiceName,
                                               string @appServiceSlotName,
                                               string @resourceGroupName)
        {
            @AppServiceName = @appServiceName;
            @AppServiceSlotName = @appServiceSlotName;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "app_service_name", @out: false, min: 1, max: 1)]
        public string @AppServiceName { get; }

        [nterraform.TerraformProperty(name: "app_service_slot_name", @out: false, min: 1, max: 1)]
        public string @AppServiceSlotName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }
    }

}
