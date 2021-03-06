using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.TerraformStructure(category: "resource", typeName: "aws_directory_service_directory")]
    public sealed class aws_directory_service_directory : nterraform.resource
    {
        [nterraform.TerraformStructure(category: "resource", typeName: "connect_settings")]
        public sealed class connect_settings : nterraform.structure
        {
            public connect_settings(string[] @customerDnsIps,
                                    string @customerUsername,
                                    string[] @subnetIds,
                                    string @vpcId)
            {
                @CustomerDnsIps = @customerDnsIps;
                @CustomerUsername = @customerUsername;
                @SubnetIds = @subnetIds;
                @VpcId = @vpcId;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "customer_dns_ips", @out: false, min: 1, max: 1)]
            public string[] @CustomerDnsIps { get; }

            [nterraform.TerraformProperty(name: "customer_username", @out: false, min: 1, max: 1)]
            public string @CustomerUsername { get; }

            [nterraform.TerraformProperty(name: "subnet_ids", @out: false, min: 1, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
            public string @VpcId { get; }
        }

        [nterraform.TerraformStructure(category: "resource", typeName: "vpc_settings")]
        public sealed class vpc_settings : nterraform.structure
        {
            public vpc_settings(string[] @subnetIds,
                                string @vpcId)
            {
                @SubnetIds = @subnetIds;
                @VpcId = @vpcId;
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "subnet_ids", @out: false, min: 1, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.TerraformProperty(name: "vpc_id", @out: false, min: 1, max: 1)]
            public string @VpcId { get; }
        }

        public aws_directory_service_directory(string @name,
                                               string @password,
                                               connect_settings[] @connectSettings = null,
                                               string @description = null,
                                               bool? @enableSso = null,
                                               Dictionary<string,string> @tags = null,
                                               string @type = null,
                                               vpc_settings[] @vpcSettings = null)
        {
            @Name = @name;
            @Password = @password;
            @ConnectSettings = @connectSettings;
            @Description = @description;
            @EnableSso = @enableSso;
            @Tags = @tags;
            @Type = @type;
            @VpcSettings = @vpcSettings;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "password", @out: false, min: 1, max: 1)]
        public string @Password { get; }

        [nterraform.TerraformProperty(name: "access_url", @out: true, min: 0, max: 1)]
        public string @AccessUrl { get; }

        [nterraform.TerraformProperty(name: "alias", @out: true, min: 0, max: 1)]
        public string @Alias { get; }

        [nterraform.TerraformProperty(name: "connect_settings", @out: false, min: 0, max: 1)]
        public connect_settings[] @ConnectSettings { get; }

        [nterraform.TerraformProperty(name: "description", @out: false, min: 0, max: 1)]
        public string @Description { get; }

        [nterraform.TerraformProperty(name: "dns_ip_addresses", @out: true, min: 0, max: 1)]
        public string[] @DnsIpAddresses { get; }

        [nterraform.TerraformProperty(name: "edition", @out: true, min: 0, max: 1)]
        public string @Edition { get; }

        [nterraform.TerraformProperty(name: "enable_sso", @out: false, min: 0, max: 1)]
        public bool? @EnableSso { get; }

        [nterraform.TerraformProperty(name: "security_group_id", @out: true, min: 0, max: 1)]
        public string @SecurityGroupId { get; }

        [nterraform.TerraformProperty(name: "short_name", @out: true, min: 0, max: 1)]
        public string @ShortName { get; }

        [nterraform.TerraformProperty(name: "size", @out: true, min: 0, max: 1)]
        public string @Size { get; }

        [nterraform.TerraformProperty(name: "tags", @out: false, min: 0, max: 1)]
        public Dictionary<string,string> @Tags { get; }

        [nterraform.TerraformProperty(name: "type", @out: false, min: 0, max: 1)]
        public string @Type { get; }

        [nterraform.TerraformProperty(name: "vpc_settings", @out: false, min: 0, max: 1)]
        public vpc_settings[] @VpcSettings { get; }
    }

}
