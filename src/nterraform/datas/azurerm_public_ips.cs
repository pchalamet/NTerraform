using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "azurerm_public_ips")]
    public sealed class azurerm_public_ips : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "public_ips")]
        public sealed class public_ips : nterraform.structure
        {
            public public_ips()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "domain_name_label", @out: true, min: 0, max: 1)]
            public string @DomainNameLabel { get; }

            [nterraform.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
            public string @Fqdn { get; }

            [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
            public string @Id { get; }

            [nterraform.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
            public string @IpAddress { get; }

            [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
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

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "allocation_type", @out: false, min: 0, max: 1)]
        public string @AllocationType { get; }

        [nterraform.TerraformProperty(name: "attached", @out: false, min: 0, max: 1)]
        public bool? @Attached { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "public_ips", @out: false, min: 0, max: 0)]
        public public_ips[] @PublicIps { get; }
    }

}
