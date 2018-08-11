using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_application_insights : NTerraform.resource
    {
        public azurerm_application_insights(string @applicationType,
                                            string @location,
                                            string @name,
                                            string @resourceGroupName)
        {
            @ApplicationType = @applicationType;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @ApplicationType { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @AppId { get; }
        public string @InstrumentationKey { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
