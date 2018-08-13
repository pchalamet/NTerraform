using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_azuread_service_principal_password")]
    public sealed class azurerm_azuread_service_principal_password : nterraform.resource
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

        [nterraform.TerraformProperty(name: "end_date", @out: false, min: 1, max: 1)]
        public string @EndDate { get; }

        [nterraform.TerraformProperty(name: "service_principal_id", @out: false, min: 1, max: 1)]
        public string @ServicePrincipalId { get; }

        [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }

        [nterraform.TerraformProperty(name: "key_id", @out: true, min: 0, max: 1)]
        public string @KeyId { get; }

        [nterraform.TerraformProperty(name: "start_date", @out: true, min: 0, max: 1)]
        public string @StartDate { get; }
    }

}
