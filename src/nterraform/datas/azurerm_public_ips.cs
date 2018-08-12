using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_public_ips")]
    public sealed class azurerm_public_ips : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "public_ips")]
        public sealed class public_ips : nterraform.Core.structure
        {
            public public_ips()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "domain_name_label", @out: true, min: 0, max: 1)]
            public string @DomainNameLabel { get; }

            [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
            public string @Fqdn { get; }

            [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.Core.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
            public string @IpAddress { get; }

            [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
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
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "allocation_type", @out: false, min: 0, max: 1)]
        public string @AllocationType { get; }

        [nterraform.Core.TerraformProperty(name: "attached", @out: false, min: 0, max: 1)]
        public bool? @Attached { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "public_ips", @out: false, min: 0, max: 0)]
        public public_ips[] @PublicIps { get; }
    }

}
