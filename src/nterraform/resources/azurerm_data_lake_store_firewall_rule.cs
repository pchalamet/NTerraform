using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "azurerm_data_lake_store_firewall_rule")]
    public sealed class azurerm_data_lake_store_firewall_rule : nterraform.resource
    {
        public azurerm_data_lake_store_firewall_rule(string @accountName,
                                                     string @endIpAddress,
                                                     string @name,
                                                     string @resourceGroupName,
                                                     string @startIpAddress)
        {
            @AccountName = @accountName;
            @EndIpAddress = @endIpAddress;
            @Name = @name;
            @ResourceGroupName = @resourceGroupName;
            @StartIpAddress = @startIpAddress;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "account_name", @out: false, min: 1, max: 1)]
        public string @AccountName { get; }

        [nterraform.TerraformProperty(name: "end_ip_address", @out: false, min: 1, max: 1)]
        public string @EndIpAddress { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.TerraformProperty(name: "start_ip_address", @out: false, min: 1, max: 1)]
        public string @StartIpAddress { get; }
    }

}
