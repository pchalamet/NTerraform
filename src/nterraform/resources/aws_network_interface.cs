using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_network_interface")]
    public sealed class aws_network_interface : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "attachment")]
        public sealed class attachment : nterraform.Core.structure
        {
            public attachment(int @deviceIndex,
                              string @instance)
            {
                @DeviceIndex = @deviceIndex;
                @Instance = @instance;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "device_index", @out: false, min: 1, max: 1)]
            public int @DeviceIndex { get; }

            [nterraform.Core.TerraformProperty(name: "instance", @out: false, min: 1, max: 1)]
            public string @Instance { get; }

            [nterraform.Core.TerraformProperty(name: "attachment_id", @out: true, min: 0, max: 1)]
            public string @AttachmentId { get; }
        }

        public aws_network_interface(string @subnetId,
                                     attachment[] @attachment = null,
                                     string @description = null,
                                     bool? @sourceDestCheck = null,
                                     Dictionary<string,string> @tags = null)
        {
            @SubnetId = @subnetId;
            @Attachment = @attachment;
            @Description = @description;
            @SourceDestCheck = @sourceDestCheck;
            @Tags = @tags;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: false, min: 1, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "attachment", @out: false, min: 0, max: 0)]
        public attachment[] @Attachment { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "private_dns_name", @out: true, min: 0, max: 1)]
        public string @PrivateDnsName { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.Core.TerraformProperty(name: "private_ips", @out: true, min: 0, max: 1)]
        public string[] @PrivateIps { get; }

        [nterraform.Core.TerraformProperty(name: "private_ips_count", @out: true, min: 0, max: 1)]
        public int? @PrivateIpsCount { get; }

        [nterraform.Core.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "source_dest_check", @out: false, min: 0, max: 1)]
        public bool? @SourceDestCheck { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }
    }

}
