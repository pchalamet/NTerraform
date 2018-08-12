using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_azuread_service_principal")]
    public sealed class azurerm_azuread_service_principal : nterraform.Core.data
    {
        public azurerm_azuread_service_principal()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "application_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ApplicationId { get; }

        [nterraform.Core.TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @DisplayName { get; }

        [nterraform.Core.TerraformProperty(name: "object_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @ObjectId { get; }
    }

}
