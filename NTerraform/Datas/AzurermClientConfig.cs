using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_client_config")]
    public sealed class azurerm_client_config : NTerraform.data
    {
        public azurerm_client_config()
        {
            base._validate_();
        }

        [TerraformProperty(name: "client_id", @out: true, min: 0, max: 1)]
        public string @ClientId { get; }

        [TerraformProperty(name: "service_principal_application_id", @out: true, min: 0, max: 1)]
        public string @ServicePrincipalApplicationId { get; }

        [TerraformProperty(name: "service_principal_object_id", @out: true, min: 0, max: 1)]
        public string @ServicePrincipalObjectId { get; }

        [TerraformProperty(name: "subscription_id", @out: true, min: 0, max: 1)]
        public string @SubscriptionId { get; }

        [TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
        public string @TenantId { get; }
    }

}
