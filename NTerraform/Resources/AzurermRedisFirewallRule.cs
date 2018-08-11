using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @EndIp { get; }
        public string @Name { get; }
        public string @RedisCacheName { get; }
        public string @ResourceGroupName { get; }
        public string @StartIp { get; }
    }

}
