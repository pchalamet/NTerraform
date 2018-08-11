using System.Collections.Generic;

namespace NTerraform.Resources
{
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

        public string @Caching { get; }
        public int @Lun { get; }
        public string @ManagedDiskId { get; }
        public string @VirtualMachineId { get; }
        public string @CreateOption { get; }
        public bool? @WriteAcceleratorEnabled { get; }
    }

}
