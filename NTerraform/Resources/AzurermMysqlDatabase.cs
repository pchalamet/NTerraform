using System.Collections.Generic;

namespace NTerraform.Resources
{
    public sealed class azurerm_mysql_database : NTerraform.resource
    {
        public azurerm_mysql_database(string @charset,
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

        public string @Charset { get; }
        public string @Collation { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @ServerName { get; }
    }

}
