using System.Collections.Generic;

namespace NTerraform.Datas
{
    public class azurerm_public_ips : NTerraform.data
    {
        public class public_ips
        {
            public public_ips()
            {
            }

            public string @DomainNameLabel { get; }
            public string @Fqdn { get; }
            public string @Id { get; }
            public string @IpAddress { get; }
            public string @Name { get; }
        }

        public azurerm_public_ips(string @resourceGroupName,
                                  string @allocationType = null,
                                  bool? @attached = null,
                                  string @namePrefix = null,
                                  public_ips[] @publicIps = null)
        {
            @ResourceGroupName = @resourceGroupName;
            @AllocationType = @allocationType;
            @Attached = @attached;
            @NamePrefix = @namePrefix;
            @PublicIps = @publicIps;
        }

        public string @ResourceGroupName { get; }
        public string @AllocationType { get; }
        public bool? @Attached { get; }
        public string @NamePrefix { get; }
        public public_ips[] @PublicIps { get; }
    }

}
