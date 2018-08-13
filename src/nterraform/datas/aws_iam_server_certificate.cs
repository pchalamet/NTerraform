using System.Collections.Generic;

namespace nterraform.datas
{
    [nterraform.TerraformStructure(category: "data", typeName: "aws_iam_server_certificate")]
    public sealed class aws_iam_server_certificate : nterraform.data
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

        [nterraform.TerraformProperty(name: "arn", @out: true, min: 0, max: 1)]
        public string @Arn { get; }

        [nterraform.TerraformProperty(name: "certificate_body", @out: true, min: 0, max: 1)]
        public string @CertificateBody { get; }

        [nterraform.TerraformProperty(name: "certificate_chain", @out: true, min: 0, max: 1)]
        public string @CertificateChain { get; }

        [nterraform.TerraformProperty(name: "expiration_date", @out: true, min: 0, max: 1)]
        public string @ExpirationDate { get; }

        [nterraform.TerraformProperty(name: "latest", @out: false, min: 0, max: 1)]
        public bool? @Latest { get; }

        [nterraform.TerraformProperty(name: "name", @out: true, min: 0, max: 1)]
        public string @Name { get; }

        [nterraform.TerraformProperty(name: "name_prefix", @out: false, min: 0, max: 1)]
        public string @NamePrefix { get; }

        [nterraform.TerraformProperty(name: "path", @out: true, min: 0, max: 1)]
        public string @Path { get; }

        [nterraform.TerraformProperty(name: "path_prefix", @out: false, min: 0, max: 1)]
        public string @PathPrefix { get; }

        [nterraform.TerraformProperty(name: "upload_date", @out: true, min: 0, max: 1)]
        public string @UploadDate { get; }
    }

}
