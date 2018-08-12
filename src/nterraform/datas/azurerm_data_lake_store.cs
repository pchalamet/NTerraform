using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_data_lake_store")]
    public sealed class azurerm_data_lake_store : nterraform.Core.data
    {
        public azurerm_data_lake_store(string @name,
                                       string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_state", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @EncryptionState { get; }

        [nterraform.Core.TerraformProperty(name: "encryption_type", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @EncryptionType { get; }

        [nterraform.Core.TerraformProperty(name: "firewall_allow_azure_ips", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @FirewallAllowAzureIps { get; }

        [nterraform.Core.TerraformProperty(name: "firewall_state", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @FirewallState { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "tier", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Tier { get; }
    }

}
