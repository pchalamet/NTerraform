using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "azurerm_public_ip")]
    public sealed class azurerm_public_ip : nterraform.Core.data
    {
        public azurerm_public_ip(string @name,
                                 string @resourceGroupName)
        {
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "domain_name_label", @out: true, min: 0, max: 1)]
        public string @DomainNameLabel { get; }

        [nterraform.Core.TerraformProperty(name: "fqdn", @out: true, min: 0, max: 1)]
        public string @Fqdn { get; }

        [nterraform.Core.TerraformProperty(name: "idle_timeout_in_minutes", @out: true, min: 0, max: 1)]
        public int? @IdleTimeoutInMinutes { get; }

        [nterraform.Core.TerraformProperty(name: "ip_address", @out: true, min: 0, max: 1)]
        public string @IpAddress { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
