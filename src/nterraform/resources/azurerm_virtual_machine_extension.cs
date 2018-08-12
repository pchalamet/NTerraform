using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine_extension")]
    public sealed class azurerm_virtual_machine_extension : nterraform.Core.resource
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

        [nterraform.Core.TerraformProperty(name: "location", @out: false, min: 1, max: 1)]
        public string @Location { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "publisher", @out: false, min: 1, max: 1)]
        public string @Publisher { get; }

        [nterraform.Core.TerraformProperty(name: "resource_group_name", @out: false, min: 1, max: 1)]
        public string @ResourceGroupName { get; }

        [nterraform.Core.TerraformProperty(name: "type", @out: false, min: 1, max: 1)]
        public string @Type { get; }

        [nterraform.Core.TerraformProperty(name: "type_handler_version", @out: false, min: 1, max: 1)]
        public string @TypeHandlerVersion { get; }

        [nterraform.Core.TerraformProperty(name: "virtual_machine_name", @out: false, min: 1, max: 1)]
        public string @VirtualMachineName { get; }

        [nterraform.Core.TerraformProperty(name: "auto_upgrade_minor_version", @out: false, min: 0, max: 1)]
        public bool? @AutoUpgradeMinorVersion { get; }

        [nterraform.Core.TerraformProperty(name: "protected_settings", @out: false, min: 0, max: 1)]
        public string @ProtectedSettings { get; }

        [nterraform.Core.TerraformProperty(name: "settings", @out: false, min: 0, max: 1)]
        public string @Settings { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
