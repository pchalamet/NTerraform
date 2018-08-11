using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_application_security_group : NTerraform.data
    {
        public azurerm_application_security_group(string @name,
                                                  string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Location { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
