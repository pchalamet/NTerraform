using System.Collections.Generic;

namespace nterraform.resources
{
    [nterraform.Core.TerraformStructure(category: "resource", typeName: "aws_iam_server_certificate")]
    public sealed class aws_iam_server_certificate : nterraform.Core.resource
    {
        public aws_iam_server_certificate(string @certificateBody,
                                          string @privateKey,
                                          string @certificateChain = null,
                                          string @namePrefix = null,
                                          string @path = null)
        {
            @CertificateBody = @certificateBody;
            @PrivateKey = @privateKey;
            @CertificateChain = @certificateChain;
            @NamePrefix = @namePrefix;
            @Path = @path;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "certificate_body", @out: false, min: 1, max: 1)]
        public string @CertificateBody { get; }

        [nterraform.Core.TerraformProperty(name: "private_key", @out: false, min: 1, max: 1)]
        public string @PrivateKey { get; }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_chain", @out: false, min: 0, max: 1)]
        public string @CertificateChain { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: false, min: 0, max: 1)]
        public string @Path { get; }
    }

}
