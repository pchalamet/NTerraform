using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_eks_cluster")]
    public sealed class aws_eks_cluster : nterraform.data
    {
        [nterraform.TerraformStructure(category: "data", typeName: "certificate_authority")]
        public sealed class certificate_authority : nterraform.structure
        {
            public certificate_authority()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "data", @out: true, min: 0, max: 1)]
            public string @Data { get; }
        }

        [nterraform.TerraformStructure(category: "data", typeName: "vpc_config")]
        public sealed class vpc_config : nterraform.structure
        {
            public vpc_config()
            {
                base._validate_();
            }

            [nterraform.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        public aws_eks_cluster(string @name,
                               certificate_authority[] @certificateAuthority = null,
                               vpc_config[] @vpcConfig = null)
        {
            @Name = @name;
            @CertificateAuthority = @certificateAuthority;
            @VpcConfig = @vpcConfig;
            base._validate_();
        }

        [nterraform.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "certificate_authority", @out: false, min: 0, max: 1)]
        public certificate_authority[] @CertificateAuthority { get; }

        [nterraform.TerraformProperty(name: "created_at", @out: true, min: 0, max: 1)]
        public string @CreatedAt { get; }

        [nterraform.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.TerraformProperty(name: "role_arn", @out: true, min: 0, max: 1)]
        public string @RoleArn { get; }

        [nterraform.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }

        [nterraform.TerraformProperty(name: "vpc_config", @out: false, min: 0, max: 1)]
        public vpc_config[] @VpcConfig { get; }
    }

}
