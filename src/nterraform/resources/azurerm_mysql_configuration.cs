using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_mysql_configuration")]
    public sealed class azurerm_mysql_configuration : nterraform.resource
    {
        public azurerm_mysql_configuration(string @name,
                                           string @resourceGroupName,
                                           string @serverName,
                                           string @value)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
            @Value = @value;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [nterraform.TerraformProperty(name: "value", @out: false, min: 1, max: 1)]
        public string @Value { get; }
    }

}
