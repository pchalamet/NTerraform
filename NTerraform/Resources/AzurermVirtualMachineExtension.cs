using System.Collections.Generic;

namespace NTerraform.Resources
{
    public class azurerm_virtual_machine_extension : NTerraform.resource
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
        }

        public string @Location { get; }
        public string @Name { get; }
        public string @Publisher { get; }
        public string @ResourceGroupName { get; }
        public string @Type { get; }
        public string @TypeHandlerVersion { get; }
        public string @VirtualMachineName { get; }
        public bool? @AutoUpgradeMinorVersion { get; }
        public string @ProtectedSettings { get; }
        public string @Settings { get; }
        public Dictionary<string,string> @Tags { get; }
    }

}
