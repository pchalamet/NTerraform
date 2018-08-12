using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_subscriptions")]
    public sealed class azurerm_subscriptions : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "subscriptions")]
        public sealed class subscriptions : nterraform.Core.structure
        {
            public subscriptions()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @DisplayName { get; }

            [nterraform.Core.TerraformProperty(name: "location_placement_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @LocationPlacementId { get; }

            [nterraform.Core.TerraformProperty(name: "quota_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @QuotaId { get; }

            [nterraform.Core.TerraformProperty(name: "spending_limit", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @SpendingLimit { get; }

            [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @State { get; }

            [nterraform.Core.TerraformProperty(name: "subscription_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @SubscriptionId { get; }
        }

        public azurerm_subscriptions(FSharpOption<FSharpList<subscriptions>> @subscriptions = null)
        {
            @Subscriptions = @subscriptions ?? FSharpList<subscriptions>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "subscriptions", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<subscriptions>> @Subscriptions { get; }
    }

}
