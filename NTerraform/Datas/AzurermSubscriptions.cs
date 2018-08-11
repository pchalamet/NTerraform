using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_subscriptions")]
    public sealed class azurerm_subscriptions : NTerraform.data
    {
        [TerraformStructure(category: "", typeName: "subscriptions")]
        public sealed class subscriptions
        {
            public subscriptions()
            {
            }

            [TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
            public string @DisplayName { get; }

            [TerraformProperty(name: "location_placement_id", @out: true, min: 0, max: 1)]
            public string @LocationPlacementId { get; }

            [TerraformProperty(name: "quota_id", @out: true, min: 0, max: 1)]
            public string @QuotaId { get; }

            [TerraformProperty(name: "spending_limit", @out: true, min: 0, max: 1)]
            public string @SpendingLimit { get; }

            [TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
            public string @State { get; }

            [TerraformProperty(name: "subscription_id", @out: true, min: 0, max: 1)]
            public string @SubscriptionId { get; }
        }

        public azurerm_subscriptions(subscriptions[] @subscriptions = null)
        {
            @Subscriptions = @subscriptions;
        }

        [TerraformProperty(name: "subscriptions", @out: false, min: 0, max: 0)]
        public subscriptions[] @Subscriptions { get; }
    }

}
