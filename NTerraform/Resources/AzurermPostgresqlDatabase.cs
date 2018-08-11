using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_postgresql_database")]
    public sealed class azurerm_postgresql_database : NTerraform.resource
    {
        public azurerm_postgresql_database(string @charset,
                                           string @collation,
                                           string @name,
                                           string @resourceGroupName,
                                           string @serverName)
        {
            @Charset = @charset;
            @Collation = @collation;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
        }

        [TerraformProperty(name: "charset", @out: false, nested: true, min: 1, max: 1)]
        public string @Charset { get; }

        [TerraformProperty(name: "collation", @out: false, nested: true, min: 1, max: 1)]
        public string @Collation { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "server_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ServerName { get; }
    }

}
