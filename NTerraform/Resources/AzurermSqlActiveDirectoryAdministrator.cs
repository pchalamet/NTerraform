using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_sql_active_directory_administrator : NTerraform.resource
    {
        public azurerm_sql_active_directory_administrator(string @login,
                                                          string @objectId,
                                                          string @resourceGroupName,
                                                          string @serverName,
                                                          string @tenantId)
        {
            @Login = @login;
            @ObjectId = @objectId;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
            @TenantId = @tenantId;
        }

        public string @Login { get; }
        public string @ObjectId { get; }
        public string @ResourceGroupName { get; }
        public string @ServerName { get; }
        public string @TenantId { get; }
    }

}
