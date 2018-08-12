using System.Collections.Generic;

namespace nterraform.datas.azurerm
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_client_config")]
    public sealed class azurerm_client_config : nterraform.Core.data
    {
        public azurerm_client_config()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "client_id", @out: true, min: 0, max: 1)]
        public string @ClientId { get; }

        [nterraform.Core.TerraformProperty(name: "service_principal_application_id", @out: true, min: 0, max: 1)]
        public string @ServicePrincipalApplicationId { get; }

        [nterraform.Core.TerraformProperty(name: "service_principal_object_id", @out: true, min: 0, max: 1)]
        public string @ServicePrincipalObjectId { get; }

        [nterraform.Core.TerraformProperty(name: "subscription_id", @out: true, min: 0, max: 1)]
        public string @SubscriptionId { get; }

        [nterraform.Core.TerraformProperty(name: "tenant_id", @out: true, min: 0, max: 1)]
        public string @TenantId { get; }
    }

}
