using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_sql_active_directory_administrator")]
    public sealed class azurerm_sql_active_directory_administrator : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "login", @out: false, min: 1, max: 1)]
        public string @Login { get; }

        [nterraform.TerraformProperty(name: "object_id", @out: false, min: 1, max: 1)]
        public string @ObjectId { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [nterraform.TerraformProperty(name: "tenant_id", @out: false, min: 1, max: 1)]
        public string @TenantId { get; }
    }

}
