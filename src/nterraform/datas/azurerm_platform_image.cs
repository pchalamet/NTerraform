using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_platform_image")]
    public sealed class azurerm_platform_image : nterraform.data
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

        [nterraform.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.TerraformProperty(name: "offer", @out: false, min: 1, max: 1)]
        public string @Offer { get; }

        [nterraform.TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
        public string @Publisher { get; }

        [nterraform.TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
