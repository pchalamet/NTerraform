using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_availability_set")]
    public sealed class azurerm_availability_set : nterraform.Core.resource
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "managed", @out: false, min: 0, max: 1)]
        public bool? @Managed { get; }

        [nterraform.Core.TerraformProperty(name: "platform_fault_domain_count", @out: false, min: 0, max: 1)]
        public int? @PlatformFaultDomainCount { get; }

        [nterraform.Core.TerraformProperty(name: "platform_update_domain_count", @out: false, min: 0, max: 1)]
        public int? @PlatformUpdateDomainCount { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }
    }

}
