using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_azuread_service_principal_password : NTerraform.resource
    {
        public azurerm_azuread_service_principal_password(string @endDate,
                                                          string @servicePrincipalId,
                                                          string @value)
        {
            @EndDate = @endDate;
            @ServicePrincipalId = @servicePrincipalId;
            @Value = @value;
        }

        public string @EndDate { get; }
        public string @ServicePrincipalId { get; }
        public string @Value { get; }
        public string @KeyId { get; }
        public string @StartDate { get; }
    }

}
