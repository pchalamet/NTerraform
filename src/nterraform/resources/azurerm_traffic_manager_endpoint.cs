using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_traffic_manager_endpoint")]
    public sealed class azurerm_traffic_manager_endpoint : nterraform.resource
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

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "profile_name", @out: false, min: 1, max: 1)]
        public string @ProfileName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "endpoint_location", @out: true, min: 0, max: 1)]
        public string @EndpointLocation { get; }

        [nterraform.TerraformProperty(name: "endpoint_monitor_status", @out: true, min: 0, max: 1)]
        public string @EndpointMonitorStatus { get; }

        [nterraform.TerraformProperty(name: "endpoint_status", @out: true, min: 0, max: 1)]
        public string @EndpointStatus { get; }

        [nterraform.TerraformProperty(name: "geo_mappings", @out: false, min: 0, max: 1)]
        public string[] @GeoMappings { get; }

        [nterraform.TerraformProperty(name: "min_child_endpoints", @out: false, min: 0, max: 1)]
        public int? @MinChildEndpoints { get; }

        [nterraform.TerraformProperty(name: "priority", @out: true, min: 0, max: 1)]
        public int? @Priority { get; }

        [nterraform.TerraformProperty(name: "target", @out: true, min: 0, max: 1)]
        public string @Target { get; }

        [nterraform.TerraformProperty(name: "target_resource_id", @out: false, min: 0, max: 1)]
        public string @TargetResourceId { get; }

        [nterraform.TerraformProperty(name: "weight", @out: true, min: 0, max: 1)]
        public int? @Weight { get; }
    }

}
