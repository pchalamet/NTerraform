using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_postgresql_configuration : NTerraform.resource
    {
        public azurerm_postgresql_configuration(string @name,
                                                string @resourceGroupName,
                                                string @serverName,
                                                string @value)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
            @Value = @value;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @ServerName { get; }
        public string @Value { get; }
    }

}
