using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_client_config : NTerraform.data
    {
        public azurerm_client_config()
        {
        }

        public string @ClientId { get; }
        public string @ServicePrincipalApplicationId { get; }
        public string @ServicePrincipalObjectId { get; }
        public string @SubscriptionId { get; }
        public string @TenantId { get; }
    }

}
