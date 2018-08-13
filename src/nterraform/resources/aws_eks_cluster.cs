using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_eks_cluster")]
    public sealed class aws_eks_cluster : nterraform.Core.resource
    {
        [nterraform.Core.TerraformStructure(category: "resource", typeName: "vpc_config")]
        public sealed class vpc_config : nterraform.Core.structure
        {
            public vpc_config(string[] @subnetIds,
                              string[] @securityGroupIds = null)
            {
                @SubnetIds = @subnetIds;
                @SecurityGroupIds = @securityGroupIds;
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "subnet_ids", @out: false, min: 1, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: false, min: 0, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "resource", typeName: "certificate_authority")]
        public sealed class certificate_authority : nterraform.Core.structure
        {
            public certificate_authority()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "data", @out: true, min: 0, max: 1)]
            public string @Data { get; }
        }

        public aws_eks_cluster(string @name,
                               string @roleArn,
                               vpc_config[] @vpcConfig,
                               certificate_authority[] @certificateAuthority = null)
        {
            @Name = @name;
            @RoleArn = @roleArn;
            @VpcConfig = @vpcConfig;
            @CertificateAuthority = @certificateAuthority;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: false, min: 1, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_config", @out: false, min: 1, max: 1)]
        public vpc_config[] @VpcConfig { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_authority", @out: false, min: 0, max: 1)]
        public certificate_authority[] @CertificateAuthority { get; }

        [nterraform.Core.TerraformProperty(name: "created_at", @out: true, min: 0, max: 1)]
        public string @CreatedAt { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }
    }

}
