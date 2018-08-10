using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_azuread_service_principal : NTerraform.resource
    {
        public azurerm_azuread_service_principal(string @applicationId)
        {
            @ApplicationId = @applicationId;
        }

        public string @ApplicationId { get; }
        public string @DisplayName { get; }
    }

}
