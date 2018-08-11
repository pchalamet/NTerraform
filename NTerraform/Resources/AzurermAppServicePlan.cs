using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_app_service_plan : NTerraform.resource
    {
        public class sku
        {
            public sku(string @size,
                       string @tier)
            {
                @Size = @size;
                @Tier = @tier;
            }

            public string @Size { get; }
            public string @Tier { get; }
            public int? @Capacity { get; }
        }

        public class properties
        {
            public properties(string @appServiceEnvironmentId = null,
                              bool? @perSiteScaling = null,
                              bool? @reserved = null)
            {
                @AppServiceEnvironmentId = @appServiceEnvironmentId;
                @PerSiteScaling = @perSiteScaling;
                @Reserved = @reserved;
            }

            public string @AppServiceEnvironmentId { get; }
            public bool? @PerSiteScaling { get; }
            public bool? @Reserved { get; }
        }

        public azurerm_app_service_plan(string @location,
                                        string @name,
                                        string @resourceGroupName,
                                        sku[] @sku,
                                        string @kind = null,
                                        properties[] @properties = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Sku = @sku;
            @Kind = @kind;
            @Properties = @properties;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public sku[] @Sku { get; }
        public string @Kind { get; }
        public int? @MaximumNumberOfWorkers { get; }
        public properties[] @Properties { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
