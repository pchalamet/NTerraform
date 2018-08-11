using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_traffic_manager_endpoint")]
    public sealed class azurerm_traffic_manager_endpoint : NTerraform.resource
    {
        public azurerm_traffic_manager_endpoint(string @name,
                                                string @profileName,
                                                string @resourceGroupName,
                                                string @type,
                                                string[] @geoMappings = null,
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
            base._validate_();
        }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "profile_name", @out: false, min: 1, max: 1)]
        public string @ProfileName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [TerraformProperty(name: "endpoint_location", @out: true, min: 0, max: 1)]
        public string @EndpointLocation { get; }

        [TerraformProperty(name: "endpoint_monitor_status", @out: true, min: 0, max: 1)]
        public string @EndpointMonitorStatus { get; }

        [TerraformProperty(name: "endpoint_status", @out: true, min: 0, max: 1)]
        public string @EndpointStatus { get; }

        [TerraformProperty(name: "geo_mappings", @out: false, min: 0, max: 1)]
        public string[] @GeoMappings { get; }

        [TerraformProperty(name: "min_child_endpoints", @out: false, min: 0, max: 1)]
        public int? @MinChildEndpoints { get; }

        [TerraformProperty(name: "priority", @out: true, min: 0, max: 1)]
        public int? @Priority { get; }

        [TerraformProperty(name: "target", @out: true, min: 0, max: 1)]
        public string @Target { get; }

        [TerraformProperty(name: "target_resource_id", @out: false, min: 0, max: 1)]
        public string @TargetResourceId { get; }

        [TerraformProperty(name: "weight", @out: true, min: 0, max: 1)]
        public int? @Weight { get; }
    }

}
