using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_automation_credential")]
    public sealed class azurerm_automation_credential : nterraform.resource
    {
        public azurerm_automation_credential(string @accountName,
                                             string @name,
                                             string @password,
                                             string @resourceGroupName,
                                             string @username,
                                             string @description = null)
        {
            @AccountName = @accountName;
            @Name = @name;
            @Password = @password;
            @ResourceGroupName = @resourceGroupName;
            @Username = @username;
            @Description = @description;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_name", @out: false, min: 1, max: 1)]
        public string @AccountName { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
        public string @Password { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "username", @out: false, min: 1, max: 1)]
        public string @Username { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }
    }

}
