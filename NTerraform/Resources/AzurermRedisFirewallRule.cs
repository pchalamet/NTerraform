using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_redis_firewall_rule")]
    public sealed class azurerm_redis_firewall_rule : NTerraform.resource
    {
        public azurerm_redis_firewall_rule(string @endIp,
                                           string @name,
                                           string @redisCacheName,
                                           string @resourceGroupName,
                                           string @startIp)
        {
            @EndIp = @endIp;
            @Name = @name;
            @RedisCacheName = @redisCacheName;
            @ResourceGroupName = @resourceGroupName;
            @StartIp = @startIp;
        }

        [TerraformProperty(name: "end_ip", @out: false, nested: true, min: 1, max: 1)]
        public string @EndIp { get; }

        [TerraformProperty(name: "name", @out: false, nested: true, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "redis_cache_name", @out: false, nested: true, min: 1, max: 1)]
        public string @RedisCacheName { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, nested: true, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "start_ip", @out: false, nested: true, min: 1, max: 1)]
        public string @StartIp { get; }
    }

}
