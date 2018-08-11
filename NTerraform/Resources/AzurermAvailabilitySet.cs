using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public bool? @Managed { get; }
        public int? @PlatformFaultDomainCount { get; }
        public int? @PlatformUpdateDomainCount { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
