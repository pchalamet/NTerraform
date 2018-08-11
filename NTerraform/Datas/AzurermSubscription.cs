using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_subscription : NTerraform.data
    {
        public azurerm_subscription()
        {
        }

        public string @DisplayName { get; }
        public string @LocationPlacementId { get; }
        public string @QuotaId { get; }
        public string @SpendingLimit { get; }
        public string @State { get; }
        public string @SubscriptionId { get; }
    }

}
