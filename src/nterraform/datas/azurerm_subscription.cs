using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_subscription")]
    public sealed class azurerm_subscription : nterraform.Core.data
    {
        public azurerm_subscription()
        {
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "display_name", @out: true, min: 0, max: 1)]
        public string @DisplayName { get; }

        [nterraform.Core.TerraformProperty(name: "location_placement_id", @out: true, min: 0, max: 1)]
        public string @LocationPlacementId { get; }

        [nterraform.Core.TerraformProperty(name: "quota_id", @out: true, min: 0, max: 1)]
        public string @QuotaId { get; }

        [nterraform.Core.TerraformProperty(name: "spending_limit", @out: true, min: 0, max: 1)]
        public string @SpendingLimit { get; }

        [nterraform.Core.TerraformProperty(name: "state", @out: true, min: 0, max: 1)]
        public string @State { get; }

        [nterraform.Core.TerraformProperty(name: "subscription_id", @out: true, min: 0, max: 1)]
        public string @SubscriptionId { get; }
    }

}
