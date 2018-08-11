using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_azuread_service_principal")]
    public sealed class azurerm_azuread_service_principal : NTerraform.resource
    {
        public azurerm_azuread_service_principal(string @applicationId)
        {
            @ApplicationId = @applicationId;
        }

        [TerraformProperty(name: "application_id", @out: false, min: 1, max: 1)]
        public string @ApplicationId { get; }

        [TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
        public string @DisplayName { get; }
    }

}
