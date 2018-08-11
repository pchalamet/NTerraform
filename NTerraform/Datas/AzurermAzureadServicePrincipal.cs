using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_azuread_service_principal")]
    public sealed class azurerm_azuread_service_principal : NTerraform.data
    {
        public azurerm_azuread_service_principal()
        {
        }

        [TerraformProperty(name: "application_id", @out: true, nested: true, min: 0, max: 1)]
        public string @ApplicationId { get; }

        [TerraformProperty(name: "display_name", @out: true, nested: true, min: 0, max: 1)]
        public string @DisplayName { get; }

        [TerraformProperty(name: "object_id", @out: true, nested: true, min: 0, max: 1)]
        public string @ObjectId { get; }
    }

}
