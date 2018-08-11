using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_azuread_service_principal_password")]
    public sealed class azurerm_azuread_service_principal_password : NTerraform.resource
    {
        public azurerm_azuread_service_principal_password(string @endDate,
                                                          string @servicePrincipalId,
                                                          string @value)
        {
            @EndDate = @endDate;
            @ServicePrincipalId = @servicePrincipalId;
            @Value = @value;
        }

        [TerraformProperty(name: "end_date", @out: false, nested: true, min: 1, max: 1)]
        public string @EndDate { get; }

        [TerraformProperty(name: "service_principal_id", @out: false, nested: true, min: 1, max: 1)]
        public string @ServicePrincipalId { get; }

        [TerraformProperty(name: "value", @out: false, nested: true, min: 1, max: 1)]
        public string @Value { get; }

        [TerraformProperty(name: "key_id", @out: true, nested: true, min: 0, max: 1)]
        public string @KeyId { get; }

        [TerraformProperty(name: "start_date", @out: true, nested: true, min: 0, max: 1)]
        public string @StartDate { get; }
    }

}
