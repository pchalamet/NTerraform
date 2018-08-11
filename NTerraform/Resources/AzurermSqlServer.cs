using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_sql_server")]
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
            base._validate_();
        }

        [TerraformProperty(name: "administrator_login", @out: false, min: 1, max: 1)]
        public string @AdministratorLogin { get; }

        [TerraformProperty(name: "administrator_login_password", @out: false, min: 1, max: 1)]
        public string @AdministratorLoginPassword { get; }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "version", @out: false, min: 1, max: 1)]
        public string @Version { get; }

        [TerraformProperty(name: "fully_qualified_domain_name", @out: true, min: 0, max: 1)]
        public string @FullyQualifiedDomainName { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
