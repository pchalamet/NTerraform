using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_subscriptions")]
    public sealed class azurerm_subscriptions : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "subscriptions")]
        public sealed class subscriptions : nterraform.structure
        {
            public subscriptions()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
            public string @DisplayName { get; }

            [nterraform.TerraformProperty(name: "location_placement_id", @out: true, min: 0, max: 1)]
            public string @LocationPlacementId { get; }

            [nterraform.TerraformProperty(name: "quota_id", @out: true, min: 0, max: 1)]
            public string @QuotaId { get; }

            [nterraform.TerraformProperty(name: "spending_limit", @out: true, min: 0, max: 1)]
            public string @SpendingLimit { get; }

            [nterraform.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
            public string @State { get; }

            [nterraform.TerraformProperty(name: "subscription_id", @out: true, min: 0, max: 1)]
            public string @SubscriptionId { get; }
        }

        public azurerm_subscriptions(subscriptions[] @subscriptions = null)
        {
            @Subscriptions = @subscriptions;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "subscriptions", @out: false, min: 0, max: 0)]
        public subscriptions[] @Subscriptions { get; }
    }

}
