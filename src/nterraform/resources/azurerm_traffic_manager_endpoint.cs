using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_traffic_manager_endpoint")]
    public sealed class azurerm_traffic_manager_endpoint : nterraform.Core.resource
    {
        public azurerm_traffic_manager_endpoint(string @name,
                                                string @profileName,
                                                string @resourceGroupName,
                                                string @type,
                                                FSharpList<string> @geoMappings = null,
                                                int? @minChildEndpoints = null,
                                                string @targetResourceId = null)
        {
            @Name = @name;
            @ProfileName = @profileName;
            @ResourceGroupName = @resourceGroupName;
            @Type = @type;
            @GeoMappings = @geoMappings ?? FSharpList<string>.Empty;
            @MinChildEndpoints = @minChildEndpoints;
            @TargetResourceId = @targetResourceId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "profile_name", @out: false, min: 1, max: 1)]
        public string @ProfileName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint_location", @out: true, min: 0, max: 1)]
        public string @EndpointLocation { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint_monitor_status", @out: true, min: 0, max: 1)]
        public string @EndpointMonitorStatus { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint_status", @out: true, min: 0, max: 1)]
        public string @EndpointStatus { get; }

        [nterraform.Core.TerraformProperty(name: "geo_mappings", @out: false, min: 0, max: 1)]
        public FSharpList<string> @GeoMappings { get; }

        [nterraform.Core.TerraformProperty(name: "min_child_endpoints", @out: false, min: 0, max: 1)]
        public int? @MinChildEndpoints { get; }

        [nterraform.Core.TerraformProperty(name: "priority", @out: true, min: 0, max: 1)]
        public int? @Priority { get; }

        [nterraform.Core.TerraformProperty(name: "target", @out: true, min: 0, max: 1)]
        public string @Target { get; }

        [nterraform.Core.TerraformProperty(name: "target_resource_id", @out: false, min: 0, max: 1)]
        public string @TargetResourceId { get; }

        [nterraform.Core.TerraformProperty(name: "weight", @out: true, min: 0, max: 1)]
        public int? @Weight { get; }
    }

}
