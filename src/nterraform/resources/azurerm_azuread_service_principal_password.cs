using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_azuread_service_principal_password")]
    public sealed class azurerm_azuread_service_principal_password : nterraform.Core.resource
    {
        public azurerm_azuread_service_principal_password(string @endDate,
                                                          string @servicePrincipalId,
                                                          string @value)
        {
            @EndDate = @endDate;
            @ServicePrincipalId = @servicePrincipalId;
            @Value = @value;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "end_date", @out: false, min: 1, max: 1)]
        public string @EndDate { get; }

        [nterraform.Core.TerraformProperty(name: "service_principal_id", @out: false, min: 1, max: 1)]
        public string @ServicePrincipalId { get; }

        [nterraform.Core.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }

        [nterraform.Core.TerraformProperty(name: "key_id", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @KeyId { get; }

        [nterraform.Core.TerraformProperty(name: "start_date", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @StartDate { get; }
    }

}
