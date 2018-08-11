using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @AppServiceName { get; }
        public string @Hostname { get; }
        public string @ResourceGroupName { get; }
    }

}
