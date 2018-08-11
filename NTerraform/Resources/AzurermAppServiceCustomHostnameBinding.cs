using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_app_service_custom_hostname_binding")]
    public sealed class azurerm_app_service_custom_hostname_binding : NTerraform.resource
    {
        public azurerm_app_service_custom_hostname_binding(string @appServiceName,
                                                           string @hostname,
                                                           string @resourceGroupName)
        {
            @AppServiceName = @appServiceName;
            @Hostname = @hostname;
            @ResourceGroupName = @resourceGroupName;
        }

        [TerraformProperty(name: "app_service_name", @out: false, min: 1, max: 1)]
        public string @AppServiceName { get; }

        [TerraformProperty(name: "hostname", @out: false, min: 1, max: 1)]
        public string @Hostname { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }
    }

}
