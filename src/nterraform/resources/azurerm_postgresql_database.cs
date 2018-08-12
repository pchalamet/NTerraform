using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_postgresql_database")]
    public sealed class azurerm_postgresql_database : nterraform.Core.resource
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "charset", @out: false, min: 1, max: 1)]
        public string @Charset { get; }

        [nterraform.Core.TerraformProperty(name: "collation", @out: false, min: 1, max: 1)]
        public string @Collation { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }
    }

}
