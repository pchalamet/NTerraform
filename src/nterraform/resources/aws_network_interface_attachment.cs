using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_network_interface_attachment")]
    public sealed class aws_network_interface_attachment : nterraform.Core.resource
    {
        public aws_network_interface_attachment(int @deviceIndex,
                                                string @instanceId,
                                                string @networkInterfaceId)
        {
            @DeviceIndex = @deviceIndex;
            @InstanceId = @instanceId;
            @NetworkInterfaceId = @networkInterfaceId;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "device_index", @out: false, min: 1, max: 1)]
        public int @DeviceIndex { get; }

        [nterraform.Core.TerraformProperty(name: "instance_id", @out: false, min: 1, max: 1)]
        public string @InstanceId { get; }

        [nterraform.Core.TerraformProperty(name: "network_interface_id", @out: false, min: 1, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.Core.TerraformProperty(name: "attachment_id", @out: true, min: 0, max: 1)]
        public string @AttachmentId { get; }

        [nterraform.Core.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
