using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine_extension")]
    public sealed class azurerm_virtual_machine_extension : NTerraform.resource
    {
        public azurerm_virtual_machine_extension(string @location,
                                                 string @name,
                                                 string @publisher,
                                                 string @resourceGroupName,
                                                 string @type,
                                                 string @typeHandlerVersion,
                                                 string @virtualMachineName,
                                                 bool? @autoUpgradeMinorVersion = null,
                                                 string @protectedSettings = null,
                                                 string @settings = null)
        {
            @Location = @location;
            @Name = @name;
            @Publisher = @publisher;
            @ResourceGroupName = @resourceGroupName;
            @Type = @type;
            @TypeHandlerVersion = @typeHandlerVersion;
            @VirtualMachineName = @virtualMachineName;
            @AutoUpgradeMinorVersion = @autoUpgradeMinorVersion;
            @ProtectedSettings = @protectedSettings;
            @Settings = @settings;
            base._validate_();
        }

        [TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
        public string @Publisher { get; }

        [TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [TerraformProperty(name: "type_handler_version", @out: false, min: 1, max: 1)]
        public string @TypeHandlerVersion { get; }

        [TerraformProperty(name: "virtual_machine_name", @out: false, min: 1, max: 1)]
        public string @VirtualMachineName { get; }

        [TerraformProperty(name: "auto_upgrade_minor_version", @out: false, min: 0, max: 1)]
        public bool? @AutoUpgradeMinorVersion { get; }

        [TerraformProperty(name: "protected_settings", @out: false, min: 0, max: 1)]
        public string @ProtectedSettings { get; }

        [TerraformProperty(name: "settings", @out: false, min: 0, max: 1)]
        public string @Settings { get; }

        [TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
