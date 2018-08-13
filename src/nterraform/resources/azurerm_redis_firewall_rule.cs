using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_redis_firewall_rule")]
    public sealed class azurerm_redis_firewall_rule : nterraform.resource
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
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "end_ip", @out: false, min: 1, max: 1)]
        public string @EndIp { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "redis_cache_name", @out: false, min: 1, max: 1)]
        public string @RedisCacheName { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "start_ip", @out: false, min: 1, max: 1)]
        public string @StartIp { get; }
    }

}
