using System.Collections.Generic;

namespace NTerraform.Resources
{
    [TerraformStructure(category: "resource", typeName: "azurerm_virtual_machine_data_disk_attachment")]
    public sealed class azurerm_virtual_machine_data_disk_attachment : NTerraform.resource
    {
        public azurerm_virtual_machine_data_disk_attachment(string @caching,
                                                            int @lun,
                                                            string @managedDiskId,
                                                            string @virtualMachineId,
                                                            string @createOption = null,
                                                            bool? @writeAcceleratorEnabled = null)
        {
            @Caching = @caching;
            @Lun = @lun;
            @ManagedDiskId = @managedDiskId;
            @VirtualMachineId = @virtualMachineId;
            @CreateOption = @createOption;
            @WriteAcceleratorEnabled = @writeAcceleratorEnabled;
        }

        [TerraformProperty(name: "caching", @out: false, min: 1, max: 1)]
        public string @Caching { get; }

        [TerraformProperty(name: "lun", @out: false, min: 1, max: 1)]
        public int @Lun { get; }

        [TerraformProperty(name: "managed_disk_id", @out: false, min: 1, max: 1)]
        public string @ManagedDiskId { get; }

        [TerraformProperty(name: "virtual_machine_id", @out: false, min: 1, max: 1)]
        public string @VirtualMachineId { get; }

        [TerraformProperty(name: "create_option", @out: false, min: 0, max: 1)]
        public string @CreateOption { get; }

        [TerraformProperty(name: "write_accelerator_enabled", @out: false, min: 0, max: 1)]
        public bool? @WriteAcceleratorEnabled { get; }
    }

}
