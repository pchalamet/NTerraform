using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_azuread_service_principal")]
    public sealed class azurerm_azuread_service_principal : nterraform.Core.resource
    {
        public azurerm_azuread_service_principal(string @applicationId)
        {
            @ApplicationId = @applicationId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "application_id", @out: false, min: 1, max: 1)]
        public string @ApplicationId { get; }

        [nterraform.Core.TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
        public string @DisplayName { get; }
    }

}