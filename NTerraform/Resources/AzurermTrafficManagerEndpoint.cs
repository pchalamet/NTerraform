using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_traffic_manager_endpoint : NTerraform.resource
    {
        public azurerm_traffic_manager_endpoint(string @name,
                                                string @profileName,
                                                string @resourceGroupName,
                                                string @type,
                                                List<string> @geoMappings = null,
                                                int? @minChildEndpoints = null,
                                                string @targetResourceId = null)
        {
            @Name = @name;
            @ProfileName = @profileName;
            @ResourceGroupName = @resourceGroupName;
            @Type = @type;
            @GeoMappings = @geoMappings;
            @MinChildEndpoints = @minChildEndpoints;
            @TargetResourceId = @targetResourceId;
        }

        public string @Name { get; }
        public string @ProfileName { get; }
        public string @ResourceGroupName { get; }
        public string @Type { get; }
        public string @EndpointLocation { get; }
        public string @EndpointMonitorStatus { get; }
        public string @EndpointStatus { get; }
        public List<string> @GeoMappings { get; }
        public int? @MinChildEndpoints { get; }
        public int? @Priority { get; }
        public string @Target { get; }
        public string @TargetResourceId { get; }
        public int? @Weight { get; }
    }

}
