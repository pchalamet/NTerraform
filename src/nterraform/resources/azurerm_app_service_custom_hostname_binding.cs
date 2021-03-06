using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_app_service_custom_hostname_binding")]
    public sealed class azurerm_app_service_custom_hostname_binding : nterraform.resource
    {
        public azurerm_app_service_custom_hostname_binding(string @appServiceName,
                                                           string @hostname,
                                                           string @resourceGroupName)
        {
            @AppServiceName = @appServiceName;
            @Hostname = @hostname;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "app_service_name", @out: false, min: 1, max: 1)]
        public string @AppServiceName { get; }

        [nterraform.TerraformProperty(name: "hostname", @out: false, min: 1, max: 1)]
        public string @Hostname { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }
    }

}
