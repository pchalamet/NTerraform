using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public int @Dtu { get; }
        public string @Edition { get; }
        public string @Location { get; }
        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @ServerName { get; }
        public string @CreationDate { get; }
        public int? @DbDtuMax { get; }
        public int? @DbDtuMin { get; }
        public int? @PoolSize { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
