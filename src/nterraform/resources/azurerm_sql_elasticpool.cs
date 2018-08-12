using Microsoft.FSharp.Collections;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_sql_elasticpool")]
    public sealed class azurerm_sql_elasticpool : nterraform.Core.resource
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "dtu", @out: false, min: 1, max: 1)]
        public int @Dtu { get; }

        [nterraform.Core.TerraformProperty(name: "edition", @out: false, min: 1, max: 1)]
        public string @Edition { get; }

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "server_name", @out: false, min: 1, max: 1)]
        public string @ServerName { get; }

        [nterraform.Core.TerraformProperty(name: "creation_date", @out: true, min: 0, max: 1)]
        public string @CreationDate { get; }

        [nterraform.Core.TerraformProperty(name: "db_dtu_max", @out: true, min: 0, max: 1)]
        public int? @DbDtuMax { get; }

        [nterraform.Core.TerraformProperty(name: "db_dtu_min", @out: true, min: 0, max: 1)]
        public int? @DbDtuMin { get; }

        [nterraform.Core.TerraformProperty(name: "pool_size", @out: true, min: 0, max: 1)]
        public int? @PoolSize { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public FSharpMap<string,string> @Tags { get; }
    }

}
