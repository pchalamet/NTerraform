using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_postgresql_configuration")]
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

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }
    }

}
