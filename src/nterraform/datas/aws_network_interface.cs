using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_network_interface")]
    public sealed class aws_network_interface : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "association")]
        public sealed class association : nterraform.Core.structure
        {
            public association()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "allocation_id", @out: true, min: 0, max: 1)]
            public string @AllocationId { get; }

            [nterraform.Core.TerraformProperty(name: "association_id", @out: true, min: 0, max: 1)]
            public string @AssociationId { get; }

            [nterraform.Core.TerraformProperty(name: "ip_owner_id", @out: true, min: 0, max: 1)]
            public string @IpOwnerId { get; }

            [nterraform.Core.TerraformProperty(name: "public_dns_name", @out: true, min: 0, max: 1)]
            public string @PublicDnsName { get; }

            [nterraform.Core.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
            public string @PublicIp { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "attachment")]
        public sealed class attachment : nterraform.Core.structure
        {
            public attachment()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "attachment_id", @out: true, min: 0, max: 1)]
            public string @AttachmentId { get; }

            [nterraform.Core.TerraformProperty(name: "device_index", @out: true, min: 0, max: 1)]
            public int? @DeviceIndex { get; }

            [nterraform.Core.TerraformProperty(name: "instance_id", @out: true, min: 0, max: 1)]
            public string @InstanceId { get; }

            [nterraform.Core.TerraformProperty(name: "instance_owner_id", @out: true, min: 0, max: 1)]
            public string @InstanceOwnerId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.Core.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.Core.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        public aws_network_interface(association[] @association = null,
                                     attachment[] @attachment = null,
                                     filter[] @filter = null)
        {
            @Association = @association;
            @Attachment = @attachment;
            @Filter = @filter;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "association", @out: false, min: 0, max: 0)]
        public association[] @Association { get; }

        [nterraform.Core.TerraformProperty(name: "attachment", @out: false, min: 0, max: 0)]
        public attachment[] @Attachment { get; }

        [nterraform.Core.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.Core.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.Core.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.Core.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.Core.TerraformProperty(name: "interface_type", @out: true, min: 0, max: 1)]
        public string @InterfaceType { get; }

        [nterraform.Core.TerraformProperty(name: "ipv6_addresses", @out: true, min: 0, max: 1)]
        public string[] @Ipv6Addresses { get; }

        [nterraform.Core.TerraformProperty(name: "mac_address", @out: true, min: 0, max: 1)]
        public string @MacAddress { get; }

        [nterraform.Core.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.Core.TerraformProperty(name: "private_dns_name", @out: true, min: 0, max: 1)]
        public string @PrivateDnsName { get; }

        [nterraform.Core.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.Core.TerraformProperty(name: "private_ips", @out: true, min: 0, max: 1)]
        public string[] @PrivateIps { get; }

        [nterraform.Core.TerraformProperty(name: "requester_id", @out: true, min: 0, max: 1)]
        public string @RequesterId { get; }

        [nterraform.Core.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.Core.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.Core.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
