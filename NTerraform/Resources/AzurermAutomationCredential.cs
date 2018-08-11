using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_automation_credential : NTerraform.resource
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
        }

        public string @AccountName { get; }
        public string @Name { get; }
        public string @Password { get; }
        public string @ResourceGroupName { get; }
        public string @Username { get; }
        public string @Description { get; }
    }

}
