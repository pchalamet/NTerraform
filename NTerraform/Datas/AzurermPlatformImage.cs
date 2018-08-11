using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_platform_image : NTerraform.data
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
        }

        public string @Location { get; }
        public string @Offer { get; }
        public string @Publisher { get; }
        public string @Sku { get; }
        public string @Version { get; }
    }

}
