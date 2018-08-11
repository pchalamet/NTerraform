using System.Collections.Generic;

namespace NTerraform.Datas
{
    public sealed class azurerm_public_ip : NTerraform.data
    {
        public azurerm_public_ip(string @name,
                                 string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
        }

        public string @Name { get; }
        public string @ResourceGroupName { get; }
        public string @DomainNameLabel { get; }
        public string @Fqdn { get; }
        public int? @IdleTimeoutInMinutes { get; }
        public string @IpAddress { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
