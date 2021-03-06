using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_azuread_service_principal")]
    public sealed class azurerm_azuread_service_principal : nterraform.data
    {
        public azurerm_azuread_service_principal()
        {
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "application_id", @out: true, min: 0, max: 1)]
        public string @ApplicationId { get; }

        [nterraform.TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
        public string @DisplayName { get; }

        [nterraform.TerraformProperty(name: "object_id", @out: true, min: 0, max: 1)]
        public string @ObjectId { get; }
    }

}
