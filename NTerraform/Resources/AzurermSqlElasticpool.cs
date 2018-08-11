using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_sql_elasticpool")]
    public sealed class azurerm_sql_elasticpool : NTerraform.resource
    {
        public azurerm_sql_elasticpool(int @dtu,
                                       string @edition,
                                       string @location,
                                       string @name,
                                       string @resourceGroupName,
                                       string @serverName)
        {
            @Dtu = @dtu;
            @Edition = @edition;
            @Location = @location;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @ServerName = @serverName;
        }

        [TerraformProperty(name: "dtu", @out: false, nested: true, min: 1, max: 1)]
        public int @Dtu { get; }

        [TerraformProperty(name: "edition", @out: false, nested: true, min: 1, max: 1)]
        public string @Edition { get; }

        [TerraformProperty(name: "location", @out: false, nested: true, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "server_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ServerName { get; }

        [TerraformProperty(name: "creation_date", @out: true, nested: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [TerraformProperty(name: "db_dtu_max", @out: true, nested: true, min: 0, max: 1)]
        public int? @DbDtuMax { get; }

        [TerraformProperty(name: "db_dtu_min", @out: true, nested: true, min: 0, max: 1)]
        public int? @DbDtuMin { get; }

        [TerraformProperty(name: "pool_size", @out: true, nested: true, min: 0, max: 1)]
        public int? @PoolSize { get; }

        [TerraformProperty(name: "tags", @out: true, nested: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
