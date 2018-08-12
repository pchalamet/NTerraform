using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_app_service_plan")]
    public sealed class azurerm_app_service_plan : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "sku")]
        public sealed class sku : nterraform.Core.structure
        {
            public sku()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "capacity", @out: true, min: 0, max: 1)]
            public FSharpOption<int> @Capacity { get; }

            [nterraform.Core.TerraformProperty(name: "size", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Size { get; }

            [nterraform.Core.TerraformProperty(name: "tier", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @Tier { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "properties")]
        public sealed class properties : nterraform.Core.structure
        {
            public properties()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "app_service_environment_id", @out: true, min: 0, max: 1)]
            public FSharpOption<string> @AppServiceEnvironmentId { get; }

            [nterraform.Core.TerraformProperty(name: "per_site_scaling", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @PerSiteScaling { get; }

            [nterraform.Core.TerraformProperty(name: "reserved", @out: true, min: 0, max: 1)]
            public FSharpOption<bool> @Reserved { get; }
        }

        public azurerm_app_service_plan(string @name,
                                        string @resourceGroupName,
                                        FSharpOption<FSharpList<properties>> @properties = null,
                                        FSharpOption<FSharpList<sku>> @sku = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Properties = @properties ?? FSharpList<properties>.Empty;
            @Sku = @sku ?? FSharpList<sku>.Empty;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "kind", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Kind { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @Location { get; }

        [nterraform.Core.TerraformProperty(name: "maximum_number_of_workers", @out: true, min: 0, max: 1)]
        public FSharpOption<int> @MaximumNumberOfWorkers { get; }

        [nterraform.Core.TerraformProperty(name: "properties", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<properties>> @Properties { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 0, max: 0)]
        public FSharpOption<FSharpList<sku>> @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
