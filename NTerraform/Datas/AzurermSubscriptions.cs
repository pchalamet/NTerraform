using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_subscriptions : NTerraform.data
    {
        public sealed class subscriptions
        {
            public subscriptions()
            {
            }

            public string @DisplayName { get; }
            public string @LocationPlacementId { get; }
            public string @QuotaId { get; }
            public string @SpendingLimit { get; }
            public string @State { get; }
            public string @SubscriptionId { get; }
        }

        public azurerm_subscriptions(subscriptions[] @subscriptions = null)
        {
            @Subscriptions = @subscriptions;
        }

        public subscriptions[] @Subscriptions { get; }
    }

}
