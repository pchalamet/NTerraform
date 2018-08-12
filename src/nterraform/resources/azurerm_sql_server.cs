using Microsoft.FSharp.Core;
using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_sql_server")]
    public sealed class azurerm_sql_server : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "administrator_login", @out: false, min: 1, max: 1)]
        public string @AdministratorLogin { get; }

        [nterraform.Core.TerraformProperty(name: "administrator_login_password", @out: false, min: 1, max: 1)]
        public string @AdministratorLoginPassword { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: false, min: 1, max: 1)]
        public string @Version { get; }

        [nterraform.Core.TerraformProperty(name: "fully_qualified_domain_name", @out: true, min: 0, max: 1)]
        public FSharpOption<string> @FullyQualifiedDomainName { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpOption<FSharpMap<string,string>> @Tags { get; }
    }

}
