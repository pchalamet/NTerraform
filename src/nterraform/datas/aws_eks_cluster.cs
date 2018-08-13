using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_eks_cluster")]
    public sealed class aws_eks_cluster : nterraform.Core.data
    {
        [nterraform.Core.TerraformStructure(category: "data", typeName: "vpc_config")]
        public sealed class vpc_config : nterraform.Core.structure
        {
            public vpc_config()
            {
                base._validate_();
            }

            [nterraform.Core.TerraformProperty(name: "security_group_ids", @out: true, min: 0, max: 1)]
            public string[] @SecurityGroupIds { get; }

            [nterraform.Core.TerraformProperty(name: "subnet_ids", @out: true, min: 0, max: 1)]
            public string[] @SubnetIds { get; }

            [nterraform.Core.TerraformProperty(name: "vpc_id", @out: true, min: 0, max: 1)]
            public string @VpcId { get; }
        }

        [nterraform.Core.TerraformStructure(category: "data", typeName: "certificate_authority")]
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
                               certificate_authority[] @certificateAuthority = null,
                               vpc_config[] @vpcConfig = null)
        {
            @Name = @name;
            @CertificateAuthority = @certificateAuthority;
            @VpcConfig = @vpcConfig;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "name", @out: false, min: 1, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_authority", @out: false, min: 0, max: 1)]
        public certificate_authority[] @CertificateAuthority { get; }

        [nterraform.Core.TerraformProperty(name: "created_at", @out: true, min: 0, max: 1)]
        public string @CreatedAt { get; }

        [nterraform.Core.TerraformProperty(name: "endpoint", @out: true, min: 0, max: 1)]
        public string @Endpoint { get; }

        [nterraform.Core.TerraformProperty(name: "role_arn", @out: true, min: 0, max: 1)]
        public string @RoleArn { get; }

        [nterraform.Core.TerraformProperty(name: "version", @out: true, min: 0, max: 1)]
        public string @Version { get; }

        [nterraform.Core.TerraformProperty(name: "vpc_config", @out: false, min: 0, max: 1)]
        public vpc_config[] @VpcConfig { get; }
    }

}
