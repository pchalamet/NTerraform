using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_data_lake_store_firewall_rule")]
    public sealed class azurerm_data_lake_store_firewall_rule : NTerraform.resource
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

        [TerraformProperty(name: "account_name", @out: false, min: 1, max: 1)]
        public string @AccountName { get; }

        [TerraformProperty(name: "end_ip_address", @out: false, min: 1, max: 1)]
        public string @EndIpAddress { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "start_ip_address", @out: false, min: 1, max: 1)]
        public string @StartIpAddress { get; }
    }

}
