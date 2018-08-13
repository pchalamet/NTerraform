using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_network_interface_attachment")]
    public sealed class aws_network_interface_attachment : nterraform.resource
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

        [nterraform.TerraformProperty(name: "device_index", @out: false, min: 1, max: 1)]
        public int @DeviceIndex { get; }

        [nterraform.TerraformProperty(name: "instance_id", @out: false, min: 1, max: 1)]
        public string @InstanceId { get; }

        [nterraform.TerraformProperty(name: "network_interface_id", @out: false, min: 1, max: 1)]
        public string @NetworkInterfaceId { get; }

        [nterraform.TerraformProperty(name: "attachment_id", @out: true, min: 0, max: 1)]
        public string @AttachmentId { get; }

        [nterraform.TerraformProperty(name: "status", @out: true, min: 0, max: 1)]
        public string @Status { get; }
    }

}
