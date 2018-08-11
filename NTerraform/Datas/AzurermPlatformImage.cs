using System.Collections.Generic;

namespace NTerraform.Datas
{
    [TerraformStructure(category: "data", typeName: "azurerm_platform_image")]
    public sealed class azurerm_platform_image : NTerraform.data
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

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "offer", @out: false, min: 1, max: 1)]
        public string @Offer { get; }

        [TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
        public string @Publisher { get; }

        [TerraformProperty(name: "sku", @out: false, min: 1, max: 1)]
        public string @Sku { get; }

        [TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
