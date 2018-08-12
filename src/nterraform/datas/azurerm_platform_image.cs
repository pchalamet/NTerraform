using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_platform_image")]
    public sealed class azurerm_platform_image : nterraform.Core.data
    {
        public azurerm_platform_image(string @location,
                                      string @offer,
                                      string @publisher,
                                      string @sku)
        {
            @Location = @location;
            @Offer = @offer;
            @Publisher = @publisher;
            @Sku = @sku;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "offer", @out: false, min: 1, max: 1)]
        public string @Offer { get; }

        [nterraform.Core.TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
        public string @Publisher { get; }

        [nterraform.Core.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
