using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_automation_account")]
    public sealed class azurerm_automation_account : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
        {
            public sku(FSharpOption<string> @name = null)
            {
                @Name = @name;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 0, max: 1)]
            public FSharpOption<string> @Name { get; }
        }

        public azurerm_automation_account(string @location,
                                          string @name,
                                          string @resourceGroupName,
                                          FSharpList<sku> @sku)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public FSharpList<sku> @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
