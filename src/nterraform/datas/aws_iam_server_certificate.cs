using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.Core.TerraformStructure(category: "data", typeName: "aws_iam_server_certificate")]
    public sealed class aws_iam_server_certificate : nterraform.Core.data
    {
        public aws_iam_server_certificate(bool? @latest = null,
                                          string @namePrefix = null,
                                          string @pathPrefix = null)
        {
            @Latest = @latest;
            @NamePrefix = @namePrefix;
            @PathPrefix = @pathPrefix;
            base._validate_();
        }

        [nterraform.Core.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_body", @out: true, min: 0, max: 1)]
        public string @CertificateBody { get; }

        [nterraform.Core.TerraformProperty(name: "certificate_chain", @out: true, min: 0, max: 1)]
        public string @CertificateChain { get; }

        [nterraform.Core.TerraformProperty(name: "expiration_date", @out: true, min: 0, max: 1)]
        public string @ExpirationDate { get; }

        [nterraform.Core.TerraformProperty(name: "latest", @out: false, min: 0, max: 1)]
        public bool? @Latest { get; }

        [nterraform.Core.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.Core.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.Core.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.Core.TerraformProperty(name: "path_prefix", @out: false, min: 0, max: 1)]
        public string @PathPrefix { get; }

        [nterraform.Core.TerraformProperty(name: "upload_date", @out: true, min: 0, max: 1)]
        public string @UploadDate { get; }
    }

}
