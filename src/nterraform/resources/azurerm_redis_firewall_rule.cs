using System.Collections.Generic;

namespace nterraform.resources.azurerm
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_redis_firewall_rule")]
    public sealed class azurerm_redis_firewall_rule : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "end_ip", @out: false, min: 1, max: 1)]
        public string @EndIp { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "redis_cache_name", @out: false, min: 1, max: 1)]
        public string @RedisCacheName { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "start_ip", @out: false, min: 1, max: 1)]
        public string @StartIp { get; }
    }

}
