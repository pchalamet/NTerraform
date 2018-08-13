using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_lightsail_instance")]
    public sealed class aws_lightsail_instance : nterraform.resource
    {
        public aws_lightsail_instance(string @availabilityZone,
                                      string @blueprintId,
                                      string @bundleId,
                                      string @name,
                                      string @keyPairName = null,
                                      string @userData = null)
        {
            @AvailabilityZone = @availabilityZone;
            @BlueprintId = @blueprintId;
            @BundleId = @bundleId;
            @Name = @name;
            @KeyPairName = @keyPairName;
            @UserData = @userData;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "availability_zone", @out: false, min: 1, max: 1)]
        public string @AvailabilityZone { get; }

        [nterraform.TerraformProperty(name: "blueprint_id", @out: false, min: 1, max: 1)]
        public string @BlueprintId { get; }

        [nterraform.TerraformProperty(name: "bundle_id", @out: false, min: 1, max: 1)]
        public string @BundleId { get; }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "cpu_count", @out: true, min: 0, max: 1)]
        public int? @CpuCount { get; }

        [nterraform.TerraformProperty(name: "created_at", @out: true, min: 0, max: 1)]
        public string @CreatedAt { get; }

        [nterraform.TerraformProperty(name: "ipv6_address", @out: true, min: 0, max: 1)]
        public string @Ipv6Address { get; }

        [nterraform.TerraformProperty(name: "is_static_ip", @out: true, min: 0, max: 1)]
        public bool? @IsStaticIp { get; }

        [nterraform.TerraformProperty(name: "key_pair_name", @out: false, min: 0, max: 1)]
        public string @KeyPairName { get; }

        [nterraform.TerraformProperty(name: "private_ip_address", @out: true, min: 0, max: 1)]
        public string @PrivateIpAddress { get; }

        [nterraform.TerraformProperty(name: "public_ip_address", @out: true, min: 0, max: 1)]
        public string @PublicIpAddress { get; }

        [nterraform.TerraformProperty(name: "ram_size", @out: true, min: 0, max: 1)]
        public int? @RamSize { get; }

        [nterraform.TerraformProperty(name: "user_data", @out: false, min: 0, max: 1)]
        public string @UserData { get; }

        [nterraform.TerraformProperty(name: "username", @out: true, min: 0, max: 1)]
        public string @Username { get; }
    }

}
