using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_user_assigned_identity : NTerraform.resource
    {
        public azurerm_user_assigned_identity(string @location,
                                              string @name,
                                              string @resourceGroupName)
        {
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @PrincipalId { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
