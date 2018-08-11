using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_availability_set")]
    public sealed class azurerm_availability_set : NTerraform.resource
    {
        public azurerm_availability_set(string @location,
                                        string @name,
                                        string @resourceGroupName,
                                        bool? @managed = null,
                                        int? @platformFaultDomainCount = null,
                                        int? @platformUpdateDomainCount = null)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Managed = @managed;
            @PlatformFaultDomainCount = @platformFaultDomainCount;
            @PlatformUpdateDomainCount = @platformUpdateDomainCount;
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "managed", @out: false, min: 0, max: 1)]
        public bool? @Managed { get; }

        [TerraformProperty(name: "platform_fault_domain_count", @out: false, min: 0, max: 1)]
        public int? @PlatformFaultDomainCount { get; }

        [TerraformProperty(name: "platform_update_domain_count", @out: false, min: 0, max: 1)]
        public int? @PlatformUpdateDomainCount { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
