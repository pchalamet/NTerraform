using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_app_service_plan : NTerraform.data
    {
        public class sku
        {
            public sku()
            {
            }

            public int? @Capacity { get; }
            public string @Size { get; }
            public string @Tier { get; }
        }

        public class properties
        {
            public properties()
            {
            }

            public string @AppServiceEnvironmentId { get; }
            public bool? @PerSiteScaling { get; }
            public bool? @Reserved { get; }
        }

        public azurerm_app_service_plan(string @name,
                                        string @resourceGroupName,
                                        properties[] @properties = null,
                                        sku[] @sku = null)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Properties = @properties;
            @Sku = @sku;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Kind { get; }
        public string @Location { get; }
        public int? @MaximumNumberOfWorkers { get; }
        public properties[] @Properties { get; }
        public sku[] @Sku { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
