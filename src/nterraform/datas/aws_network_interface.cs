using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_network_interface")]
    public sealed class aws_network_interface : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "association")]
        public sealed class association : nterraform.structure
        {
            public association()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "allocation_id", @out: true, min: 0, max: 1)]
            public string @AllocationId { get; }

            [nterraform.TerraformProperty(name: "association_id", @out: true, min: 0, max: 1)]
            public string @AssociationId { get; }

            [nterraform.TerraformProperty(name: "ip_owner_id", @out: true, min: 0, max: 1)]
            public string @IpOwnerId { get; }

            [nterraform.TerraformProperty(name: "public_dns_name", @out: true, min: 0, max: 1)]
            public string @PublicDnsName { get; }

            [nterraform.TerraformProperty(name: "public_ip", @out: true, min: 0, max: 1)]
            public string @PublicIp { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "filter")]
        public sealed class filter : nterraform.structure
        {
            public filter(string @name,
                          string[] @values)
            {
                @Name = @name;
                @Values = @values;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
            public string @Name { get; }

            [nterraform.TerraformProperty(name: "values", @out: false, min: 1, max: 1)]
            public string[] @Values { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "attachment")]
        public sealed class attachment : nterraform.structure
        {
            public attachment()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "attachment_id", @out: true, min: 0, max: 1)]
            public string @AttachmentId { get; }

            [nterraform.TerraformProperty(name: "device_index", @out: true, min: 0, max: 1)]
            public int? @DeviceIndex { get; }

            [nterraform.TerraformProperty(name: "instance_id", @out: true, min: 0, max: 1)]
            public string @InstanceId { get; }

            [nterraform.TerraformProperty(name: "instance_owner_id", @out: true, min: 0, max: 1)]
            public string @InstanceOwnerId { get; }
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

        [nterraform.TerraformProperty(name: "association", @out: false, min: 0, max: 0)]
        public association[] @Association { get; }

        [nterraform.TerraformProperty(name: "attachment", @out: false, min: 0, max: 0)]
        public attachment[] @Attachment { get; }

        [nterraform.TerraformProperty(name: "availability_zone", @out: true, min: 0, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "description", @out: true, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "filter", @out: false, min: 0, max: 0)]
        public filter[] @Filter { get; }

        [nterraform.TerraformProperty(name: "id", @out: true, min: 0, max: 1)]
        public string @Id { get; }

        [nterraform.TerraformProperty(name: "interface_type", @out: true, min: 0, max: 1)]
        public string @InterfaceType { get; }

        [nterraform.TerraformProperty(name: "ipv6_addresses", @out: true, min: 0, max: 1)]
        public string[] @Ipv6Addresses { get; }

        [nterraform.TerraformProperty(name: "mac_address", @out: true, min: 0, max: 1)]
        public string @MacAddress { get; }

        [nterraform.TerraformProperty(name: "owner_id", @out: true, min: 0, max: 1)]
        public string @OwnerId { get; }

        [nterraform.TerraformProperty(name: "private_dns_name", @out: true, min: 0, max: 1)]
        public string @PrivateDnsName { get; }

        [nterraform.TerraformProperty(name: "private_ip", @out: true, min: 0, max: 1)]
        public string @PrivateIp { get; }

        [nterraform.TerraformProperty(name: "private_ips", @out: true, min: 0, max: 1)]
        public string[] @PrivateIps { get; }

        [nterraform.TerraformProperty(name: "requester_id", @out: true, min: 0, max: 1)]
        public string @RequesterId { get; }

        [nterraform.TerraformProperty(name: "security_groups", @out: true, min: 0, max: 1)]
        public string[] @SecurityGroups { get; }

        [nterraform.TerraformProperty(name: "subnet_id", @out: true, min: 0, max: 1)]
        public string @SubnetId { get; }

        [nterraform.TerraformProperty(name: "tags", @out: true, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
        public string @VpcId { get; }
    }

}
