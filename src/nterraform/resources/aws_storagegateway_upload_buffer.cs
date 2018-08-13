using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_storagegateway_upload_buffer")]
    public sealed class aws_storagegateway_upload_buffer : nterraform.Core.resource
    {
        public aws_storagegateway_upload_buffer(string @diskId,
                                                string @gatewayArn)
        {
            @DiskId = @diskId;
            @GatewayArn = @gatewayArn;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "disk_id", @out: false, min: 1, max: 1)]
        public string @DiskId { get; }

        [nterraform.Core.TerraformProperty(name: "gateway_arn", @out: false, min: 1, max: 1)]
        public string @GatewayArn { get; }
    }

}
