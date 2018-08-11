using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_sql_server : NTerraform.resource
    {
        public azurerm_sql_server(string @administratorLogin,
                                  string @administratorLoginPassword,
                                  string @location,
                                  string @name,
                                  string @resourceGroupName,
                                  string @version)
        {
            @AdministratorLogin = @administratorLogin;
            @AdministratorLoginPassword = @administratorLoginPassword;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @Version = @version;
        }

        public string @AdministratorLogin { get; }
        public string @AdministratorLoginPassword { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @Version { get; }
        public string @FullyQualifiedDomainName { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
